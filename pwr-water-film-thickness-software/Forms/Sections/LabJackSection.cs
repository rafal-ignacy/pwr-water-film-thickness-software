using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pwr_water_film_thickness_software
{
    partial class MainForm
    {
        private void labJackConnectionButton_Click(object sender, EventArgs e)
        {
            if (labJackConnectionBackgroundWorker.IsBusy != true)
            {
                labJackConnectionBackgroundWorker.RunWorkerAsync();
            }
        }
        private void labJackConnectionBackgroundWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            if (!labJackHandler.IsConnected)
            {
                int labJacksAmount = 0;
                try
                {
                    labJacksAmount = labJackHandler.Connect(serialNumber, deviceCode);
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
                    labJackConnectionPictureBox.Image = global::pwr_water_film_thickness_software.Properties.Resources._true;
                    absolutePositionNumericUpDown.BeginInvoke(new Action(() => absolutePositionNumericUpDown.Enabled = true));
                    absolutePositionNumericUpDown.BeginInvoke(new Action(() => absolutePositionNumericUpDown.Value = Convert.ToDecimal(labJackHandler.Position)));

                    if (spectrometerHandler.IsConnected)
                    {
                        if (!thicknessMeasurementBackgroundWorker.IsBusy)
                        {
                            thicknessMeasurementBackgroundWorker.RunWorkerAsync();
                        }

                        startPositionNumericUpDown.BeginInvoke(new Action(() => startPositionNumericUpDown.Enabled = true));
                        endPositionNumericUpDown.BeginInvoke(new Action(() => endPositionNumericUpDown.Enabled = true));
                        stepLengthNumericUpDown.BeginInvoke(new Action(() => stepLengthNumericUpDown.Enabled = true));
                        createCalibrationCurveButton.BeginInvoke(new Action(() => createCalibrationCurveButton.Enabled = true));
                    }
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
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + " - cannot disconnect lab jack");
                    return;
                }

                if (thicknessMeasurementBackgroundWorker.WorkerSupportsCancellation)
                {
                    thicknessMeasurementBackgroundWorker.CancelAsync();
                }

                if (thicknessHistoryBackgroundWorker.WorkerSupportsCancellation)
                {
                    thicknessHistoryBackgroundWorker.CancelAsync();
                }

                labJackPositionLabel.BeginInvoke(new Action(() => labJackPositionLabel.Text = "Lab jack position: -"));
                labJackConnectionLabel.BeginInvoke(new Action(() => labJackConnectionLabel.Text = "Lab jack not connected"));
                labJackConnectionButton.BeginInvoke(new Action(() => labJackConnectionButton.Text = "Connect"));
                labJackConnectionPictureBox.Image = global::pwr_water_film_thickness_software.Properties.Resources._false;
                absolutePositionNumericUpDown.BeginInvoke(new Action(() => absolutePositionNumericUpDown.Enabled = false));
                startPositionNumericUpDown.BeginInvoke(new Action(() => startPositionNumericUpDown.Enabled = false));
                endPositionNumericUpDown.BeginInvoke(new Action(() => endPositionNumericUpDown.Enabled = false));
                stepLengthNumericUpDown.BeginInvoke(new Action(() => stepLengthNumericUpDown.Enabled = false));
                createCalibrationCurveButton.BeginInvoke(new Action(() => createCalibrationCurveButton.Enabled = false));
            }
        }

        private void labJackBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;

            while (worker.CancellationPending != true)
            {
                labJackPositionLabel.BeginInvoke(new Action(() => labJackPositionLabel.Text = "Lab jack position: " + Convert.ToString(labJackHandler.Position) + " mm"));
                Thread.Sleep(50);
            }
            e.Cancel = true;
        }
        private void absolutePositionNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (!labJackMoveBackgroundWorker.IsBusy)
            {
                labJackMoveBackgroundWorker.RunWorkerAsync();
            }
        }

        private void absolutePositionNumericUpDown_Enter(object sender, EventArgs e)
        {
            if (labJackMoveBackgroundWorker.IsBusy != true)
            {
                labJackMoveBackgroundWorker.RunWorkerAsync();
            }
        }

        private void labJackMoveBackgroundWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            double absolutePosition = Convert.ToDouble(absolutePositionNumericUpDown.Value, CultureInfo.InvariantCulture);
            if (labJackHandler.IsConnected)
            {
                labJackHandler.SetMoveAbsolutePosition(absolutePosition);
                labJackHandler.MoveAbsolute();
            }
        }
    }
}
