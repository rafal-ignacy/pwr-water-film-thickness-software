using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pwr_water_film_thickness_software.Data_Models
{
    internal class LabJackPositionHistoricalPoint
    {
        public double Time { get; set; }
        public double Position { get; set; }
        public LabJackPositionHistoricalPoint(double time, double position)
        {
            Time = time;
            Position = position;
        }
    }
}
