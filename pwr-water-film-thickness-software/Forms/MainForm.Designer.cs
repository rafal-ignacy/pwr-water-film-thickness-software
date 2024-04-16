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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1888, 992);
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
    }
}

