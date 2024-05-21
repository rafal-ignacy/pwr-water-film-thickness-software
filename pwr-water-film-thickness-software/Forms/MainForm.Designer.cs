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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title7 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title8 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title9 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.spectrometerConnectionLabel = new System.Windows.Forms.Label();
            this.spectrometerConnectionButton = new System.Windows.Forms.Button();
            this.labJackConnectionLabel = new System.Windows.Forms.Label();
            this.labJackConnectionButton = new System.Windows.Forms.Button();
            this.startPositionLabel = new System.Windows.Forms.Label();
            this.endPositionLabel = new System.Windows.Forms.Label();
            this.stepLengthLabel = new System.Windows.Forms.Label();
            this.startPositionLabel_mm = new System.Windows.Forms.Label();
            this.endPositionLabel_mm = new System.Windows.Forms.Label();
            this.stepLengthLabel_mm = new System.Windows.Forms.Label();
            this.createCalibrationCurveButton = new System.Windows.Forms.Button();
            this.labJackPositionLabel = new System.Windows.Forms.Label();
            this.maxIntensivityWaveLengthLabel = new System.Windows.Forms.Label();
            this.calibrationCurveEquationLabel = new System.Windows.Forms.Label();
            this.spectrumMeasurementBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.absolutePositionLabel = new System.Windows.Forms.Label();
            this.absolutePositionButton = new System.Windows.Forms.Button();
            this.absolutePositionLabel_mm = new System.Windows.Forms.Label();
            this.absolutePositionBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.labJackPositionBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.calibrationCurveBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.labJackConnectionBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.integrationTimeLabel_us = new System.Windows.Forms.Label();
            this.integrationTimeButton = new System.Windows.Forms.Button();
            this.integrationTimeTextBoxLabel = new System.Windows.Forms.Label();
            this.calibrationCurveChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.saveCalibrationCurvePointsButton = new System.Windows.Forms.Button();
            this.labJackPositionHistoryChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.averageSpectrumButton = new System.Windows.Forms.Button();
            this.averageSpectrumTextBoxLabel = new System.Windows.Forms.Label();
            this.labJackPostitionHistoryBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.spectrumChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.integrationTimeLabel = new System.Windows.Forms.Label();
            this.averageSpectrumLabel = new System.Windows.Forms.Label();
            this.saveSpectrumButton = new System.Windows.Forms.Button();
            this.absolutePositionNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.integrationTimeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.averageSpectrumNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.startPositionNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.endPositionNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.stepLengthNumericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.calibrationCurveChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labJackPositionHistoryChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spectrumChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.absolutePositionNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.integrationTimeNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.averageSpectrumNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startPositionNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endPositionNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stepLengthNumericUpDown)).BeginInit();
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
            this.spectrometerConnectionButton.Size = new System.Drawing.Size(325, 60);
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
            this.labJackConnectionButton.Size = new System.Drawing.Size(325, 60);
            this.labJackConnectionButton.TabIndex = 3;
            this.labJackConnectionButton.Text = "Connect";
            this.labJackConnectionButton.UseVisualStyleBackColor = true;
            this.labJackConnectionButton.Click += new System.EventHandler(this.labJackConnectionButton_Click);
            // 
            // startPositionLabel
            // 
            this.startPositionLabel.AutoSize = true;
            this.startPositionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.startPositionLabel.Location = new System.Drawing.Point(1976, 706);
            this.startPositionLabel.Name = "startPositionLabel";
            this.startPositionLabel.Size = new System.Drawing.Size(215, 39);
            this.startPositionLabel.TabIndex = 4;
            this.startPositionLabel.Text = "Start position";
            // 
            // endPositionLabel
            // 
            this.endPositionLabel.AutoSize = true;
            this.endPositionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.endPositionLabel.Location = new System.Drawing.Point(1976, 786);
            this.endPositionLabel.Name = "endPositionLabel";
            this.endPositionLabel.Size = new System.Drawing.Size(205, 39);
            this.endPositionLabel.TabIndex = 5;
            this.endPositionLabel.Text = "End position";
            // 
            // stepLengthLabel
            // 
            this.stepLengthLabel.AutoSize = true;
            this.stepLengthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.stepLengthLabel.Location = new System.Drawing.Point(1976, 866);
            this.stepLengthLabel.Name = "stepLengthLabel";
            this.stepLengthLabel.Size = new System.Drawing.Size(189, 39);
            this.stepLengthLabel.TabIndex = 6;
            this.stepLengthLabel.Text = "Step length";
            // 
            // startPositionLabel_mm
            // 
            this.startPositionLabel_mm.AutoSize = true;
            this.startPositionLabel_mm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.startPositionLabel_mm.Location = new System.Drawing.Point(2851, 706);
            this.startPositionLabel_mm.Name = "startPositionLabel_mm";
            this.startPositionLabel_mm.Size = new System.Drawing.Size(73, 39);
            this.startPositionLabel_mm.TabIndex = 10;
            this.startPositionLabel_mm.Text = "mm";
            // 
            // endPositionLabel_mm
            // 
            this.endPositionLabel_mm.AutoSize = true;
            this.endPositionLabel_mm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.endPositionLabel_mm.Location = new System.Drawing.Point(2851, 786);
            this.endPositionLabel_mm.Name = "endPositionLabel_mm";
            this.endPositionLabel_mm.Size = new System.Drawing.Size(73, 39);
            this.endPositionLabel_mm.TabIndex = 11;
            this.endPositionLabel_mm.Text = "mm";
            // 
            // stepLengthLabel_mm
            // 
            this.stepLengthLabel_mm.AutoSize = true;
            this.stepLengthLabel_mm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.stepLengthLabel_mm.Location = new System.Drawing.Point(2851, 866);
            this.stepLengthLabel_mm.Name = "stepLengthLabel_mm";
            this.stepLengthLabel_mm.Size = new System.Drawing.Size(73, 39);
            this.stepLengthLabel_mm.TabIndex = 12;
            this.stepLengthLabel_mm.Text = "mm";
            // 
            // createCalibrationCurveButton
            // 
            this.createCalibrationCurveButton.Location = new System.Drawing.Point(1983, 973);
            this.createCalibrationCurveButton.Name = "createCalibrationCurveButton";
            this.createCalibrationCurveButton.Size = new System.Drawing.Size(941, 60);
            this.createCalibrationCurveButton.TabIndex = 13;
            this.createCalibrationCurveButton.Text = "Calculate calibration curve";
            this.createCalibrationCurveButton.UseVisualStyleBackColor = true;
            this.createCalibrationCurveButton.Click += new System.EventHandler(this.createCalibrationCurveButton_Click);
            // 
            // labJackPositionLabel
            // 
            this.labJackPositionLabel.AutoSize = true;
            this.labJackPositionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labJackPositionLabel.Location = new System.Drawing.Point(59, 351);
            this.labJackPositionLabel.Name = "labJackPositionLabel";
            this.labJackPositionLabel.Size = new System.Drawing.Size(300, 39);
            this.labJackPositionLabel.TabIndex = 14;
            this.labJackPositionLabel.Text = "Lab jack position: -";
            // 
            // maxIntensivityWaveLengthLabel
            // 
            this.maxIntensivityWaveLengthLabel.AutoSize = true;
            this.maxIntensivityWaveLengthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.maxIntensivityWaveLengthLabel.Location = new System.Drawing.Point(57, 529);
            this.maxIntensivityWaveLengthLabel.Name = "maxIntensivityWaveLengthLabel";
            this.maxIntensivityWaveLengthLabel.Size = new System.Drawing.Size(611, 39);
            this.maxIntensivityWaveLengthLabel.TabIndex = 15;
            this.maxIntensivityWaveLengthLabel.Text = "Maximum intensivity: - for wavelength: -";
            // 
            // calibrationCurveEquationLabel
            // 
            this.calibrationCurveEquationLabel.AutoSize = true;
            this.calibrationCurveEquationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.calibrationCurveEquationLabel.Location = new System.Drawing.Point(57, 619);
            this.calibrationCurveEquationLabel.Name = "calibrationCurveEquationLabel";
            this.calibrationCurveEquationLabel.Size = new System.Drawing.Size(442, 39);
            this.calibrationCurveEquationLabel.TabIndex = 16;
            this.calibrationCurveEquationLabel.Text = "Calibration curve equation: -";
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
            this.absolutePositionLabel.Location = new System.Drawing.Point(57, 924);
            this.absolutePositionLabel.Name = "absolutePositionLabel";
            this.absolutePositionLabel.Size = new System.Drawing.Size(277, 39);
            this.absolutePositionLabel.TabIndex = 18;
            this.absolutePositionLabel.Text = "Absolute position";
            // 
            // absolutePositionButton
            // 
            this.absolutePositionButton.Location = new System.Drawing.Point(63, 1004);
            this.absolutePositionButton.Name = "absolutePositionButton";
            this.absolutePositionButton.Size = new System.Drawing.Size(808, 60);
            this.absolutePositionButton.TabIndex = 19;
            this.absolutePositionButton.Text = "Move";
            this.absolutePositionButton.UseVisualStyleBackColor = true;
            this.absolutePositionButton.Click += new System.EventHandler(this.absolutePositionButton_Click);
            // 
            // absolutePositionLabel_mm
            // 
            this.absolutePositionLabel_mm.AutoSize = true;
            this.absolutePositionLabel_mm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.absolutePositionLabel_mm.Location = new System.Drawing.Point(790, 924);
            this.absolutePositionLabel_mm.Name = "absolutePositionLabel_mm";
            this.absolutePositionLabel_mm.Size = new System.Drawing.Size(73, 39);
            this.absolutePositionLabel_mm.TabIndex = 20;
            this.absolutePositionLabel_mm.Text = "mm";
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
            // labJackConnectionBackgroundWorker
            // 
            this.labJackConnectionBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.labJackConnectionBackgroundWorker_DoWork);
            // 
            // integrationTimeLabel_us
            // 
            this.integrationTimeLabel_us.AutoSize = true;
            this.integrationTimeLabel_us.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.integrationTimeLabel_us.Location = new System.Drawing.Point(790, 750);
            this.integrationTimeLabel_us.Name = "integrationTimeLabel_us";
            this.integrationTimeLabel_us.Size = new System.Drawing.Size(53, 39);
            this.integrationTimeLabel_us.TabIndex = 24;
            this.integrationTimeLabel_us.Text = "μs";
            // 
            // integrationTimeButton
            // 
            this.integrationTimeButton.Enabled = false;
            this.integrationTimeButton.Location = new System.Drawing.Point(63, 830);
            this.integrationTimeButton.Name = "integrationTimeButton";
            this.integrationTimeButton.Size = new System.Drawing.Size(808, 60);
            this.integrationTimeButton.TabIndex = 23;
            this.integrationTimeButton.Text = "Set";
            this.integrationTimeButton.UseVisualStyleBackColor = true;
            this.integrationTimeButton.Click += new System.EventHandler(this.integrationTimeButton_Click);
            // 
            // integrationTimeTextBoxLabel
            // 
            this.integrationTimeTextBoxLabel.AutoSize = true;
            this.integrationTimeTextBoxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.integrationTimeTextBoxLabel.Location = new System.Drawing.Point(57, 750);
            this.integrationTimeTextBoxLabel.Name = "integrationTimeTextBoxLabel";
            this.integrationTimeTextBoxLabel.Size = new System.Drawing.Size(251, 39);
            this.integrationTimeTextBoxLabel.TabIndex = 22;
            this.integrationTimeTextBoxLabel.Text = "Integration time";
            // 
            // calibrationCurveChart
            // 
            chartArea7.AxisX.IsLabelAutoFit = false;
            chartArea7.AxisX.LabelStyle.Angle = 90;
            chartArea7.AxisX.Title = "Absolute position [mm]";
            chartArea7.AxisY.LabelAutoFitStyle = ((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles)(((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.StaggeredLabels | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.LabelsAngleStep30) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.WordWrap)));
            chartArea7.AxisY.Title = "Wavelength [nm]";
            chartArea7.Name = "ChartArea1";
            this.calibrationCurveChart.ChartAreas.Add(chartArea7);
            this.calibrationCurveChart.Location = new System.Drawing.Point(1964, 55);
            this.calibrationCurveChart.Name = "calibrationCurveChart";
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series9.Name = "Calibration curve points";
            series10.BorderWidth = 2;
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series10.Color = System.Drawing.Color.Brown;
            series10.Name = "Regression line";
            this.calibrationCurveChart.Series.Add(series9);
            this.calibrationCurveChart.Series.Add(series10);
            this.calibrationCurveChart.Size = new System.Drawing.Size(960, 580);
            this.calibrationCurveChart.TabIndex = 26;
            title7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            title7.Name = "Title1";
            title7.Text = "Calibration curve";
            this.calibrationCurveChart.Titles.Add(title7);
            // 
            // saveCalibrationCurvePointsButton
            // 
            this.saveCalibrationCurvePointsButton.Enabled = false;
            this.saveCalibrationCurvePointsButton.Location = new System.Drawing.Point(1983, 1054);
            this.saveCalibrationCurvePointsButton.Name = "saveCalibrationCurvePointsButton";
            this.saveCalibrationCurvePointsButton.Size = new System.Drawing.Size(941, 60);
            this.saveCalibrationCurvePointsButton.TabIndex = 27;
            this.saveCalibrationCurvePointsButton.Text = "Save calibration curve points";
            this.saveCalibrationCurvePointsButton.UseVisualStyleBackColor = true;
            this.saveCalibrationCurvePointsButton.Click += new System.EventHandler(this.saveCalibrationCurvePoints_Click);
            // 
            // labJackPositionHistoryChart
            // 
            chartArea8.AxisX.Interval = 1D;
            chartArea8.AxisX.IsLabelAutoFit = false;
            chartArea8.AxisX.LabelStyle.Angle = 90;
            chartArea8.AxisX.Maximum = 0D;
            chartArea8.AxisX.Minimum = -10D;
            chartArea8.AxisX.Title = "Time [s]";
            chartArea8.AxisY.LabelAutoFitStyle = ((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles)(((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.StaggeredLabels | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.LabelsAngleStep30) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.WordWrap)));
            chartArea8.AxisY.LabelStyle.Format = "0.00";
            chartArea8.AxisY.Maximum = 0D;
            chartArea8.AxisY.Minimum = 10D;
            chartArea8.AxisY.Title = "Lab jack position [mm]";
            chartArea8.Name = "ChartArea1";
            this.labJackPositionHistoryChart.ChartAreas.Add(chartArea8);
            this.labJackPositionHistoryChart.Location = new System.Drawing.Point(940, 688);
            this.labJackPositionHistoryChart.Name = "labJackPositionHistoryChart";
            series11.BorderWidth = 3;
            series11.ChartArea = "ChartArea1";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series11.Name = "Lab jack position";
            this.labJackPositionHistoryChart.Series.Add(series11);
            this.labJackPositionHistoryChart.Size = new System.Drawing.Size(960, 580);
            this.labJackPositionHistoryChart.TabIndex = 28;
            title8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            title8.Name = "Title1";
            title8.Text = "Lab jack position";
            this.labJackPositionHistoryChart.Titles.Add(title8);
            // 
            // averageSpectrumButton
            // 
            this.averageSpectrumButton.Location = new System.Drawing.Point(66, 1194);
            this.averageSpectrumButton.Name = "averageSpectrumButton";
            this.averageSpectrumButton.Size = new System.Drawing.Size(805, 60);
            this.averageSpectrumButton.TabIndex = 30;
            this.averageSpectrumButton.Text = "Set";
            this.averageSpectrumButton.UseVisualStyleBackColor = true;
            this.averageSpectrumButton.Click += new System.EventHandler(this.averageSpectrumButton_Click);
            // 
            // averageSpectrumTextBoxLabel
            // 
            this.averageSpectrumTextBoxLabel.AutoSize = true;
            this.averageSpectrumTextBoxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.averageSpectrumTextBoxLabel.Location = new System.Drawing.Point(60, 1114);
            this.averageSpectrumTextBoxLabel.Name = "averageSpectrumTextBoxLabel";
            this.averageSpectrumTextBoxLabel.Size = new System.Drawing.Size(414, 39);
            this.averageSpectrumTextBoxLabel.TabIndex = 29;
            this.averageSpectrumTextBoxLabel.Text = "Average spectrum amount";
            // 
            // labJackPostitionHistoryBackgroundWorker
            // 
            this.labJackPostitionHistoryBackgroundWorker.WorkerSupportsCancellation = true;
            this.labJackPostitionHistoryBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.labJackPostitionHistoryBackgroundWorker_DoWork);
            // 
            // spectrumChart
            // 
            chartArea9.AxisX.Interval = 100D;
            chartArea9.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea9.AxisX.IntervalOffset = 4.69026828777D;
            chartArea9.AxisX.IsLabelAutoFit = false;
            chartArea9.AxisX.LabelStyle.Angle = 90;
            chartArea9.AxisX.Title = "Wavelength [nm]";
            chartArea9.AxisY.LabelAutoFitStyle = ((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles)(((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.StaggeredLabels | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.LabelsAngleStep30) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.WordWrap)));
            chartArea9.AxisY.Maximum = 16384D;
            chartArea9.AxisY.Title = "Intensivity";
            chartArea9.Name = "ChartArea1";
            this.spectrumChart.ChartAreas.Add(chartArea9);
            this.spectrumChart.Location = new System.Drawing.Point(940, 55);
            this.spectrumChart.Name = "spectrumChart";
            series12.ChartArea = "ChartArea1";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series12.Name = "Spectrum";
            this.spectrumChart.Series.Add(series12);
            this.spectrumChart.Size = new System.Drawing.Size(960, 580);
            this.spectrumChart.TabIndex = 17;
            title9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            title9.Name = "Spectrum live view";
            title9.Text = "Spectrum live view";
            this.spectrumChart.Titles.Add(title9);
            // 
            // integrationTimeLabel
            // 
            this.integrationTimeLabel.AutoSize = true;
            this.integrationTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.integrationTimeLabel.Location = new System.Drawing.Point(59, 261);
            this.integrationTimeLabel.Name = "integrationTimeLabel";
            this.integrationTimeLabel.Size = new System.Drawing.Size(280, 39);
            this.integrationTimeLabel.TabIndex = 33;
            this.integrationTimeLabel.Text = "Integration time: -";
            // 
            // averageSpectrumLabel
            // 
            this.averageSpectrumLabel.AutoSize = true;
            this.averageSpectrumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.averageSpectrumLabel.Location = new System.Drawing.Point(60, 436);
            this.averageSpectrumLabel.Name = "averageSpectrumLabel";
            this.averageSpectrumLabel.Size = new System.Drawing.Size(451, 39);
            this.averageSpectrumLabel.TabIndex = 34;
            this.averageSpectrumLabel.Text = "Average spectrum amount: 1";
            // 
            // saveSpectrumButton
            // 
            this.saveSpectrumButton.Location = new System.Drawing.Point(1983, 1137);
            this.saveSpectrumButton.Name = "saveSpectrumButton";
            this.saveSpectrumButton.Size = new System.Drawing.Size(941, 60);
            this.saveSpectrumButton.TabIndex = 36;
            this.saveSpectrumButton.Text = "Save spectrum";
            this.saveSpectrumButton.UseVisualStyleBackColor = true;
            this.saveSpectrumButton.Click += new System.EventHandler(this.saveSpectrumButton_Click);
            // 
            // absolutePositionNumericUpDown
            // 
            this.absolutePositionNumericUpDown.DecimalPlaces = 3;
            this.absolutePositionNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.absolutePositionNumericUpDown.InterceptArrowKeys = false;
            this.absolutePositionNumericUpDown.Location = new System.Drawing.Point(627, 927);
            this.absolutePositionNumericUpDown.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.absolutePositionNumericUpDown.Name = "absolutePositionNumericUpDown";
            this.absolutePositionNumericUpDown.Size = new System.Drawing.Size(143, 38);
            this.absolutePositionNumericUpDown.TabIndex = 37;
            // 
            // integrationTimeNumericUpDown
            // 
            this.integrationTimeNumericUpDown.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.integrationTimeNumericUpDown.InterceptArrowKeys = false;
            this.integrationTimeNumericUpDown.Location = new System.Drawing.Point(630, 753);
            this.integrationTimeNumericUpDown.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.integrationTimeNumericUpDown.Minimum = new decimal(new int[] {
            4000,
            0,
            0,
            0});
            this.integrationTimeNumericUpDown.Name = "integrationTimeNumericUpDown";
            this.integrationTimeNumericUpDown.Size = new System.Drawing.Size(143, 38);
            this.integrationTimeNumericUpDown.TabIndex = 38;
            this.integrationTimeNumericUpDown.Value = new decimal(new int[] {
            4000,
            0,
            0,
            0});
            // 
            // averageSpectrumNumericUpDown
            // 
            this.averageSpectrumNumericUpDown.InterceptArrowKeys = false;
            this.averageSpectrumNumericUpDown.Location = new System.Drawing.Point(630, 1117);
            this.averageSpectrumNumericUpDown.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.averageSpectrumNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.averageSpectrumNumericUpDown.Name = "averageSpectrumNumericUpDown";
            this.averageSpectrumNumericUpDown.Size = new System.Drawing.Size(143, 38);
            this.averageSpectrumNumericUpDown.TabIndex = 39;
            this.averageSpectrumNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // startPositionNumericUpDown
            // 
            this.startPositionNumericUpDown.DecimalPlaces = 3;
            this.startPositionNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.startPositionNumericUpDown.InterceptArrowKeys = false;
            this.startPositionNumericUpDown.Location = new System.Drawing.Point(2688, 709);
            this.startPositionNumericUpDown.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.startPositionNumericUpDown.Name = "startPositionNumericUpDown";
            this.startPositionNumericUpDown.Size = new System.Drawing.Size(143, 38);
            this.startPositionNumericUpDown.TabIndex = 40;
            // 
            // endPositionNumericUpDown
            // 
            this.endPositionNumericUpDown.DecimalPlaces = 3;
            this.endPositionNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.endPositionNumericUpDown.InterceptArrowKeys = false;
            this.endPositionNumericUpDown.Location = new System.Drawing.Point(2688, 789);
            this.endPositionNumericUpDown.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.endPositionNumericUpDown.Name = "endPositionNumericUpDown";
            this.endPositionNumericUpDown.Size = new System.Drawing.Size(143, 38);
            this.endPositionNumericUpDown.TabIndex = 41;
            // 
            // stepLengthNumericUpDown
            // 
            this.stepLengthNumericUpDown.DecimalPlaces = 3;
            this.stepLengthNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.stepLengthNumericUpDown.InterceptArrowKeys = false;
            this.stepLengthNumericUpDown.Location = new System.Drawing.Point(2688, 869);
            this.stepLengthNumericUpDown.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.stepLengthNumericUpDown.Name = "stepLengthNumericUpDown";
            this.stepLengthNumericUpDown.Size = new System.Drawing.Size(143, 38);
            this.stepLengthNumericUpDown.TabIndex = 42;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2968, 1332);
            this.Controls.Add(this.stepLengthNumericUpDown);
            this.Controls.Add(this.endPositionNumericUpDown);
            this.Controls.Add(this.startPositionNumericUpDown);
            this.Controls.Add(this.averageSpectrumNumericUpDown);
            this.Controls.Add(this.integrationTimeNumericUpDown);
            this.Controls.Add(this.absolutePositionNumericUpDown);
            this.Controls.Add(this.saveSpectrumButton);
            this.Controls.Add(this.averageSpectrumLabel);
            this.Controls.Add(this.integrationTimeLabel);
            this.Controls.Add(this.averageSpectrumButton);
            this.Controls.Add(this.averageSpectrumTextBoxLabel);
            this.Controls.Add(this.labJackPositionHistoryChart);
            this.Controls.Add(this.saveCalibrationCurvePointsButton);
            this.Controls.Add(this.calibrationCurveChart);
            this.Controls.Add(this.integrationTimeLabel_us);
            this.Controls.Add(this.integrationTimeButton);
            this.Controls.Add(this.integrationTimeTextBoxLabel);
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
            this.Controls.Add(this.stepLengthLabel);
            this.Controls.Add(this.endPositionLabel);
            this.Controls.Add(this.startPositionLabel);
            this.Controls.Add(this.labJackConnectionButton);
            this.Controls.Add(this.labJackConnectionLabel);
            this.Controls.Add(this.spectrometerConnectionButton);
            this.Controls.Add(this.spectrometerConnectionLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Transparent material thickness measurement";
            this.Text = "Transparent material thickness measurement";
            ((System.ComponentModel.ISupportInitialize)(this.calibrationCurveChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labJackPositionHistoryChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spectrumChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.absolutePositionNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.integrationTimeNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.averageSpectrumNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startPositionNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endPositionNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stepLengthNumericUpDown)).EndInit();
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
        private System.Windows.Forms.Label startPositionLabel_mm;
        private System.Windows.Forms.Label endPositionLabel_mm;
        private System.Windows.Forms.Label stepLengthLabel_mm;
        private System.Windows.Forms.Button createCalibrationCurveButton;
        private System.Windows.Forms.Label labJackPositionLabel;
        private System.Windows.Forms.Label maxIntensivityWaveLengthLabel;
        private System.Windows.Forms.Label calibrationCurveEquationLabel;
        private System.ComponentModel.BackgroundWorker spectrumMeasurementBackgroundWorker;
        private System.Windows.Forms.Label absolutePositionLabel;
        private System.Windows.Forms.Button absolutePositionButton;
        private System.Windows.Forms.Label absolutePositionLabel_mm;
        private System.ComponentModel.BackgroundWorker absolutePositionBackgroundWorker;
        private System.ComponentModel.BackgroundWorker labJackPositionBackgroundWorker;
        private System.ComponentModel.BackgroundWorker calibrationCurveBackgroundWorker;
        private System.ComponentModel.BackgroundWorker labJackConnectionBackgroundWorker;
        private System.Windows.Forms.Label integrationTimeLabel_us;
        private System.Windows.Forms.Button integrationTimeButton;
        private System.Windows.Forms.Label integrationTimeTextBoxLabel;
        private System.Windows.Forms.DataVisualization.Charting.Chart calibrationCurveChart;
        private System.Windows.Forms.Button saveCalibrationCurvePointsButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart labJackPositionHistoryChart;
        private System.Windows.Forms.Button averageSpectrumButton;
        private System.Windows.Forms.Label averageSpectrumTextBoxLabel;
        private System.ComponentModel.BackgroundWorker labJackPostitionHistoryBackgroundWorker;
        private System.Windows.Forms.DataVisualization.Charting.Chart spectrumChart;
        private System.Windows.Forms.Label integrationTimeLabel;
        private System.Windows.Forms.Label averageSpectrumLabel;
        private System.Windows.Forms.Button saveSpectrumButton;
        private System.Windows.Forms.NumericUpDown absolutePositionNumericUpDown;
        private System.Windows.Forms.NumericUpDown integrationTimeNumericUpDown;
        private System.Windows.Forms.NumericUpDown averageSpectrumNumericUpDown;
        private System.Windows.Forms.NumericUpDown startPositionNumericUpDown;
        private System.Windows.Forms.NumericUpDown endPositionNumericUpDown;
        private System.Windows.Forms.NumericUpDown stepLengthNumericUpDown;
    }
}

