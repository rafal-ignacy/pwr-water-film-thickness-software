using pwr_water_film_thickness_software.DataModels;
using System;
using System.Collections.Generic;

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
        public List<SpectrumRow> GetSpectrumData(bool isConnected, Func<int, double[]> GetSpectrum, Func<int, int, double> GetWaveLength)
        {
            List<SpectrumRow> spectrumData;
            if (isConnected)
            {
                double[] spectrum = GetSpectrum(0);
                spectrumData = new List<SpectrumRow>();
                for (int i = 0; i < spectrum.Length; i++)
                {
                    double waveLength = GetWaveLength(0, i);
                    SpectrumRow spectrumRow = new SpectrumRow(waveLength, spectrum[i]);
                    spectrumData.Add(spectrumRow);
                }
            }
            else
            {
                throw new Exception(); //not connected
            }
            return spectrumData;
        }
    }
}