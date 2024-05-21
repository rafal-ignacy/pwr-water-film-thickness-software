using pwr_water_film_thickness_software.CalibrationCurve;
using pwr_water_film_thickness_software.Data_Models;
using pwr_water_film_thickness_software.DataModels;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace pwr_water_film_thickness_software
{
    partial class MainForm
    {
        private void calibrationCurveBackgroundWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            double startPosition = Convert.ToDouble(startPositionNumericUpDown.Value, CultureInfo.InvariantCulture);
            double endPosition = Convert.ToDouble(endPositionNumericUpDown.Value, CultureInfo.InvariantCulture);
            double stepLength = Convert.ToDouble(stepLengthNumericUpDown.Value, CultureInfo.InvariantCulture);

            double targetPosition = startPosition;
            calibrationCurvePoints = new List<CalibrationCurvePoint>();

            calibrationCurveChart.BeginInvoke(new Action(() => calibrationCurveChart.Series[0].Points.Clear()));
            calibrationCurveChart.BeginInvoke(new Action(() => calibrationCurveChart.Series[1].Points.Clear()));
            this.BeginInvoke(new Action(() => CalibrationCurveEquationClear()));

            while (Math.Round(targetPosition, 3) <= endPosition)
            {
                labJackHandler.SetMoveAbsolutePosition(targetPosition);
                labJackHandler.MoveAbsolute();
                Thread.Sleep(500);

                if (spectrometerHandler.IsConnected)
                {
                    List<SpectrumRow> spectrumData = spectrometerHandler.GetSpectrumData(averageSpectrumAmount, spectrometerHandler.GetSpectrum, spectrometerHandler.GetWaveLength);
                    SpectrumRow maxIntensivityRow = spectrumData.Find(t => t.SpectrumValues.Average() == spectrumData.Max(a => a.SpectrumValues.Average()));
                    CalibrationCurvePoint calibrationCurvePoint = new CalibrationCurvePoint(targetPosition, maxIntensivityRow.WaveLength);
                    calibrationCurvePoints.Add(calibrationCurvePoint);
                    calibrationCurveChart.BeginInvoke(new Action(() => calibrationCurveChart.Series[0].Points.AddXY(calibrationCurvePoint.LabJackPosition, calibrationCurvePoint.WaveLength)));
                    CalibrationCurvePoint maxWaveLengthCalibrationCurvePoint = calibrationCurvePoints.Find(t => t.WaveLength == calibrationCurvePoints.Max(a => a.WaveLength));
                    calibrationCurveChart.BeginInvoke(new Action(() => calibrationCurveChart.ChartAreas[0].Axes[1].Maximum = maxWaveLengthCalibrationCurvePoint.WaveLength + 100));
                }
                targetPosition += stepLength;
            }

            CalibrationCurveSolver solver = new CalibrationCurveSolver(calibrationCurvePoints);
            CalibrationCurveParameters calibrationCurveParameters = solver.GetCalibrationCurveParameters();

            calibrationCurveChart.BeginInvoke(new Action(() => calibrationCurveChart.Series[1].Points.AddXY(calibrationCurvePoints.First().LabJackPosition - stepLength, calibrationCurveParameters.ACoefficient * (calibrationCurvePoints.First().LabJackPosition - stepLength) + calibrationCurveParameters.BCoefficient)));
            calibrationCurveChart.BeginInvoke(new Action(() => calibrationCurveChart.Series[1].Points.AddXY(calibrationCurvePoints.Last().LabJackPosition + stepLength, calibrationCurveParameters.ACoefficient * (calibrationCurvePoints.Last().LabJackPosition + stepLength) + calibrationCurveParameters.BCoefficient)));

            this.BeginInvoke(new Action(() => CalibrationCurveEquationUpdate(calibrationCurveParameters.ACoefficient, calibrationCurveParameters.BCoefficient)));
            this.BeginInvoke(new Action(() => saveCalibrationCurvePointsButton.Enabled = true));
        }
    }
}
