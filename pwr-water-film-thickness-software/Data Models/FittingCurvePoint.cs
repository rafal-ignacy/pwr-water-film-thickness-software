namespace pwr_water_film_thickness_software.Data_Models
{
    internal class FittingCurvePoint
    {
        public double Y { get; set; }
        public double X { get; set; }
        public FittingCurvePoint(double _y, double _x)
        {
            Y = _y;
            X = _x;
        }
    }
}