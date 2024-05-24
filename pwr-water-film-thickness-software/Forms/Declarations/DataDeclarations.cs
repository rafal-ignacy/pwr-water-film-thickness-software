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
        private string serialNumber = "46833131";
        //private string serialNumber = "46000001";
        private string deviceCode = "L490MZ";

        //thickness measurement parameters
        private double h0 = 24.7023;
        private double k = 0.002189333;
        private double r = 6.25;
        private double n = 1;
        private double n1 = 1.33;
        private double thickness;


        private int averageSpectrumAmount = 1;

        private List<CalibrationCurvePoint> calibrationCurvePoints;
        private List<ThicknessHistoricalPoint> thicknessMeasurements = new List<ThicknessHistoricalPoint>();

        private SpectrometerHandler spectrometerHandler = new SpectrometerHandler();
        //private SpectrometerHandlerMock spectrometerHandler = new SpectrometerHandlerMock();
        private LabJackHandler labJackHandler = new LabJackHandler();
        private FileHandler fileHandler = new FileHandler();
    }
}
