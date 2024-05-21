using pwr_water_film_thickness_software.Data_Models;
using pwr_water_film_thickness_software.DataModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pwr_water_film_thickness_software.Others
{
    internal class FileHandler
    {
        public void SaveCalibrationCurvePoints(string filePath, List<CalibrationCurvePoint> calibrationCurvePoints)
        {
            try
            {
                using (StreamWriter fileWriter = new StreamWriter(filePath))
                {
                    string fileLine = ";";
                    foreach (CalibrationCurvePoint point in calibrationCurvePoints)
                    {
                        fileLine += point.LabJackPosition + ";";
                    }
                    fileWriter.WriteLine(fileLine);

                    fileLine = ";";
                    foreach (CalibrationCurvePoint point in calibrationCurvePoints)
                    {
                        fileLine += point.WaveLength + ";";
                    }
                    fileWriter.WriteLine(fileLine);

                    fileWriter.Close();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e + " - error during CSV file saving");
            }
        }
        public void SaveSpectrum(string filePath, List<SpectrumRow> spectrumData)
        {
            try
            {
                using (StreamWriter fileWriter = new StreamWriter(filePath))
                {
                    foreach (SpectrumRow row in spectrumData)
                    {
                        string fileLine  = row.WaveLength + ";" + row.SpectrumValues.Average();
                        fileWriter.WriteLine(fileLine);
                    }
                    fileWriter.Close();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e + " - error during CSV file saving");
            }
        }

    }
}
