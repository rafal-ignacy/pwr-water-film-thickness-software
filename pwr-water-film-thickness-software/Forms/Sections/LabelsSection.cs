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
        public void CalibrationCurveEquationClear()
        {
            calibrationCurveEquationLabel.Text = $"Calibration curve equation: -";
        }
        public void CalibrationCurveEquationUpdate(double aCoefficient, double bCoefficient)
        {
            calibrationCurveEquationLabel.Text = $"Calibration curve equation: y = {Math.Round(aCoefficient, 5)}x + {Math.Round(bCoefficient, 5)}";
        }
        public void MaxIntensivityWaveLengthUpdate(double maxIntensivity, double waveLength)
        {
            maxIntensivityWaveLengthLabel.Text = $"Maximum intensivity: {Math.Round(maxIntensivity)} for wavelength: {Math.Round(waveLength)} nm";
        }
        public void IntegrationTimeUpdate(double integrationTime)
        {
            integrationTimeLabel.Text = "Integration time: " + Convert.ToString(integrationTime) + " μs";
        }
        public void IntegrationTimeDefault()
        {
            integrationTimeLabel.Text = "Integration time: -";
        }
        public void AverageSpectrumUpdate(int averageSpectrumAmount)
        {
            averageSpectrumLabel.Text = "Average spectrum amount: " + Convert.ToString(averageSpectrumAmount);
        }
    }
}

