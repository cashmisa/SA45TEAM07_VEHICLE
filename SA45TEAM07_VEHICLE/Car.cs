using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SA45TEAM07_VEHICLE
{
    class Car : Vehicle
    {
        int maxSeat;
        string carType;

        public int MaxSeat { get => maxSeat; set => maxSeat = value; }
        public string CarType { get => carType; set => carType = value; }
    }
}
