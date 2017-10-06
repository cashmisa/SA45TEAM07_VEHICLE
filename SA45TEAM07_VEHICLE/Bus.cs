using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SA45TEAM07_VEHICLE
{
    class Bus: Vehicle
    {
        int maxPassenger;
        int tvQty;

        public int MaxPassenger { get => maxPassenger; set => maxPassenger = value; }
        public int TvQty { get => tvQty; set => tvQty = value; }
    }
}
