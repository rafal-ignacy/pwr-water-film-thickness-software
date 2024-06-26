using pwr_water_film_thickness_software.Data_Models;
using pwr_water_film_thickness_software.DataModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading;

namespace pwr_water_film_thickness_software
{ 
    partial class MainForm
    {
        private void thicknessMeasurementBackgroundWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;

            while (worker.CancellationPending != true && spectrometerHandler.IsConnected && labJackHandler.IsConnected)
            {
                List<SpectrumRow> spectrumData = spectrometerHandler.GetSpectrumData(averageSpectrumAmount, spectrometerHandler.GetSpectrum, spectrometerHandler.GetWaveLength);

                // moving average filter
                //int[] waveLengthIndexes = MAF_WaveLengthIndexDetection(spectrumData);

                // fitting algorithms
                int[] waveLengthIndexes = FittingAlgorithm_WaveLengthIndexDetection(spectrumData);

                double lambda1 = spectrumData[waveLengthIndexes[0]].WaveLength;
                double lambda2 = spectrumData[waveLengthIndexes[1]].WaveLength;

                double intensivityThreshold = 1200;

                if (spectrumData[waveLengthIndexes[0]].SpectrumValues.Average() > intensivityThreshold && spectrumData[waveLengthIndexes[1]].SpectrumValues.Average() > intensivityThreshold)
                {
                    thickness = Math.Abs((r * k * (lambda2 - lambda1)) / ((h0 + k * (lambda2 - lambda1)) * Math.Tan(Math.Asin((n * Math.Sin(Math.Atan(r / (h0 + k * (lambda2 - lambda1))))) / n1))));
                    materialThicknessLabel.BeginInvoke(new Action(() => materialThicknessLabel.Text = $"Material thickness: {Math.Round(thickness, 5)} mm"));
                    thicknessMeasurementStatusLabel.BeginInvoke(new Action(() => thicknessMeasurementStatusLabel.Text = $"Thickness measurement active"));
                    thicknessMeasurementStatusPictureBox.Image = Properties.Resources._true;
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
                    thicknessMeasurementStatusPictureBox.Image = Properties.Resources._false;
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
            labJackPositionHistoryChart.BeginInvoke(new Action(() => labJackPositionHistoryChart.Series[0].Points.Clear()));
            thicknessMeasurementStatusPictureBox.Image = Properties.Resources._false;           
            thicknessMeasurements.Clear();
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
        private List<double> MovingAverageFilter(List<SpectrumRow> spectrumData)
        {
            List<double> averageSpectrumSignal = new List<double>();
            int windowWidth = 10;
            List<double> averageWindow = new List<double>(new double[windowWidth]);
            foreach (SpectrumRow row in spectrumData)
            {
                averageWindow.Add(row.SpectrumValues.Average());
                averageWindow.RemoveAt(0);
                averageSpectrumSignal.Add(averageWindow.Average());
            }
            return averageSpectrumSignal;
        }
        private int[] PeaksIndexDetection(List<double> averageSpectrumSignal)
        {
            int peakWindowSize = 100;

            List<double> peaks = new List<double>();
            double current;
            IEnumerable<double> range;

            int peakWindowSizeHalf = peakWindowSize / 2;
            for (int i = 0; i < averageSpectrumSignal.Count; i++)
            {
                current = averageSpectrumSignal[i];
                range = averageSpectrumSignal;

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

            int[] indexes = new int[2];
            indexes[0] = averageSpectrumSignal.FindIndex(u => u == peaks[0]);
            indexes[1] = averageSpectrumSignal.FindIndex(u => u == peaks[1]);
            return indexes;
        }
        private int[] MAF_WaveLengthIndexDetection(List<SpectrumRow> spectrumData)
        {
            List<double> averageSpectrumSingal = MovingAverageFilter(spectrumData);

            int[] waveLengthIndexes = PeaksIndexDetection(averageSpectrumSingal);

            return waveLengthIndexes;
        }
        private int[] FittingAlgorithm_WaveLengthIndexDetection(List<SpectrumRow> spectrumData)
        {
            int[] waveLengthIndexes = new int[2];
            spectrumData = SpectrumSignalRangeCut(spectrumData);
            int splitIndex = SplitSpectrumSignalIndex(spectrumData);
            List<SpectrumRow> spectrumDataFirstPeak = spectrumData.GetRange(0, splitIndex);
            List<SpectrumRow> spectrumDataSecondPeak = spectrumData.GetRange(splitIndex + 1, (spectrumData.Count - splitIndex - 1));

            SpectrumDataProcessing spectrumDataProcessing = new SpectrumDataProcessing(spectrumDataFirstPeak);
            double[][] curve = FittingProcedure(spectrumDataFirstPeak, spectrumDataProcessing);
            int tempWaveLengthIndex1 = FindIndexMaxValue(curve);
            AddFittedCurvesChart(curve, 1);
            waveLengthIndexes[0] = FindIndexSpectrumData(spectrumData, curve[0][tempWaveLengthIndex1]);

            SpectrumDataProcessing spectrumDataProcessing2 = new SpectrumDataProcessing(spectrumDataSecondPeak);
            curve = FittingProcedure(spectrumDataSecondPeak, spectrumDataProcessing2);
            int tempWaveLengthIndex2 = FindIndexMaxValue(curve);
            AddFittedCurvesChart(curve, 2);
            waveLengthIndexes[1] = FindIndexSpectrumData(spectrumData, curve[0][tempWaveLengthIndex2]);

            return waveLengthIndexes;
        }
        private List<SpectrumRow> SpectrumSignalRangeCut(List<SpectrumRow> spectrumData) 
        {
            int index = spectrumData.FindIndex(x => x.SpectrumValues.Average() > 850);
            spectrumData.RemoveRange(0, index);
            spectrumData.Reverse();
            index = spectrumData.FindIndex(x => x.SpectrumValues.Average() > 850);
            spectrumData.RemoveRange(0, index);
            spectrumData.Reverse();

            return spectrumData;
        }
        private int SplitSpectrumSignalIndex(List<SpectrumRow> spectrumData)
        {
            SpectrumDataProcessing dataModelProcess = new SpectrumDataProcessing(spectrumData);
            int indexSplit = dataModelProcess.FindLocalMinima();
            return indexSplit;
        }
        private double[][] FittingProcedure(List<SpectrumRow> spectrumDataRange, SpectrumDataProcessing dataModelProcess)
        {
            dataModelProcess.FilterData();
            double[][] points = dataModelProcess.getPoints(spectrumDataRange[0].WaveLength, spectrumDataRange[spectrumDataRange.Count - 1].WaveLength, 300);
            return points;
        }
        private void AddFittedCurvesChart(double[][] curvePoints, int serieIndex)
        {
            List<FittingCurvePoint> curvePointsList = new List<FittingCurvePoint>();
            int i = 0;
            foreach (var element in curvePoints[0])
            {
                curvePointsList.Add(new FittingCurvePoint(curvePoints[1][i], element));
                i++;
            }

            spectrumChart.BeginInvoke(new Action(() => spectrumChart.Series[serieIndex].Points.Clear()));
            foreach (FittingCurvePoint point in curvePointsList)
            {
                spectrumChart.BeginInvoke(new Action(() => spectrumChart.Series[serieIndex].Points.AddXY(point.X, point.Y)));
            }
            spectrumChart.BeginInvoke(new Action(() => spectrumChart.ChartAreas[0].AxisX.LabelStyle.Format = "0"));
        }
        private int FindIndexMaxValue(double[][] curvePoints)
        {
            double maxValue = 0;
            int maxValueIndex = 0;
            for (int i = 0; i < curvePoints[0].Length; i++)
            {
                if (curvePoints[1][i] > maxValue)
                {
                    maxValue = curvePoints[1][i];
                    maxValueIndex = i;
                }
            }
            return maxValueIndex;
        }
        private int FindIndexSpectrumData(List<SpectrumRow> spectrumData, double threshold)
        {
            int index = 0;
            foreach(SpectrumRow row in spectrumData)
            {
                if(row.WaveLength > threshold)
                {
                    break;
                }
                index++;
            }
            return index;
        }
    }
}
