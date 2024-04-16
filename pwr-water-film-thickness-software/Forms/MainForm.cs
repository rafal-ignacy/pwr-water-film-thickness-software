using pwr_water_film_thickness_software.DeviceHandlers;
using System.Windows.Forms;

namespace pwr_water_film_thickness_software
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            SpectrometerHandler spectrometerHandler = new SpectrometerHandler();
            spectrometerHandler.Connect();
            InitializeComponent();
        }
    }
}
