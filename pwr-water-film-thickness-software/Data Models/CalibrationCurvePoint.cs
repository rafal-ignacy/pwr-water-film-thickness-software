namespace pwr_water_film_thickness_software.Data_Models
{
    internal class CalibrationCurvePoint
    {
        public double LabJackPosition { get; set; }
        public double WaveLength { get; set; }
        public CalibrationCurvePoint(double labJackPosition, double waveLength)
        {
            LabJackPosition = labJackPosition;
            WaveLength = waveLength;
        }
    }
}
