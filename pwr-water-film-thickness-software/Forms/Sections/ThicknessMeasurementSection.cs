using pwr_water_film_thickness_software.Data_Models;
using pwr_water_film_thickness_software.DataModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace pwr_water_film_thickness_software
{ 
    partial class MainForm
    {
        private void thicknessMeasurementBackgroundWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;

            ///////////////////////
            ///

            string filePath = "spektrum-peak.csv";
            //List<SpectrumRow> spectrumData = new List<SpectrumRow>();

            using (StreamReader reader = new StreamReader(filePath))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] columns = line.Split(';');
                    if (columns.Length > 1)
                    {
                        //spectrumData.Add(new SpectrumRow(Convert.ToDouble(columns[0]), Convert.ToDouble(columns[1])));
                    }
                }
            }

            ///
            //////////////////////

            while (worker.CancellationPending != true && spectrometerHandler.IsConnected && labJackHandler.IsConnected)
            {
                List<SpectrumRow> spectrumData = spectrometerHandler.GetSpectrumData(averageSpectrumAmount, spectrometerHandler.GetSpectrum, spectrometerHandler.GetWaveLength);
                var rand = new Random();

                List<double> averageSpectrumOutput = new List<double>();
                int windowWidth = 10;
                List<double> averageWindow = new List<double>(new double[windowWidth]);
                foreach (SpectrumRow row in spectrumData)
                {
                    averageWindow.Add(row.SpectrumValues.Average());
                    //averageWindow.Add(row.SpectrumValues.Average() + rand.Next(-50, 50));
                    averageWindow.RemoveAt(0);
                    averageSpectrumOutput.Add(averageWindow.Average());
                }

                int peakWindowSize = 100;

                List<double> peaks = new List<double>();
                double current;
                IEnumerable<double> range;

                int peakWindowSizeHalf = peakWindowSize / 2;
                for (int i = 0; i < averageSpectrumOutput.Count; i++)
                {
                    current = averageSpectrumOutput[i];
                    range = averageSpectrumOutput;

                    if (i > peakWindowSizeHalf)
                    {
                        range = range.Skip(i - peakWindowSizeHalf);
                    }

                    range = range.Take(peakWindowSize);
                    if ((range.Count() > 0) && (current == range.Max()))
                    {
                        peaks.Add(current);
                    }
                }

                peaks.Sort();
                peaks.Reverse();
                if(peaks.Count < 2)
                {
                    continue;
                }
                int firstPeakIndex = averageSpectrumOutput.FindIndex(u => u == peaks[0]);
                int secondPeakIndex = averageSpectrumOutput.FindIndex(u => u == peaks[1]);

                double lambda1 = spectrumData[firstPeakIndex].WaveLength;
                double lambda2 = spectrumData[secondPeakIndex].WaveLength;

                double intensivityThreshold = 1200;

                if (spectrumData[firstPeakIndex].SpectrumValues.Average() > intensivityThreshold && spectrumData[secondPeakIndex].SpectrumValues.Average() > intensivityThreshold)
                {
                    thickness = Math.Abs((r * k * (lambda2 - lambda1)) / ((h0 + k * (lambda2 - lambda1)) * Math.Tan(Math.Asin((n * Math.Sin(Math.Atan(r / (h0 + k * (lambda2 - lambda1))))) / n1))));
                    materialThicknessLabel.BeginInvoke(new Action(() => materialThicknessLabel.Text = $"Material thickness: {Math.Round(thickness, 5)} mm"));
                    thicknessMeasurementStatusLabel.BeginInvoke(new Action(() => thicknessMeasurementStatusLabel.Text = $"Thickness measurement active"));
                    thicknessMeasurementStatusPictureBox.Image = global::pwr_water_film_thickness_software.Properties.Resources._true;
                    if (thicknessHistoryBackgroundWorker.IsBusy != true)
                    {
                        thicknessHistoryBackgroundWorker.RunWorkerAsync();
                    }
                }
                else
                {
                    thickness = 0;
                    materialThicknessLabel.BeginInvoke(new Action(() => materialThicknessLabel.Text = $"Material thickness: -"));
                    thicknessMeasurementStatusLabel.BeginInvoke(new Action(() => thicknessMeasurementStatusLabel.Text = $"Thickness measurement not active"));
                    thicknessMeasurementStatusPictureBox.Image = global::pwr_water_film_thickness_software.Properties.Resources._false;
                    if (thicknessHistoryBackgroundWorker.WorkerSupportsCancellation)
                    {
                        thicknessHistoryBackgroundWorker.CancelAsync();
                    }
                }

                Thread.Sleep(1000);
            }
            e.Cancel = true;
        }
        private void thicknessHistoryBackgroundWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            
            while (worker.CancellationPending != true && labJackHandler.IsConnected)
            {
                foreach (ThicknessHistoricalPoint point in thicknessMeasurements)
                {
                    point.Time -= 1;
                }

                if (thickness == 0 && thicknessMeasurements.Last().Thickness != 0)
                {
                    thickness = thicknessMeasurements.Last().Thickness;
                }

                thicknessMeasurements.Add(new ThicknessHistoricalPoint(0, thickness));
                if (thicknessMeasurements.Count > 31)
                {
                    thicknessMeasurements.RemoveAt(0);
                }

                labJackPositionHistoryChart.BeginInvoke(new Action(() => labJackPositionHistoryChart.Series[0].Points.Clear()));
                ThicknessHistoricalPoint minPositionPoint = thicknessMeasurements.Find(t => t.Thickness == thicknessMeasurements.Min(a => a.Thickness));
                ThicknessHistoricalPoint maxPositionPoint = thicknessMeasurements.Find(t => t.Thickness == thicknessMeasurements.Max(a => a.Thickness));
                labJackPositionHistoryChart.BeginInvoke(new Action(() => labJackPositionHistoryChart.ChartAreas[0].Axes[1].Minimum = minPositionPoint.Thickness - 0.005));
                labJackPositionHistoryChart.BeginInvoke(new Action(() => labJackPositionHistoryChart.ChartAreas[0].Axes[1].Maximum = maxPositionPoint.Thickness + 0.005));

                foreach (ThicknessHistoricalPoint point in thicknessMeasurements)
                {
                    labJackPositionHistoryChart.BeginInvoke(new Action(() => labJackPositionHistoryChart.Series[0].Points.AddXY(point.Time, point.Thickness)));
                }
                this.BeginInvoke(new Action(() => labJackPositionHistoryChart.Update()));
                Thread.Sleep(1000);
            }
            e.Cancel = true;
        }
        private void thicknessHistoryBackgroundWorker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            materialThicknessLabel.BeginInvoke(new Action(() => materialThicknessLabel.Text = $"Material thickness: -"));
            thicknessMeasurementStatusLabel.BeginInvoke(new Action(() => thicknessMeasurementStatusLabel.Text = $"Thickness measurement not active"));
            thicknessMeasurementStatusPictureBox.Image = global::pwr_water_film_thickness_software.Properties.Resources._false;
            thicknessMeasurements.Clear();
            labJackPositionHistoryChart.BeginInvoke(new Action(() => labJackPositionHistoryChart.Series[0].Points.Clear()));
        }
        private void materialComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (materialComboBox.SelectedIndex)
            {
                case 0: // water
                    n1 = 1.33;
                    break;
                case 1: // isopropanol
                    n1 = 1.3771;
                    break;
                case 2: // fused silica
                    n1 = 1.4585;
                    break;
                case 3: // N-BK7
                    n1 = 1.517;
                    break;
                case 4: // S-LAH64
                    n1 = 1.788;
                    break;
            }

            Thread.Sleep(250);
            labJackPositionHistoryChart.BeginInvoke(new Action(() => labJackPositionHistoryChart.Series[0].Points.Clear()));
            thicknessMeasurements.Clear();
        }
    }
}
