using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pwr_water_film_thickness_software
{
    partial class MainForm
    {
        private void labJackConnectionBackgroundWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            if (!labJackHandler.IsConnected)
            {
                int labJacksAmount = 0;
                try
                {
                    labJacksAmount = labJackHandler.Connect(serialNumber, deviceCode, highLimit);
                    labJackPositionLabel.BeginInvoke(new Action(() => labJackPositionLabel.Text = "Lab jack position: homing"));
                    labJackHandler.Home();
                    if (labJackPositionBackgroundWorker.IsBusy != true)
                    {
                        labJackPositionBackgroundWorker.RunWorkerAsync();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + " - cannot connect to lab jack");
                    return;
                }
                if (labJacksAmount != 0)
                {
                    labJackConnectionLabel.BeginInvoke(new Action(() => labJackConnectionLabel.Text = "Lab jack connected"));
                    labJackConnectionButton.BeginInvoke(new Action(() => labJackConnectionButton.Text = "Disconnect"));
                    absolutePositionTextBox.BeginInvoke(new Action(() => absolutePositionTextBox.Enabled = true));
                    absolutePositionButton.BeginInvoke(new Action(() => absolutePositionButton.Enabled = true));
                }
                else
                {
                    MessageBox.Show("No spectrometer is connected");
                }

                if (spectrometerHandler.IsConnected)
                {
                    startPositionTextBox.BeginInvoke(new Action(() => startPositionTextBox.Enabled = true));
                    endPositionTextBox.BeginInvoke(new Action(() => endPositionTextBox.Enabled = true));
                    stepLengthTextBox.BeginInvoke(new Action(() => stepLengthTextBox.Enabled = true));
                    createCalibrationCurveButton.BeginInvoke(new Action(() => createCalibrationCurveButton.Enabled = true));
                }
            }
            else
            {
                try
                {
                    if (labJackPositionBackgroundWorker.WorkerSupportsCancellation == true)
                    {
                        labJackPositionBackgroundWorker.CancelAsync();
                    }
                    labJackHandler.Disconnect();
                    labJackPositionLabel.BeginInvoke(new Action(() => labJackPositionLabel.Text = "Lab jack position: -"));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + " - cannot disconnect lab jack");
                    return;
                }
                labJackConnectionLabel.BeginInvoke(new Action(() => labJackConnectionLabel.Text = "Lab jack not connected"));
                labJackConnectionButton.BeginInvoke(new Action(() => labJackConnectionButton.Text = "Connect"));
                absolutePositionTextBox.BeginInvoke(new Action(() => absolutePositionTextBox.Enabled = false));
                absolutePositionButton.BeginInvoke(new Action(() => absolutePositionButton.Enabled = false));
                startPositionTextBox.BeginInvoke(new Action(() => startPositionTextBox.Enabled = false));
                endPositionTextBox.BeginInvoke(new Action(() => endPositionTextBox.Enabled = false));
                stepLengthTextBox.BeginInvoke(new Action(() => stepLengthTextBox.Enabled = false));
                createCalibrationCurveButton.BeginInvoke(new Action(() => createCalibrationCurveButton.Enabled = false));
            }
        }
    }
}
