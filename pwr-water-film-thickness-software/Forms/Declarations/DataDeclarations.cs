using pwr_water_film_thickness_software.Data_Models;
using pwr_water_film_thickness_software.DataModels;
using pwr_water_film_thickness_software.DeviceHandlers;
using pwr_water_film_thickness_software.Mocks;
using pwr_water_film_thickness_software.Others;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pwr_water_film_thickness_software
{
    partial class MainForm
    {
        //private string serialNumber = "46833131";
        private string serialNumber = "46000001";
        private string deviceCode = "L490MZ";

        private int averageSpectrumAmount = 1;

        private List<CalibrationCurvePoint> calibrationCurvePoints;

        //private SpectrometerHandler spectrometerHandler = new SpectrometerHandler();
        private SpectrometerHandlerMock spectrometerHandler = new SpectrometerHandlerMock();
        private LabJackHandler labJackHandler = new LabJackHandler();
        private FileHandler fileHandler = new FileHandler();
    }
}
