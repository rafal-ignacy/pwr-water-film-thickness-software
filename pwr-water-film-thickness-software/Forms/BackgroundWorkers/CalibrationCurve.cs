using pwr_water_film_thickness_software.CalibrationCurve;
using pwr_water_film_thickness_software.Data_Models;
using pwr_water_film_thickness_software.DataModels;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pwr_water_film_thickness_software
{
    partial class MainForm
    {
        private void calibrationCurveBackgroundWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            spectrumDataMatrix = new List<SpectrumDataMatrixRow>();

            double startPosition = Convert.ToDouble(startPositionTextBox.Text, CultureInfo.InvariantCulture);
            double endPosition = Convert.ToDouble(endPositionTextBox.Text, CultureInfo.InvariantCulture);
            double stepLength = Convert.ToDouble(stepLengthTextBox.Text, CultureInfo.InvariantCulture);

            double targetPosition = startPosition;
            while (Math.Round(targetPosition, 3) <= endPosition)
            {
                labJackHandler.SetMoveAbsolutePosition(targetPosition);
                labJackHandler.MoveAbsolute();

                if (spectrometerHandler.IsConnected)
                {
                    List<SpectrumRow> spectrumData = spectrometerHandler.GetSpectrumData(5, spectrometerHandler.GetSpectrum, spectrometerHandler.GetWaveLength);
                    spectrumDataMatrix.Add(new SpectrumDataMatrixRow(targetPosition, spectrumData));
                }
                targetPosition += stepLength;
            }

            CalibrationCurveSolver solver = new CalibrationCurveSolver();
            CalibrationCurveParameters calibrationCurveParameters = solver.GetCalibrationCurveParameters(spectrumDataMatrix);

            this.BeginInvoke(new Action(() => CalibrationCurveEquationUpdate(calibrationCurveParameters.ACoefficient, calibrationCurveParameters.BCoefficient)));

            startPositionTextBox.BeginInvoke(new Action(() => startPositionTextBox.Clear()));
            endPositionTextBox.BeginInvoke(new Action(() => endPositionTextBox.Clear()));
            stepLengthTextBox.BeginInvoke(new Action(() => stepLengthTextBox.Clear()));
        }
    }
}
