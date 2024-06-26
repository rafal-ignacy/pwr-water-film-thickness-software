using pwr_water_film_thickness_software.DataModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace pwr_water_film_thickness_software
{
    partial class MainForm
    {
        private void spectrometerConnectionButton_Click(object sender, EventArgs e)
        {
            if (!spectrometerHandler.IsConnected)
            {
                int spectrometersAmount = 0;
                try
                {
                    spectrometersAmount = spectrometerHandler.Connect();

                    Int32 integrationTime = 4000;
                    spectrometerHandler.SetIntegrationTime(0, integrationTime);
                    integrationTimeNumericUpDown.Value = integrationTime;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + " - cannot connect to spectrometer");
                    return;
                }

                if (spectrometersAmount != 0)
                {
                    if (spectrumMeasurementBackgroundWorker.IsBusy != true)
                    {
                        spectrumMeasurementBackgroundWorker.RunWorkerAsync();
                    }

                    spectrometerConnectionLabel.Text = "Spectrometer connected";
                    spectrometerConnectionButton.Text = "Disconnect";
                    spectrometerConnectionPictureBox.Image = Properties.Resources._true;
                    integrationTimeNumericUpDown.Enabled = true;
                    averageSpectrumNumericUpDown.Enabled = true;
                    saveSpectrumButton.Enabled = true;

                    if(labJackHandler.IsConnected)
                    {
                        if (thicknessMeasurementBackgroundWorker.IsBusy != true)
                        {
                            thicknessMeasurementBackgroundWorker.RunWorkerAsync();
                        }

                        startPositionNumericUpDown.Enabled = true;
                        endPositionNumericUpDown.Enabled = true;
                        stepLengthNumericUpDown.Enabled = true;
                        createCalibrationCurveButton.Enabled = true;
                    }
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

                if (spectrumMeasurementBackgroundWorker.WorkerSupportsCancellation)
                {
                    spectrumMeasurementBackgroundWorker.CancelAsync();
                }

                if (thicknessHistoryBackgroundWorker.WorkerSupportsCancellation)
                {
                    thicknessHistoryBackgroundWorker.CancelAsync();
                }

                spectrometerConnectionLabel.Text = "Spectrometer not connected";
                spectrometerConnectionButton.Text = "Connect";
                spectrometerConnectionPictureBox.Image = global::pwr_water_film_thickness_software.Properties.Resources._false;
                integrationTimeNumericUpDown.Enabled = false;
                averageSpectrumNumericUpDown.Enabled = false;
                saveSpectrumButton.Enabled = false;
                startPositionNumericUpDown.Enabled = false;
                endPositionNumericUpDown.Enabled = false;
                stepLengthNumericUpDown.Enabled = false;
                createCalibrationCurveButton.Enabled = false;
            }
        }
        private void SpectrumMeasurementBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;

            while (worker.CancellationPending != true && spectrometerHandler.IsConnected)
            {
                List<SpectrumRow> spectrumData = spectrometerHandler.GetSpectrumData(averageSpectrumAmount, spectrometerHandler.GetSpectrum, spectrometerHandler.GetWaveLength);
                spectrumChart.BeginInvoke(new Action(() => spectrumChart.Series[0].Points.Clear()));

                foreach (SpectrumRow spectrumRow in spectrumData)
                {
                    spectrumChart.BeginInvoke(new Action(() => spectrumChart.Series[0].Points.AddXY(spectrumRow.WaveLength, spectrumRow.SpectrumValues.Average())));
                }

                SpectrumRow maxIntensivityRow = spectrumData.Find(t => t.SpectrumValues.Average() == spectrumData.Max(a => a.SpectrumValues.Average()));

                double maxIntensivity = Math.Round(maxIntensivityRow.SpectrumValues.Average());
                double waveLength = Math.Round(maxIntensivityRow.WaveLength);
                maxIntensivityWaveLengthLabel.BeginInvoke(new Action(() => maxIntensivityWaveLengthLabel.Text = $"Maximum intensivity: {Math.Round(maxIntensivity)} for wavelength: {Math.Round(waveLength)} nm"));

                Thread.Sleep(100);
                spectrumMeasurementBackgroundWorker.ReportProgress(0);
            }
            e.Cancel = true;
        }
        private void SpectrumMeasurementBackgroundWorker_WorkDone(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            spectrumChart.Series[0].Points.Clear();
            spectrumChart.Series[1].Points.Clear();
            spectrumChart.Series[2].Points.Clear();
            maxIntensivityWaveLengthLabel.Text = "Maximum intensivity: - for wavelength: -";
        }
        private void integrationTimeNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            Int32 integrationTime = Convert.ToInt32(integrationTimeNumericUpDown.Value);
            spectrometerHandler.SetIntegrationTime(0, integrationTime);
        }
        private void averageSpectrumNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            averageSpectrumAmount = Convert.ToInt32(averageSpectrumNumericUpDown.Text);
        }
        private void saveSpectrumButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog
            {
                Filter = "CSV file (.csv)|*.csv| All Files (*.*)|*.*"
            };
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog1.FileName;
                try
                {
                    List<SpectrumRow> spectrumData = spectrometerHandler.GetSpectrumData(averageSpectrumAmount, spectrometerHandler.GetSpectrum, spectrometerHandler.GetWaveLength);
                    fileHandler.SaveSpectrum(filePath, spectrumData);
                    MessageBox.Show("File saved correctly", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
