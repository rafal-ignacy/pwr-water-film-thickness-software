using pwr_water_film_thickness_software.Data_Models;
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
        public void StopLabJackPostionHistoryHandling()
        {
            if (labJackPostitionHistoryBackgroundWorker.WorkerSupportsCancellation == true)
            {
                labJackPostitionHistoryBackgroundWorker.CancelAsync();
            }
        }
        private void labJackPostitionHistoryBackgroundWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            List<LabJackPositionHistoricalPoint> labJackPositions = new List<LabJackPositionHistoricalPoint> ();

            while (worker.CancellationPending != true && labJackHandler.IsConnected)
            {
                foreach(LabJackPositionHistoricalPoint point in labJackPositions)
                {
                    point.Time -= 1;
                }
                double position = labJackHandler.Position;
                if (position == 0 && labJackPositions.Last().Position != 0)
                {
                    position = labJackPositions.Last().Position;
                }

                labJackPositions.Add(new LabJackPositionHistoricalPoint(0, position));
                if (labJackPositions.Count > 11)
                {
                    labJackPositions.RemoveAt(0);
                }

                labJackPositionHistoryChart.BeginInvoke(new Action(() => labJackPositionHistoryChart.Series[0].Points.Clear()));
                LabJackPositionHistoricalPoint minPositionPoint = labJackPositions.Find(t => t.Position == labJackPositions.Min(a => a.Position));
                LabJackPositionHistoricalPoint maxPositionPoint = labJackPositions.Find(t => t.Position == labJackPositions.Max(a => a.Position));
                labJackPositionHistoryChart.BeginInvoke(new Action(() => labJackPositionHistoryChart.ChartAreas[0].Axes[1].Minimum = minPositionPoint.Position - 0.1));
                labJackPositionHistoryChart.BeginInvoke(new Action(() => labJackPositionHistoryChart.ChartAreas[0].Axes[1].Maximum = maxPositionPoint.Position + 0.1));

                foreach (LabJackPositionHistoricalPoint point in labJackPositions)
                {
                    labJackPositionHistoryChart.BeginInvoke(new Action(() => labJackPositionHistoryChart.Series[0].Points.AddXY(point.Time, point.Position)));
                }
                this.BeginInvoke(new Action(() => labJackPositionHistoryChart.Update()));
                Thread.Sleep(1000);
            }                
            e.Cancel = true;
        }
    }
}
