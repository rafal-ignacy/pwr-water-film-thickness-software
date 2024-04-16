namespace pwr_water_film_thickness_software.Interfaces
{
    internal interface ISpectrometer : IConnection
    {
        int Connect();
        void SetIntegrationTime(int spectrometerIndex, int integrationTime);
        int GetIntegrationTime(int spectrometerIndex);
        double[] GetSpectrum(int spectrometerIndex);
        double GetWaveLength(int spectrometerIndex, int pixelIndex);

        void Disconnect();
    }
}