using System;
using System.Collections.Generic;
using System.Linq;

namespace pwr_water_film_thickness_software
{
    public abstract class FunctionBase
    {
        protected double minY, maxY, minX, maxX;
        protected double[] parameters;
        protected double CenterLength, FWHM;

        public FunctionBase(double[][] data)
        {
            if (data[0].Length > 0 && data[1].Length > 0)
            {
                this.minY = data[1].Min();
                this.maxY = data[1].Max();
                this.minX = data[0][0];
                this.maxX = data[0][data[0].Length - 1];
            }
            this.CenterLength = -1;
            this.FWHM = -1;
        }
        public double[] getParameters()
        {
            return this.parameters;
        }
        public void setParameters(double[] _parameters)
        {
            this.parameters = _parameters;

        }
        public double[][] Process(double start, double end, int points = 1001)
        {
            double[][] output = new double[2][];
            output[0] = new double[points];
            output[1] = new double[points];
            double gapX = Math.Abs((end - start) / (points - 1));

            for (int i = 0; i < points; i++)
            {
                if (i == points - 1)
                    output[0][i] = end;
                else
                    output[0][i] = start + i * gapX;
                output[1][i] = GetY(output[0][i], this.parameters);

            }
            return output;
        }
        public virtual double CalculateCenterLength()
        {
            double output, max_Y = 0, start = this.minX, end = this.maxX;
            int max_Y_cord = 0;
            double[][] data;
            start = Math.Floor(start);
            end = Math.Ceiling(end);
            int points = Convert.ToInt32(Math.Abs(end - start));
            double range = 1;
            data = Process(start, end, (points + 1) * 2);

            for (int j = 0; j < 15; j++)
            {
                if (j != 0)
                {
                    double old_max_Y = max_Y;
                    double old_max_X = data[0][max_Y_cord];
                    data = Process(start, end, 20);
                    Array.Resize(ref data[0], data[0].Length + 1);
                    Array.Resize(ref data[1], data[1].Length + 1);
                    data[0][data[0].Length - 1] = old_max_X;
                    data[1][data[1].Length - 1] = old_max_Y;
                }
                for (int i = 0; i < data[1].Length; i++)
                {
                    if (data[1][i] >= max_Y)
                    {
                        max_Y = data[1][i];
                        max_Y_cord = i;
                    }
                }

                start = data[0][max_Y_cord] - range;
                end = data[0][max_Y_cord] + range;
                range = range / 10;
            }
            output = data[0][max_Y_cord];
            this.CenterLength = output;
            return output;
        }
        public abstract double GetY(double x, double[] a);
        public abstract int MPFunction(double[] p, double[] dy, IList<double>[] dvec, object vars);
    }
}
