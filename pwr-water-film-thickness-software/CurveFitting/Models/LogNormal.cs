using System;
using System.Collections.Generic;

namespace pwr_water_film_thickness_software.CurveFitting
{
    internal class LogNormal : FunctionBase
    {
        /// <summary>
        /// parameters[0] = h; height
        /// parameters[1] = c; center
        /// parameters[2] = w; width
        /// parameters[3] = b; asym

        public LogNormal(double[][] data) : base(data)
        {
            base.parameters = new double[4];
            base.parameters[0] = maxY;
            base.parameters[1] = (maxX - minX) / 2 + minX;
            base.parameters[2] = maxX - minX;
            base.parameters[3] = 0.5;
        }
        public override double GetY(double x, double[] a)
        {
            double logArg = 2.0 * a[3] * (x - a[1]) / a[2] + 1;
            double result = a[0] * Math.Exp(-Math.Log(2) * (Math.Log(logArg) / a[3]) * (Math.Log(logArg) / a[3]));
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
                f = f = GetY(x[i], p);
                dy[i] = (y[i] - f) / ey[i];
            }

            return 0;
        }
    }
}
