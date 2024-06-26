using System;
using System.Collections.Generic;
using System.Linq;
using pwr_water_film_thickness_software.DataModels;
using pwr_water_film_thickness_software.CurveFitting;
using MathNet.Numerics.LinearAlgebra;
using MPFitLib;

namespace pwr_water_film_thickness_software
{
    public class SpectrumDataProcessing
    {
        private double[][] data;
        private FunctionBase function;

        public SpectrumDataProcessing(List<SpectrumRow> _spectrumData)
        {
            List<SpectrumRow> spectrumData = _spectrumData;

            this.data = new double[2][];
            this.data[0] = new double[spectrumData.Count];  /// X
            this.data[1] = new double[spectrumData.Count];  /// Y

            spectrumData.Sort((x, y) => x.WaveLength.CompareTo(y.WaveLength));

            for (int i = 0; i < spectrumData.Count; i++)
            {
                data[0][i] = spectrumData[i].WaveLength;
                data[1][i] = spectrumData[i].SpectrumValues.Average();
            }
        }
        public double[][] getPoints(double start, double end, int amount = 100)
        {
            return function.Process(start, end, amount);
        }
        public int FindLocalMinima()
        {

            SGFilter(this.data, 120, 2);
            SGFilter(this.data, 50, 3);

            int localMinimaIndex = 0;

            for (int i = 1; i < this.data[0].Length - 1; i++)
            {
                if ((this.data[1][i - 1] > this.data[1][i]) && (this.data[1][i] < this.data[1][i + 1]))
                {
                    localMinimaIndex = i;
                    break;
                }
            }
            return localMinimaIndex;
        }
        public void FilterData()
        {
            if (data[0].Length > 0 && data[1].Length > 0)
            {     
                SGFilter(this.data);
                AmplitudeFilter(this.data);
            }

            this.function = new Lorentzian(this.data);
            //this.function = new LogNormal(this.data);
            //this.function = new Gauss(this.data);

            double[] temp = MPFit(this.function, this.data, 1000);
            this.function.setParameters(temp);
        }
        protected void AmplitudeFilter(double[][] data)
        {
            double max = double.MinValue;
            for (int i = 0; i < data[1].Length; i++)
                if (data[1][i] > max)
                    max = data[1][i];
            max = 1200;
            int new_lenght = 0;
            for (int i = 0; i < data[1].Length; i++)
                if (data[1][i] >= max)
                    new_lenght++;
            int j = 0;
            double[] tempY = new double[new_lenght];
            double[] tempX = new double[new_lenght];
            for (int i = 0; i < data[1].Length; i++)
            {
                if (data[1][i] >= max)
                {
                    tempY[j] = data[1][i];
                    tempX[j] = data[0][i];
                    j++;
                }
            }
            data[1] = tempY;
            data[0] = tempX;
        }
        protected void SGFilter(double[][] data, int sidePoints = 11, int polynomialOrder = 3)
        {
            Matrix<double> coefficients;
            double[,] a = new double[(sidePoints << 1) + 1, polynomialOrder + 1];

            for (int m = -sidePoints; m <= sidePoints; ++m)
            {
                for (int i = 0; i <= polynomialOrder; ++i)
                {
                    a[m + sidePoints, i] = Math.Pow(m, i);
                }
            }
            Matrix<double> s = Matrix<double>.Build.DenseOfArray(a);
            coefficients = s.Multiply(s.TransposeThisAndMultiply(s).Inverse()).Multiply(s.Transpose());
            int length = data[1].Length;
            double[] output = new double[length];
            int frameSize = (sidePoints << 1) + 1;
            double[] frame = new double[frameSize];
            Array.Copy(data[1], frame, frameSize);

            for (int i = 0; i < sidePoints; ++i)
            {
                output[i] = coefficients.Column(i).DotProduct(Vector<double>.Build.DenseOfArray(frame));
            }

            for (int n = sidePoints; n < length - sidePoints; ++n)
            {
                Array.ConstrainedCopy(data[1], n - sidePoints, frame, 0, frameSize);
                output[n] = coefficients.Column(sidePoints).DotProduct(Vector<double>.Build.DenseOfArray(frame));
            }

            Array.ConstrainedCopy(data[1], length - frameSize, frame, 0, frameSize);

            for (int i = 0; i < sidePoints; ++i)
            {
                output[length - sidePoints + i] = coefficients.Column(sidePoints + 1 + i).DotProduct(Vector<double>.Build.Dense(frame));
            }
            data[1] = output;
        }
        protected double[] MPFit(FunctionBase function, double[][] data, int maxIterations = 100)
        {
            double[] parameters = function.getParameters();
            mp_result result = new mp_result(parameters.Length);

            mp_config config = new mp_config();
            config.maxiter = maxIterations;

            config.ftol = 1e-16;
            config.xtol = 1e-16;
            config.gtol = 1e-16;
            config.covtol = 1e-16;

            config.nofinitecheck = 1;

            DataVariable v = new DataVariable { X = data[0], Y = data[1], Ey = new double[data[0].Length] };

            for (int i = 0; i < v.Ey.Length; i++)
                v.Ey[i] = 0.5;

            MPFitLib.MPFit.Solve(function.MPFunction, data[0].Length, parameters.Length, parameters, null, config, v, ref result);

            return parameters;
        }
    }
}
