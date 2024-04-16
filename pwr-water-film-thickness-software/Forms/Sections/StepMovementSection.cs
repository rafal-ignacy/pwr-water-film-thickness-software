using System;
using System.Globalization;
using System.Collections.Generic;
using pwr_water_film_thickness_software.DataModels;
using System.Linq;

namespace pwr_water_film_thickness_software
{
    partial class MainForm
    {
        private void stepMovementButton_Click(object sender, System.EventArgs e)
        {
            spectrumDataMatrix = new List<Tuple<double, List<SpectrumRow>>>();

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
                    spectrumDataMatrix.Add(new Tuple<double, List<SpectrumRow>>(targetPosition, spectrumData));
                }

                targetPosition += stepLength;
            }

            startPositionTextBox.Clear();
            endPositionTextBox.Clear();
            stepLengthTextBox.Clear();
        }
    }
}
