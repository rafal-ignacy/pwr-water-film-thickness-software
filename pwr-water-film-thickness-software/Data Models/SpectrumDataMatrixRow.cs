using System;
using System.Collections.Generic;
using pwr_water_film_thickness_software.Data_Models;
using pwr_water_film_thickness_software.DataModels;

namespace pwr_water_film_thickness_software.Data_Models
{
    internal class SpectrumDataMatrixRow
    {
        public double LabJackPosition { get; set; }
        public List<SpectrumRow> SpectrumData { get; set; }
        public SpectrumDataMatrixRow(double labJackPosition, List<SpectrumRow> spectrumData)
        {
            LabJackPosition = labJackPosition;
            SpectrumData = spectrumData;
        }
    }
}
