using pwr_water_film_thickness_software.DataModels;
using pwr_water_film_thickness_software.DeviceHandlers;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;

namespace pwr_water_film_thickness_software
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            materialComboBox.SelectedIndex = 0;
        }

        private void tempButton_Click(object sender, EventArgs e)
        {

        }
    }
}
