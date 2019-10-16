using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VechicleAppPractice2
{
    class Vehicle
    {
        private List<double> speed = new List<double>();
        private string vehicleName;
        private string regNo;

        public string VehicleName { set; get; }
        public string RegNo { set; get; }

        public void SetList(double value)
        {
            speed.Add(value);
        }

        private double minSpeed;
        public double MinSpeed
        {
            get
            {
                return this.minSpeed = speed.Min();
            }
        }

        private double maxSpeed;
        public double MaxSpeed
        {
            get
            {
                return this.maxSpeed = speed.Max();
            }
        }

        private double avgSpeed;
        public double AvgSpeed
        {
            get
            {
                return this.avgSpeed = speed.Average();
            }
        }
    }
}
