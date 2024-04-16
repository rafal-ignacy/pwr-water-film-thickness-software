using pwr_water_film_thickness_software.DataModels;
using pwr_water_film_thickness_software.DeviceHandlers;
using pwr_water_film_thickness_software.Mocks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pwr_water_film_thickness_software
{
    partial class MainForm
    {
        private string serialNumber = "46000001";
        private string deviceCode = "L490MZ";
        private int highLimit = 50;

        // private SpectrometerHandler spectrometerHandler = new SpectrometerHandler();
        private SpectrometerHandlerMock spectrometerHandler = new SpectrometerHandlerMock();

        // private LabJackHandler labJackHandler = new LabJackHandler();
        private LabJackHandler labJackHandler = new LabJackHandler();

        private List<Tuple<double, List<SpectrumRow>>> spectrumDataMatrix;

    }
}
