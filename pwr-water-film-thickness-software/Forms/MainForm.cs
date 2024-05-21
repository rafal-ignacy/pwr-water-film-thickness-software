using pwr_water_film_thickness_software.DataModels;
using pwr_water_film_thickness_software.DeviceHandlers;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace pwr_water_film_thickness_software
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void saveCalibrationCurvePoints_Click(object sender, System.EventArgs e)
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
                    fileHandler.SaveCalibrationCurvePoints(filePath, calibrationCurvePoints);
                    MessageBox.Show("File saved correctly", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void integrationTimeButton_Click(object sender, System.EventArgs e)
        {
            Int32 integrationTime = Convert.ToInt32(integrationTimeNumericUpDown.Value);
            spectrometerHandler.SetIntegrationTime(0, integrationTime);
            IntegrationTimeUpdate(integrationTime);
        }

        private void absolutePositionButton_Click(object sender, System.EventArgs e)
        {
            if (absolutePositionBackgroundWorker.IsBusy != true)
            {
                absolutePositionBackgroundWorker.RunWorkerAsync();
            }
        }

        private void averageSpectrumButton_Click(object sender, EventArgs e)
        {
            averageSpectrumAmount = Convert.ToInt32(averageSpectrumNumericUpDown.Text);
            AverageSpectrumUpdate(averageSpectrumAmount);
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
