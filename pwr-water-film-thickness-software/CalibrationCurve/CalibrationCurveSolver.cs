using pwr_water_film_thickness_software.Data_Models;
using pwr_water_film_thickness_software.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace pwr_water_film_thickness_software.CalibrationCurve
{
    internal class CalibrationCurveSolver
    {
        private List<CalibrationCurvePoint> calibrationCurvePoints;
        private double averageLabJackPosition;
        private double averageWaveLength;

        public CalibrationCurveParameters GetCalibrationCurveParameters(List<SpectrumDataMatrixRow> calibrationSteps)
        {
            GetCalibrationCurvePoints(calibrationSteps);
            CalculateAverageValues();
            double aCoefficient = CalculateACoefficient();
            double bCoefficient = CalculateBCoefficient(aCoefficient);
            Console.WriteLine($"A: {aCoefficient} B: {bCoefficient}");
            return new CalibrationCurveParameters(aCoefficient, bCoefficient);
        }
        private void GetCalibrationCurvePoints(List<SpectrumDataMatrixRow> calibrationSteps)
        {
            calibrationCurvePoints = new List<CalibrationCurvePoint>();

            foreach(SpectrumDataMatrixRow calibrationStep in calibrationSteps)
            {
                SpectrumRow maxIntensivityRow = calibrationStep.SpectrumData.Find(t => t.SpectrumValues.Average() == calibrationStep.SpectrumData.Max(a => a.SpectrumValues.Average()));
                calibrationCurvePoints.Add(new CalibrationCurvePoint(calibrationStep.LabJackPosition, maxIntensivityRow.WaveLength));
                Console.WriteLine($"Position: {calibrationStep.LabJackPosition} Wavelength: {maxIntensivityRow.WaveLength}");
            }
        }
        private void CalculateAverageValues()
        {
            averageLabJackPosition = calibrationCurvePoints.Average(t => t.LabJackPosition);
            averageWaveLength = calibrationCurvePoints.Average(t => t.WaveLength);
        }
        private double CalculateACoefficient()
        {
            double numeratorACoefficient = 0;
            double denominatorACoefficient = 0;
            foreach (var calibrationCurvePoint in calibrationCurvePoints)
            {
                numeratorACoefficient += (calibrationCurvePoint.LabJackPosition - averageLabJackPosition) * (calibrationCurvePoint.WaveLength - averageWaveLength);
                denominatorACoefficient += Math.Pow((calibrationCurvePoint.LabJackPosition - averageWaveLength), 2);
            }
            return numeratorACoefficient / denominatorACoefficient;
        }
        private double CalculateBCoefficient(double aCoefficient)
        {
            return averageWaveLength - aCoefficient * averageLabJackPosition;
        }
    }
}
