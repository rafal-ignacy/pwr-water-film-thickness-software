using System;
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
    }
}
