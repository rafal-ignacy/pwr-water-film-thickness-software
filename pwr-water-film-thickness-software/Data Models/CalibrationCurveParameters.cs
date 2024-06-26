namespace pwr_water_film_thickness_software.Data_Models
{
    internal class CalibrationCurveParameters
    {
        public double ACoefficient { get; set; }
        public double BCoefficient { get; set; }
        public CalibrationCurveParameters(double aCoefficient, double bCoefficient)
        {
            ACoefficient = aCoefficient;
            BCoefficient = bCoefficient;
        }
    }
}
