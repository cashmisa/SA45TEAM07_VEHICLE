using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SA45TEAM07_VEHICLE
{
    class Vehicle
    {
        string model;
        string color;
        string engineSN;
        string status = "available";
        string plateNum;

        public string Model { get => model; set => model = value; }
        public string Color { get => color; set => color = value; }
        public string EngineSN { get => engineSN; set => engineSN = value; }
        public string Status { get => status; set => status = value; }
        public string PlateNum { get => plateNum; set => plateNum = value; }
    }
}
