using System;
using System.Globalization;
using System.Collections.Generic;
using pwr_water_film_thickness_software.DataModels;
using pwr_water_film_thickness_software.CalibrationCurve;
using pwr_water_film_thickness_software.Data_Models;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace pwr_water_film_thickness_software
{
    public partial class MainForm
    {
        private void createCalibrationCurveButton_Click(object sender, System.EventArgs e)
        {
            if (calibrationCurveBackgroundWorker.IsBusy != true)
            {
                calibrationCurveBackgroundWorker.RunWorkerAsync();
            }
        }
        private void calibrationCurveBackgroundWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            double startPosition = Convert.ToDouble(startPositionNumericUpDown.Value, CultureInfo.InvariantCulture);
            double endPosition = Convert.ToDouble(endPositionNumericUpDown.Value, CultureInfo.InvariantCulture);
            double stepLength = Convert.ToDouble(stepLengthNumericUpDown.Value, CultureInfo.InvariantCulture);

            if (startPosition == endPosition)
            {
                MessageBox.Show("Start position equal to end position", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (startPosition > endPosition)
            {
                MessageBox.Show("Start position is greater than end position", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (stepLength == 0)
            {
                MessageBox.Show("Step length is equal to zero", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (stepLength > (endPosition - startPosition))
            {
                MessageBox.Show("Step length is greater than distance between start and end position", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double targetPosition = startPosition;
            calibrationCurvePoints = new List<CalibrationCurvePoint>();

            calibrationCurveChart.BeginInvoke(new Action(() => calibrationCurveChart.Series[0].Points.Clear()));
            calibrationCurveChart.BeginInvoke(new Action(() => calibrationCurveChart.Series[1].Points.Clear()));
            calibrationCurveEquationLabel.BeginInvoke(new Action(() => calibrationCurveEquationLabel.Text = $"Calibration curve equation: -"));

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
            
            double aCoefficient = Math.Round(calibrationCurveParameters.ACoefficient, 5);
            double bCoefficient = Math.Round(calibrationCurveParameters.BCoefficient, 5);
            calibrationCurveEquationLabel.BeginInvoke(new Action(() => calibrationCurveEquationLabel.Text = $"Calibration curve equation: y = {aCoefficient}x + {bCoefficient}"));

            this.BeginInvoke(new Action(() => saveCalibrationCurvePointsButton.Enabled = true));
        }
        private void saveCalibrationCurvePoints_Click(object sender, System.EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog
            {
                Filter = "CSV file (.csv)|*.csv| All Files (*.*)|*.*"
            };
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog1.FileName;
                try
                {
                    fileHandler.SaveCalibrationCurvePoints(filePath, calibrationCurvePoints);
                    MessageBox.Show("File saved correctly", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
