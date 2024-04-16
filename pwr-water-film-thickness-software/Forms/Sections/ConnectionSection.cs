using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pwr_water_film_thickness_software
{
    public partial class MainForm
    {
        private void spectrometerConnectionButton_Click(object sender, System.EventArgs e)
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
            }
        }

        private void labJackConnectionButton_Click(object sender, System.EventArgs e)
        {
            labJackConnectionLabel.Enabled = false;
            labJackConnectionButton.Enabled = false;
            
            if (!labJackHandler.IsConnected)
            {
                int labJacksAmount = 0;
                try
                {
                    labJacksAmount = labJackHandler.Connect(serialNumber, deviceCode, highLimit);
                    labJackHandler.Home();
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
            }
            else
            {
                try
                {
                    labJackHandler.Disconnect();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + " - cannot disconnect lab jack");
                    return;
                }
                labJackConnectionLabel.Text = "Lab jack not connected";
                labJackConnectionButton.Text = "Connect";
            }

            labJackConnectionLabel.Enabled = true;
            labJackConnectionButton.Enabled = true;
        }
    }
}
