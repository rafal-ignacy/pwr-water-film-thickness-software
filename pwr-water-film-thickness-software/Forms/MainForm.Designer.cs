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
            this.stepMovementButton = new System.Windows.Forms.Button();
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
            this.startPositionLabel.Location = new System.Drawing.Point(60, 270);
            this.startPositionLabel.Name = "startPositionLabel";
            this.startPositionLabel.Size = new System.Drawing.Size(215, 39);
            this.startPositionLabel.TabIndex = 4;
            this.startPositionLabel.Text = "Start position";
            // 
            // endPositionLabel
            // 
            this.endPositionLabel.AutoSize = true;
            this.endPositionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.endPositionLabel.Location = new System.Drawing.Point(60, 350);
            this.endPositionLabel.Name = "endPositionLabel";
            this.endPositionLabel.Size = new System.Drawing.Size(205, 39);
            this.endPositionLabel.TabIndex = 5;
            this.endPositionLabel.Text = "End position";
            // 
            // stepLengthLabel
            // 
            this.stepLengthLabel.AutoSize = true;
            this.stepLengthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.stepLengthLabel.Location = new System.Drawing.Point(60, 430);
            this.stepLengthLabel.Name = "stepLengthLabel";
            this.stepLengthLabel.Size = new System.Drawing.Size(189, 39);
            this.stepLengthLabel.TabIndex = 6;
            this.stepLengthLabel.Text = "Step length";
            // 
            // startPositionTextBox
            // 
            this.startPositionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.startPositionTextBox.Location = new System.Drawing.Point(351, 267);
            this.startPositionTextBox.Name = "startPositionTextBox";
            this.startPositionTextBox.Size = new System.Drawing.Size(140, 45);
            this.startPositionTextBox.TabIndex = 7;
            // 
            // endPositionTextBox
            // 
            this.endPositionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.endPositionTextBox.Location = new System.Drawing.Point(351, 347);
            this.endPositionTextBox.Name = "endPositionTextBox";
            this.endPositionTextBox.Size = new System.Drawing.Size(140, 45);
            this.endPositionTextBox.TabIndex = 8;
            // 
            // stepLengthTextBox
            // 
            this.stepLengthTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.stepLengthTextBox.Location = new System.Drawing.Point(351, 427);
            this.stepLengthTextBox.Name = "stepLengthTextBox";
            this.stepLengthTextBox.Size = new System.Drawing.Size(140, 45);
            this.stepLengthTextBox.TabIndex = 9;
            // 
            // startPositionLabel_mm
            // 
            this.startPositionLabel_mm.AutoSize = true;
            this.startPositionLabel_mm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.startPositionLabel_mm.Location = new System.Drawing.Point(520, 270);
            this.startPositionLabel_mm.Name = "startPositionLabel_mm";
            this.startPositionLabel_mm.Size = new System.Drawing.Size(73, 39);
            this.startPositionLabel_mm.TabIndex = 10;
            this.startPositionLabel_mm.Text = "mm";
            // 
            // endPositionLabel_mm
            // 
            this.endPositionLabel_mm.AutoSize = true;
            this.endPositionLabel_mm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.endPositionLabel_mm.Location = new System.Drawing.Point(520, 350);
            this.endPositionLabel_mm.Name = "endPositionLabel_mm";
            this.endPositionLabel_mm.Size = new System.Drawing.Size(73, 39);
            this.endPositionLabel_mm.TabIndex = 11;
            this.endPositionLabel_mm.Text = "mm";
            // 
            // stepLengthLabel_mm
            // 
            this.stepLengthLabel_mm.AutoSize = true;
            this.stepLengthLabel_mm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.stepLengthLabel_mm.Location = new System.Drawing.Point(520, 430);
            this.stepLengthLabel_mm.Name = "stepLengthLabel_mm";
            this.stepLengthLabel_mm.Size = new System.Drawing.Size(73, 39);
            this.stepLengthLabel_mm.TabIndex = 12;
            this.stepLengthLabel_mm.Text = "mm";
            // 
            // stepMovementButton
            // 
            this.stepMovementButton.Location = new System.Drawing.Point(67, 539);
            this.stepMovementButton.Name = "stepMovementButton";
            this.stepMovementButton.Size = new System.Drawing.Size(700, 60);
            this.stepMovementButton.TabIndex = 13;
            this.stepMovementButton.Text = "Move";
            this.stepMovementButton.UseVisualStyleBackColor = true;
            this.stepMovementButton.Click += new System.EventHandler(this.stepMovementButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1888, 992);
            this.Controls.Add(this.stepMovementButton);
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
        private System.Windows.Forms.Button stepMovementButton;
    }
}

