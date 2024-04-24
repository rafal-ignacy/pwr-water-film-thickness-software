using System;
using System.Globalization;
using System.Collections.Generic;
using pwr_water_film_thickness_software.DataModels;
using pwr_water_film_thickness_software.CalibrationCurve;
using pwr_water_film_thickness_software.Data_Models;

namespace pwr_water_film_thickness_software
{
    public partial class MainForm
    {
        private void createCalibrationCurveButton_Click(object sender, System.EventArgs e)
        {
            if (calibrationCurveBackgroundWorker.IsBusy != true)
            {
                calibrationCurveBackgroundWorker.RunWorkerAsync();
            }
        }
    }
}
