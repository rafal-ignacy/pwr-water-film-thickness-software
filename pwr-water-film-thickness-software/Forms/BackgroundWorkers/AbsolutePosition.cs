using pwr_water_film_thickness_software.DeviceHandlers;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pwr_water_film_thickness_software
{
    partial class MainForm
    {
        private void absolutePositionBackgroundWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            absolutePositionButton.BeginInvoke(new Action(() => absolutePositionButton.Enabled = false));
            absolutePositionButton.BeginInvoke(new Action(() => absolutePositionTextBox.Enabled = false));
            absolutePositionButton.BeginInvoke(new Action(() => absolutePositionTextBox.Enabled = true));

            double absolutePosition = Convert.ToDouble(absolutePositionTextBox.Text, CultureInfo.InvariantCulture);

            labJackHandler.SetMoveAbsolutePosition(absolutePosition);
            labJackHandler.MoveAbsolute();

            absolutePositionButton.BeginInvoke(new Action(() => absolutePositionButton.Enabled = true));
        }
    }
}
