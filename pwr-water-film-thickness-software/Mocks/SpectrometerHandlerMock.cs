using pwr_water_film_thickness_software.BaseObjects;
using pwr_water_film_thickness_software.Interfaces;
using System;
using System.IO;
using System.Linq;

namespace pwr_water_film_thickness_software.Mocks
{
    internal class SpectrometerHandlerMock : SpectrometerBase, ISpectrometer
    {
        private int integrationTime;
        private double[] spectrumBase;
        private double[] waveLengths;
        public SpectrometerHandlerMock()
        {
            isConnected = false;
            spectrometersAmount = 0;
            integrationTime = 0;
            GetSpectrumBase();
        }
        private void GetSpectrumBase()
        {
            string fileName = "it-15000-30.500-2";
            string filePath = $"files/{fileName}.csv";
            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    int rowCount = File.ReadLines(filePath).Count();
                    spectrumBase = new double[rowCount];
                    waveLengths = new double[rowCount];
                    int rowIndex = 0;

                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] columns = line.Split(';');
                        if (double.TryParse(columns[0], out double waveLength) && double.TryParse(columns[1], out double spectrumValue))
                        {
                            waveLengths[rowIndex] = waveLength;
                            spectrumBase[rowIndex] = spectrumValue;
                        }
                        else
                        {
                            throw new Exception($"Cannot parse spectrum data from CSV file - {filePath}");
                        }
                        rowIndex++;
                    }
                }
            }
            catch
            {
                throw;
            }
        }
        public int Connect()
        {
            isConnected = true;
            spectrometersAmount = 1;
            return spectrometersAmount;
        }
        public void SetIntegrationTime(int spectrometerIndex, int _integrationTime)
        {
            integrationTime = _integrationTime;
        }
        public int GetIntegrationTime(int spectrometerIndex) => integrationTime;
        public double[] GetSpectrum(int spectrometerIndex)
        {
            double[] spectrum = new double[spectrumBase.Length];
            for (int i = 0; i < spectrum.Length; i++)
            {
                spectrum[i] = spectrumBase[i];
            }
            return spectrum;
        }
        public double GetWaveLength(int spectrometerIndex, int pixelIndex) => waveLengths[pixelIndex];
        public void Disconnect()
        {
            isConnected = false;
        }
    }
}