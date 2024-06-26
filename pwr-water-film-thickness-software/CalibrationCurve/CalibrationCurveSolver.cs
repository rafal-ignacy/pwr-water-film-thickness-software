using pwr_water_film_thickness_software.Data_Models;
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

        public CalibrationCurveSolver(List<CalibrationCurvePoint> _calibrationCurvePoints)
        {
            calibrationCurvePoints = _calibrationCurvePoints;
        }

        public CalibrationCurveParameters GetCalibrationCurveParameters()
        {
            CalculateAverageValues();
            double aCoefficient = CalculateACoefficient();
            double bCoefficient = CalculateBCoefficient(aCoefficient);
            return new CalibrationCurveParameters(aCoefficient, bCoefficient);
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
                denominatorACoefficient += Math.Pow((calibrationCurvePoint.LabJackPosition - averageLabJackPosition), 2);
            }
            return Math.Round(numeratorACoefficient / denominatorACoefficient, 3);
        }
        private double CalculateBCoefficient(double aCoefficient)
        {
            return Math.Round(averageWaveLength - aCoefficient * averageLabJackPosition, 3);
        }
    }
}
