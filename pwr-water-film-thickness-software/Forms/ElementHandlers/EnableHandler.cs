using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pwr_water_film_thickness_software
{
    partial class MainForm
    {
        private void LabJackConnected()
        {
            absolutePositionTextBox.Enabled = true;
            absolutePositionButton.Enabled = true;
        }
        private void LabJackDisconnected()
        {
            absolutePositionTextBox.Enabled = false;
            absolutePositionButton.Enabled = false;
        }
        private void LabJackSpectrometerConnected()
        {
            startPositionTextBox.Enabled = true;
            endPositionTextBox.Enabled = true;
            stepLengthTextBox.Enabled = true;
            createCalibrationCurveButton.Enabled = true;
        }
        private void LabJackSpectrometerDisconnected()
        {
            startPositionTextBox.Enabled = false;
            endPositionTextBox.Enabled = false;
            stepLengthTextBox.Enabled = false;
            createCalibrationCurveButton.Enabled = false;
        }
    }
}
