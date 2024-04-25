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
                    spectrometerHandler.SetIntegrationTime(0, 6000);
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
            if (labJackConnectionBackgroundWorker.IsBusy != true)
            {
                labJackConnectionBackgroundWorker.RunWorkerAsync();
            }
        }
    }
}
