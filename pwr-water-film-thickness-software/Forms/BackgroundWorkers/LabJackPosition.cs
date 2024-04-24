using pwr_water_film_thickness_software.DataModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace pwr_water_film_thickness_software
{
    partial class MainForm
    {
        private void labJackBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;

            while (worker.CancellationPending != true)
            {
               this.BeginInvoke(new Action(() => LabJackPostionLabelUpdate(labJackHandler.Position)));
               Thread.Sleep(50);
            }
            e.Cancel = true;
        }
    }
}
