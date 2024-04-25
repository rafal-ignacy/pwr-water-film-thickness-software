using pwr_water_film_thickness_software.DataModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading;

namespace pwr_water_film_thickness_software
{
    public partial class MainForm
    {
        public void SpectrumChartHandling()
        {
            if (spectrumMeasurementBackgroundWorker.IsBusy != true)
            {
                spectrumMeasurementBackgroundWorker.RunWorkerAsync();
            }
        }
        public void StopSpectrumChartHandling()
        {
            if (spectrumMeasurementBackgroundWorker.WorkerSupportsCancellation == true)
            {
                spectrumMeasurementBackgroundWorker.CancelAsync();
            }
        }

        private void SpectrumMeasurementBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;

            while (worker.CancellationPending != true && spectrometerHandler.IsConnected)
            {
                List<SpectrumRow> spectrumData = spectrometerHandler.GetSpectrumData(5, spectrometerHandler.GetSpectrum, spectrometerHandler.GetWaveLength);
                spectrumChart.BeginInvoke(new Action(() => spectrumChart.Series[0].Points.Clear()));
                foreach (SpectrumRow spectrumRow in spectrumData)
                {
                    spectrumChart.BeginInvoke(new Action(() => spectrumChart.Series[0].Points.AddXY(spectrumRow.WaveLength, spectrumRow.SpectrumValues.Average())));
                }
                SpectrumRow maxIntensivityRow = spectrumData.Find(t => t.SpectrumValues.Average() == spectrumData.Max(a => a.SpectrumValues.Average()));
                this.BeginInvoke(new Action(() => MaxIntensivityWaveLengthUpdate(maxIntensivityRow.SpectrumValues.Average(), maxIntensivityRow.WaveLength)));
                Thread.Sleep(100);
                spectrumMeasurementBackgroundWorker.ReportProgress(0);
            }
            e.Cancel = true;
        }

        private void SpectrumMeasurementBackgroundWorker_WorkDone(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            spectrumChart.Series[0].Points.Clear();
            maxIntensivityWaveLengthLabel.Text = "Maximum intensivity: - for wavelength: -";
        }
    }
}
