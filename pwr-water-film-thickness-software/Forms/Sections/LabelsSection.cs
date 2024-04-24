using pwr_water_film_thickness_software.Data_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pwr_water_film_thickness_software
{
    public partial class MainForm
    {
        public void LabJackPostionLabelUpdate(double labJackPosition)
        {
            labJackPositionLabel.Text = "Lab jack position: " + Convert.ToString(labJackPosition) + " mm";
        }
        public void LabJackPostionLabelHoming()
        {
            labJackPositionLabel.Text = "Lab jack position: homing";
        }
        public void LabJackPostionLabelDisconnect()
        {
            labJackPositionLabel.Text = "Lab jack position: -";
        }
        public void CalibrationCurveEquationUpdate(double aCoefficient, double bCoefficient)
        {
            calibrationCurveEquationLabel.Text = $"Calibration curve equation: y = {Math.Round(aCoefficient, 5)}x + {Math.Round(bCoefficient, 5)}";
        }
        public void MaxIntensivityWaveLengthUpdate(double maxIntensivity, double waveLength)
        {
            maxIntensivityWaveLengthLabel.Text = $"Maximum intensivity: {Math.Round(maxIntensivity)} for wavelength: {Math.Round(waveLength)} nm";
        }
    }
}

