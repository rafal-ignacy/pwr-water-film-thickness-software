using System;
using System.Collections.Generic;

namespace pwr_water_film_thickness_software.CurveFitting
{
    internal class Gauss : FunctionBase
    {
        /// <summary>
        /// parameters[0] = P1;
        /// parameters[1] = P2;
        /// parameters[2] = P3;
        /// parameters[3] = C;  
        public Gauss(double[][] data) : base(data)
        {
            base.parameters = new double[3];
            base.parameters[2] = maxX - minX;
            base.parameters[1] = (maxX - minX) / 2 + minX;
            base.parameters[1] = data[0][Array.IndexOf(data[1], maxY)];
            base.parameters[0] = maxY;
        }
        public override double GetY(double x, double[] a)
        {
            double result = a[0] * Math.Exp(-1 * Math.Log(2) * Math.Pow(((x - a[1]) / a[2]), 2));
            return result;
        }
        public override double CalculateCenterLength()
        {
            return parameters[1];
        }
        public override int MPFunction(double[] p, double[] dy, IList<double>[] dvec, object vars)
        {
            int i;
            double[] x, y, ey;
            double f;

            DataVariable v = (DataVariable)vars;

            x = v.X;
            y = v.Y;
            ey = v.Ey;

            for (i = 0; i < dy.Length; i++)
            {
                f = GetY(x[i], p);
                dy[i] = (y[i] - f) / ey[i];
            }

            return 0;
        }
    }
}
