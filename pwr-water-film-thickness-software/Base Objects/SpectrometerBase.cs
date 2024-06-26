using pwr_water_film_thickness_software.DataModels;
using System;
using System.Collections.Generic;
using System.Threading;

namespace pwr_water_film_thickness_software.BaseObjects
{
    internal class SpectrometerBase
    {
        protected bool isConnected;
        protected int spectrometersAmount;
        public bool IsConnected
        {
            get
            {
                return isConnected;
            }
        }
        public List<SpectrumRow> GetSpectrumData(int measurementAmount, Func<int, double[]> GetSpectrum, Func<int, int, double> GetWaveLength)
        {
            List<SpectrumRow> spectrumData = new List<SpectrumRow>();
            double[] spectrum = GetSpectrum(0);
            for (int i = 0; i < spectrum.Length; i++)
            {
                double waveLength = GetWaveLength(0, i);
                SpectrumRow spectrumRow = new SpectrumRow(waveLength, spectrum[i]);
                spectrumData.Add(spectrumRow);
            }

            for(int i = 0; i < measurementAmount - 1; i++)
            {
                spectrum = GetSpectrum(0);
                Thread.Sleep(50);
                for (int j = 0; j < spectrum.Length; j++)
                {
                    spectrumData[j].SpectrumValues.Add(spectrum[j]);
                }
            }
            return spectrumData;
        }
    }
}