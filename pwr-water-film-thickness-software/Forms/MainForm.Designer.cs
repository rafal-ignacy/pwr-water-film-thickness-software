namespace pwr_water_film_thickness_software
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.spectrometerConnectionLabel = new System.Windows.Forms.Label();
            this.spectrometerConnectionButton = new System.Windows.Forms.Button();
            this.labJackConnectionLabel = new System.Windows.Forms.Label();
            this.labJackConnectionButton = new System.Windows.Forms.Button();
            this.startPositionLabel = new System.Windows.Forms.Label();
            this.endPositionLabel = new System.Windows.Forms.Label();
            this.stepLengthLabel = new System.Windows.Forms.Label();
            this.startPositionTextBox = new System.Windows.Forms.TextBox();
            this.endPositionTextBox = new System.Windows.Forms.TextBox();
            this.stepLengthTextBox = new System.Windows.Forms.TextBox();
            this.startPositionLabel_mm = new System.Windows.Forms.Label();
            this.endPositionLabel_mm = new System.Windows.Forms.Label();
            this.stepLengthLabel_mm = new System.Windows.Forms.Label();
            this.createCalibrationCurveButton = new System.Windows.Forms.Button();
            this.labJackPositionLabel = new System.Windows.Forms.Label();
            this.maxIntensivityWaveLengthLabel = new System.Windows.Forms.Label();
            this.calibrationCurveEquationLabel = new System.Windows.Forms.Label();
            this.spectrumChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.spectrumMeasurementBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.absolutePositionLabel = new System.Windows.Forms.Label();
            this.absolutePositionButton = new System.Windows.Forms.Button();
            this.absolutePositionLabel_mm = new System.Windows.Forms.Label();
            this.absolutePositionTextBox = new System.Windows.Forms.TextBox();
            this.absolutePositionBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.labJackPositionBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.calibrationCurveBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.spectrumChart)).BeginInit();
            this.SuspendLayout();
            // 
            // spectrometerConnectionLabel
            // 
            this.spectrometerConnectionLabel.AutoSize = true;
            this.spectrometerConnectionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.spectrometerConnectionLabel.Location = new System.Drawing.Point(60, 60);
            this.spectrometerConnectionLabel.Name = "spectrometerConnectionLabel";
            this.spectrometerConnectionLabel.Size = new System.Drawing.Size(431, 39);
            this.spectrometerConnectionLabel.TabIndex = 0;
            this.spectrometerConnectionLabel.Text = "Spectometer not connected";
            // 
            // spectrometerConnectionButton
            // 
            this.spectrometerConnectionButton.Location = new System.Drawing.Point(550, 50);
            this.spectrometerConnectionButton.Name = "spectrometerConnectionButton";
            this.spectrometerConnectionButton.Size = new System.Drawing.Size(220, 60);
            this.spectrometerConnectionButton.TabIndex = 1;
            this.spectrometerConnectionButton.Text = "Connect";
            this.spectrometerConnectionButton.UseVisualStyleBackColor = true;
            this.spectrometerConnectionButton.Click += new System.EventHandler(this.spectrometerConnectionButton_Click);
            // 
            // labJackConnectionLabel
            // 
            this.labJackConnectionLabel.AutoSize = true;
            this.labJackConnectionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labJackConnectionLabel.Location = new System.Drawing.Point(60, 150);
            this.labJackConnectionLabel.Name = "labJackConnectionLabel";
            this.labJackConnectionLabel.Size = new System.Drawing.Size(366, 39);
            this.labJackConnectionLabel.TabIndex = 2;
            this.labJackConnectionLabel.Text = "Lab jack not connected";
            // 
            // labJackConnectionButton
            // 
            this.labJackConnectionButton.Location = new System.Drawing.Point(550, 140);
            this.labJackConnectionButton.Name = "labJackConnectionButton";
            this.labJackConnectionButton.Size = new System.Drawing.Size(220, 60);
            this.labJackConnectionButton.TabIndex = 3;
            this.labJackConnectionButton.Text = "Connect";
            this.labJackConnectionButton.UseVisualStyleBackColor = true;
            this.labJackConnectionButton.Click += new System.EventHandler(this.labJackConnectionButton_Click);
            // 
            // startPositionLabel
            // 
            this.startPositionLabel.AutoSize = true;
            this.startPositionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.startPositionLabel.Location = new System.Drawing.Point(60, 460);
            this.startPositionLabel.Name = "startPositionLabel";
            this.startPositionLabel.Size = new System.Drawing.Size(215, 39);
            this.startPositionLabel.TabIndex = 4;
            this.startPositionLabel.Text = "Start position";
            // 
            // endPositionLabel
            // 
            this.endPositionLabel.AutoSize = true;
            this.endPositionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.endPositionLabel.Location = new System.Drawing.Point(60, 540);
            this.endPositionLabel.Name = "endPositionLabel";
            this.endPositionLabel.Size = new System.Drawing.Size(205, 39);
            this.endPositionLabel.TabIndex = 5;
            this.endPositionLabel.Text = "End position";
            // 
            // stepLengthLabel
            // 
            this.stepLengthLabel.AutoSize = true;
            this.stepLengthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.stepLengthLabel.Location = new System.Drawing.Point(60, 620);
            this.stepLengthLabel.Name = "stepLengthLabel";
            this.stepLengthLabel.Size = new System.Drawing.Size(189, 39);
            this.stepLengthLabel.TabIndex = 6;
            this.stepLengthLabel.Text = "Step length";
            // 
            // startPositionTextBox
            // 
            this.startPositionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.startPositionTextBox.Location = new System.Drawing.Point(520, 457);
            this.startPositionTextBox.Name = "startPositionTextBox";
            this.startPositionTextBox.Size = new System.Drawing.Size(140, 45);
            this.startPositionTextBox.TabIndex = 7;
            // 
            // endPositionTextBox
            // 
            this.endPositionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.endPositionTextBox.Location = new System.Drawing.Point(520, 537);
            this.endPositionTextBox.Name = "endPositionTextBox";
            this.endPositionTextBox.Size = new System.Drawing.Size(140, 45);
            this.endPositionTextBox.TabIndex = 8;
            // 
            // stepLengthTextBox
            // 
            this.stepLengthTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.stepLengthTextBox.Location = new System.Drawing.Point(520, 617);
            this.stepLengthTextBox.Name = "stepLengthTextBox";
            this.stepLengthTextBox.Size = new System.Drawing.Size(140, 45);
            this.stepLengthTextBox.TabIndex = 9;
            // 
            // startPositionLabel_mm
            // 
            this.startPositionLabel_mm.AutoSize = true;
            this.startPositionLabel_mm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.startPositionLabel_mm.Location = new System.Drawing.Point(680, 460);
            this.startPositionLabel_mm.Name = "startPositionLabel_mm";
            this.startPositionLabel_mm.Size = new System.Drawing.Size(73, 39);
            this.startPositionLabel_mm.TabIndex = 10;
            this.startPositionLabel_mm.Text = "mm";
            // 
            // endPositionLabel_mm
            // 
            this.endPositionLabel_mm.AutoSize = true;
            this.endPositionLabel_mm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.endPositionLabel_mm.Location = new System.Drawing.Point(680, 540);
            this.endPositionLabel_mm.Name = "endPositionLabel_mm";
            this.endPositionLabel_mm.Size = new System.Drawing.Size(73, 39);
            this.endPositionLabel_mm.TabIndex = 11;
            this.endPositionLabel_mm.Text = "mm";
            // 
            // stepLengthLabel_mm
            // 
            this.stepLengthLabel_mm.AutoSize = true;
            this.stepLengthLabel_mm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.stepLengthLabel_mm.Location = new System.Drawing.Point(680, 620);
            this.stepLengthLabel_mm.Name = "stepLengthLabel_mm";
            this.stepLengthLabel_mm.Size = new System.Drawing.Size(73, 39);
            this.stepLengthLabel_mm.TabIndex = 12;
            this.stepLengthLabel_mm.Text = "mm";
            // 
            // createCalibrationCurveButton
            // 
            this.createCalibrationCurveButton.Location = new System.Drawing.Point(67, 730);
            this.createCalibrationCurveButton.Name = "createCalibrationCurveButton";
            this.createCalibrationCurveButton.Size = new System.Drawing.Size(700, 60);
            this.createCalibrationCurveButton.TabIndex = 13;
            this.createCalibrationCurveButton.Text = "Calculate calibration curve";
            this.createCalibrationCurveButton.UseVisualStyleBackColor = true;
            this.createCalibrationCurveButton.Click += new System.EventHandler(this.createCalibrationCurveButton_Click);
            // 
            // labJackPositionLabel
            // 
            this.labJackPositionLabel.AutoSize = true;
            this.labJackPositionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labJackPositionLabel.Location = new System.Drawing.Point(860, 60);
            this.labJackPositionLabel.Name = "labJackPositionLabel";
            this.labJackPositionLabel.Size = new System.Drawing.Size(300, 39);
            this.labJackPositionLabel.TabIndex = 14;
            this.labJackPositionLabel.Text = "Lab jack position: -";
            // 
            // maxIntensivityWaveLengthLabel
            // 
            this.maxIntensivityWaveLengthLabel.AutoSize = true;
            this.maxIntensivityWaveLengthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.maxIntensivityWaveLengthLabel.Location = new System.Drawing.Point(860, 150);
            this.maxIntensivityWaveLengthLabel.Name = "maxIntensivityWaveLengthLabel";
            this.maxIntensivityWaveLengthLabel.Size = new System.Drawing.Size(611, 39);
            this.maxIntensivityWaveLengthLabel.TabIndex = 15;
            this.maxIntensivityWaveLengthLabel.Text = "Maximum intensivity: - for wavelength: -";
            // 
            // calibrationCurveEquationLabel
            // 
            this.calibrationCurveEquationLabel.AutoSize = true;
            this.calibrationCurveEquationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.calibrationCurveEquationLabel.Location = new System.Drawing.Point(860, 240);
            this.calibrationCurveEquationLabel.Name = "calibrationCurveEquationLabel";
            this.calibrationCurveEquationLabel.Size = new System.Drawing.Size(442, 39);
            this.calibrationCurveEquationLabel.TabIndex = 16;
            this.calibrationCurveEquationLabel.Text = "Calibration curve equation: -";
            // 
            // spectrumChart
            // 
            chartArea1.AxisX.Interval = 100D;
            chartArea1.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.AxisX.IntervalOffset = 4.69026828777D;
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.LabelStyle.Angle = 90;
            chartArea1.AxisX.Title = "Wavelength [nm]";
            chartArea1.AxisY.Title = "Intensivity";
            chartArea1.Name = "ChartArea1";
            this.spectrumChart.ChartAreas.Add(chartArea1);
            this.spectrumChart.Location = new System.Drawing.Point(860, 350);
            this.spectrumChart.Name = "spectrumChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Name = "Spectrum";
            this.spectrumChart.Series.Add(series1);
            this.spectrumChart.Size = new System.Drawing.Size(960, 580);
            this.spectrumChart.TabIndex = 17;
            // 
            // spectrumMeasurementBackgroundWorker
            // 
            this.spectrumMeasurementBackgroundWorker.WorkerReportsProgress = true;
            this.spectrumMeasurementBackgroundWorker.WorkerSupportsCancellation = true;
            this.spectrumMeasurementBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.SpectrumMeasurementBackgroundWorker_DoWork);
            this.spectrumMeasurementBackgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.SpectrumMeasurementBackgroundWorker_WorkDone);
            // 
            // absolutePositionLabel
            // 
            this.absolutePositionLabel.AutoSize = true;
            this.absolutePositionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.absolutePositionLabel.Location = new System.Drawing.Point(61, 280);
            this.absolutePositionLabel.Name = "absolutePositionLabel";
            this.absolutePositionLabel.Size = new System.Drawing.Size(277, 39);
            this.absolutePositionLabel.TabIndex = 18;
            this.absolutePositionLabel.Text = "Absolute position";
            // 
            // absolutePositionButton
            // 
            this.absolutePositionButton.Location = new System.Drawing.Point(67, 360);
            this.absolutePositionButton.Name = "absolutePositionButton";
            this.absolutePositionButton.Size = new System.Drawing.Size(700, 60);
            this.absolutePositionButton.TabIndex = 19;
            this.absolutePositionButton.Text = "Move";
            this.absolutePositionButton.UseVisualStyleBackColor = true;
            this.absolutePositionButton.Click += new System.EventHandler(this.absolutePositionButton_Click);
            // 
            // absolutePositionLabel_mm
            // 
            this.absolutePositionLabel_mm.AutoSize = true;
            this.absolutePositionLabel_mm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.absolutePositionLabel_mm.Location = new System.Drawing.Point(680, 280);
            this.absolutePositionLabel_mm.Name = "absolutePositionLabel_mm";
            this.absolutePositionLabel_mm.Size = new System.Drawing.Size(73, 39);
            this.absolutePositionLabel_mm.TabIndex = 20;
            this.absolutePositionLabel_mm.Text = "mm";
            // 
            // absolutePositionTextBox
            // 
            this.absolutePositionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.absolutePositionTextBox.Location = new System.Drawing.Point(520, 277);
            this.absolutePositionTextBox.Name = "absolutePositionTextBox";
            this.absolutePositionTextBox.Size = new System.Drawing.Size(140, 45);
            this.absolutePositionTextBox.TabIndex = 21;
            // 
            // absolutePositionBackgroundWorker
            // 
            this.absolutePositionBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.absolutePositionBackgroundWorker_DoWork);
            // 
            // labJackPositionBackgroundWorker
            // 
            this.labJackPositionBackgroundWorker.WorkerSupportsCancellation = true;
            this.labJackPositionBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.labJackBackgroundWorker_DoWork);
            // 
            // calibrationCurveBackgroundWorker
            // 
            this.calibrationCurveBackgroundWorker.WorkerSupportsCancellation = true;
            this.calibrationCurveBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.calibrationCurveBackgroundWorker_DoWork);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1888, 992);
            this.Controls.Add(this.absolutePositionTextBox);
            this.Controls.Add(this.absolutePositionLabel_mm);
            this.Controls.Add(this.absolutePositionButton);
            this.Controls.Add(this.absolutePositionLabel);
            this.Controls.Add(this.spectrumChart);
            this.Controls.Add(this.calibrationCurveEquationLabel);
            this.Controls.Add(this.maxIntensivityWaveLengthLabel);
            this.Controls.Add(this.labJackPositionLabel);
            this.Controls.Add(this.createCalibrationCurveButton);
            this.Controls.Add(this.stepLengthLabel_mm);
            this.Controls.Add(this.endPositionLabel_mm);
            this.Controls.Add(this.startPositionLabel_mm);
            this.Controls.Add(this.stepLengthTextBox);
            this.Controls.Add(this.endPositionTextBox);
            this.Controls.Add(this.startPositionTextBox);
            this.Controls.Add(this.stepLengthLabel);
            this.Controls.Add(this.endPositionLabel);
            this.Controls.Add(this.startPositionLabel);
            this.Controls.Add(this.labJackConnectionButton);
            this.Controls.Add(this.labJackConnectionLabel);
            this.Controls.Add(this.spectrometerConnectionButton);
            this.Controls.Add(this.spectrometerConnectionLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.spectrumChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label spectrometerConnectionLabel;
        private System.Windows.Forms.Button spectrometerConnectionButton;
        private System.Windows.Forms.Label labJackConnectionLabel;
        private System.Windows.Forms.Button labJackConnectionButton;
        private System.Windows.Forms.Label startPositionLabel;
        private System.Windows.Forms.Label endPositionLabel;
        private System.Windows.Forms.Label stepLengthLabel;
        private System.Windows.Forms.TextBox startPositionTextBox;
        private System.Windows.Forms.TextBox endPositionTextBox;
        private System.Windows.Forms.TextBox stepLengthTextBox;
        private System.Windows.Forms.Label startPositionLabel_mm;
        private System.Windows.Forms.Label endPositionLabel_mm;
        private System.Windows.Forms.Label stepLengthLabel_mm;
        private System.Windows.Forms.Button createCalibrationCurveButton;
        private System.Windows.Forms.Label labJackPositionLabel;
        private System.Windows.Forms.Label maxIntensivityWaveLengthLabel;
        private System.Windows.Forms.Label calibrationCurveEquationLabel;
        private System.Windows.Forms.DataVisualization.Charting.Chart spectrumChart;
        private System.ComponentModel.BackgroundWorker spectrumMeasurementBackgroundWorker;
        private System.Windows.Forms.Label absolutePositionLabel;
        private System.Windows.Forms.Button absolutePositionButton;
        private System.Windows.Forms.Label absolutePositionLabel_mm;
        private System.Windows.Forms.TextBox absolutePositionTextBox;
        private System.ComponentModel.BackgroundWorker absolutePositionBackgroundWorker;
        private System.ComponentModel.BackgroundWorker labJackPositionBackgroundWorker;
        private System.ComponentModel.BackgroundWorker calibrationCurveBackgroundWorker;
    }
}

