using System;
using OmniDriver;
using pwr_water_film_thickness_software.BaseObjects;
using pwr_water_film_thickness_software.Interfaces;

namespace pwr_water_film_thickness_software.DeviceHandlers
{
    internal class SpectrometerHandler : SpectrometerBase, ISpectrometer
    {
        private NETWrapper device;

        public SpectrometerHandler()
        {
            isConnected = false;
            spectrometersAmount = 0;
        }
        public int Connect()
        {
            try
            {
                device = new NETWrapper();
                spectrometersAmount = device.openAllSpectrometers();
                if (spectrometersAmount > 0)
                {
                    isConnected = true;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return spectrometersAmount;
        }
        public void SetIntegrationTime(int spectrometerIndex, int integrationTime)
        {
            try
            {
                device.setIntegrationTime(spectrometerIndex, integrationTime);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public int GetIntegrationTime(int spectrometerIndex)
        {
            try
            {
                return device.getIntegrationTime(spectrometerIndex);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public double[] GetSpectrum(int spectrometerIndex)
        {
            double[] spectrumArray;
            try
            {
                spectrumArray = device.getSpectrum(spectrometerIndex);
            }
            catch
            {
                double[] emptyArray = { };
                return emptyArray;
            }
            return spectrumArray;
        }
        public double GetWaveLength(int spectrometerIndex, int pixelIndex)
        {
            double waveLength;
            try
            {
                waveLength = device.getWavelength(spectrometerIndex, pixelIndex);
            }
            catch
            {
                return -1;
            }
            return waveLength;
        }
        public void Disconnect()
        {
            try
            {
                device.closeAllSpectrometers();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message + " - error during spectrometer disconnection");
            }
            finally
            {
                isConnected = false;
            }
        }
    }
}