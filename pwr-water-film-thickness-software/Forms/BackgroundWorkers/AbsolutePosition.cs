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
            double absolutePosition = Convert.ToDouble(absolutePositionNumericUpDown.Value, CultureInfo.InvariantCulture);

            labJackHandler.SetMoveAbsolutePosition(absolutePosition);
            labJackHandler.MoveAbsolute();
        }
    }
}
