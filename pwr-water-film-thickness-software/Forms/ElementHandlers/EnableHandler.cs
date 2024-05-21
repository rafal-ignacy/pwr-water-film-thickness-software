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
            absolutePositionNumericUpDown.Enabled = true;
            absolutePositionButton.Enabled = true;
        }
        private void LabJackDisconnected()
        {
            absolutePositionNumericUpDown.Enabled = false;
            absolutePositionButton.Enabled = false;
        }
        private void LabJackSpectrometerConnected()
        {
            startPositionNumericUpDown.Enabled = true;
            endPositionNumericUpDown.Enabled = true;
            stepLengthNumericUpDown.Enabled = true;
            createCalibrationCurveButton.Enabled = true;
        }
        private void LabJackSpectrometerDisconnected()
        {
            startPositionNumericUpDown.Enabled = false;
            endPositionNumericUpDown.Enabled = false;
            stepLengthNumericUpDown.Enabled = false;
            createCalibrationCurveButton.Enabled = false;
        }
    }
}
