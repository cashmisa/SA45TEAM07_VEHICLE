using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SA45TEAM07_VEHICLE
{
    class Customer
    {
        Int64 customerID;
        string idNumber;
        string name;
        string telNum;
        string email;

        public Int64 CustomerID
        {
            get
            {
                return customerID;
            }

            set
            {
                customerID = value;
            }
        }

        public string IdNumber
        {
            get
            {
                return idNumber;
            }

            set
            {
                idNumber = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string TelNum
        {
            get
            {
                return telNum;
            }

            set
            {
                telNum = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }
    }
}
