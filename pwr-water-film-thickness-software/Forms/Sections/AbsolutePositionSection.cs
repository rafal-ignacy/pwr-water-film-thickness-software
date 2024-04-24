using pwr_water_film_thickness_software.DataModels;
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
        private void absolutePositionButton_Click(object sender, System.EventArgs e)
        {
            if (absolutePositionBackgroundWorker.IsBusy != true)
            {
                absolutePositionBackgroundWorker.RunWorkerAsync();
            }
        }
    }
}
