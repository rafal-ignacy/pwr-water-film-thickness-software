using System.Collections.Generic;

namespace pwr_water_film_thickness_software.DataModels
{
    internal class SpectrumRow
    {
        public double WaveLength { get; set; }
        public List<double> SpectrumValues { get; set; }
        public SpectrumRow(double waveLength, double spectrumValue)
        {
            SpectrumValues = new List<double>() { spectrumValue };
            WaveLength = waveLength;
        }
    }
}