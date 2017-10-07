using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SA45TEAM07_VEHICLE
{
    public class Vehicle
    {
        string model;
        string color;
        string engineSN;
        string status = "available";
        string plateNum;
        string category;

        public string Model
        {
            get
            {
                return model;
            }

            set
            {
                model = value;
            }
        }

        public string Color
        {
            get
            {
                return color;
            }

            set
            {
                color = value;
            }
        }

        public string EngineSN
        {
            get
            {
                return engineSN;
            }

            set
            {
                engineSN = value;
            }
        }

        public string Status
        {
            get
            {
                return status;
            }

            set
            {
                status = value;
            }
        }

        public string PlateNum
        {
            get
            {
                return plateNum;
            }

            set
            {
                plateNum = value;
            }
        }

        public string Category
        {
            get
            {
                return category;
            }
            set
            {
                category = value;
            }
        }
    }
}
