using System;
using System.Windows.Forms;
using System.Threading;

namespace pwr_water_film_thickness_software
{
    public partial class MainForm
    {
        private void spectrometerConnectionButton_Click(object sender, EventArgs e)
        {
            if(!spectrometerHandler.IsConnected)
            {
                int spectrometersAmount = 0;
                try
                {
                    spectrometersAmount = spectrometerHandler.Connect();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message + " - cannot connect to spectrometer");
                    return;
                }

                if (spectrometersAmount != 0)
                {
                    spectrometerConnectionLabel.Text = "Spectrometer connected";
                    spectrometerConnectionButton.Text = "Disconnect";

                    if (labJackHandler.IsConnected)
                    {
                        LabJackSpectrometerConnected();
                    }
                    SpectrumChartHandling();
                }
                else
                {
                    MessageBox.Show("No spectrometer is connected");
                }

                
            }
            else
            {
                try
                {
                    spectrometerHandler.Disconnect();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + " - cannot disconnect spectrometer");
                    return;
                }
                spectrometerConnectionLabel.Text = "Spectrometer not connected";
                spectrometerConnectionButton.Text = "Connect";

                StopSpectrumChartHandling();
                LabJackSpectrometerDisconnected();
            }
        }

        private void labJackConnectionButton_Click(object sender, EventArgs e)
        {            
            if (!labJackHandler.IsConnected)
            {
                int labJacksAmount = 0;
                try
                {
                    labJacksAmount = labJackHandler.Connect(serialNumber, deviceCode, highLimit);
                    LabJackPostionLabelHoming();
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
                    labJackConnectionLabel.Text = "Lab jack connected";
                    labJackConnectionButton.Text = "Disconnect";
                }
                else
                {
                    MessageBox.Show("No spectrometer is connected");
                }
                LabJackConnected();

                if(spectrometerHandler.IsConnected)
                {
                    LabJackSpectrometerConnected();
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
                    LabJackPostionLabelDisconnect();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + " - cannot disconnect lab jack");
                    return;
                }
                labJackConnectionLabel.Text = "Lab jack not connected";
                labJackConnectionButton.Text = "Connect";
                LabJackDisconnected();
                LabJackSpectrometerDisconnected();
            }
        }
    }
}
