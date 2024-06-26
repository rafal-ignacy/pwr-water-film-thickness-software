namespace pwr_water_film_thickness_software.Data_Models
{
    internal class ThicknessHistoricalPoint
    {
        public double Time { get; set; }
        public double Thickness { get; set; }
        public ThicknessHistoricalPoint(double time, double thickness)
        {
            Time = time;
            Thickness = thickness;
        }
    }
}
