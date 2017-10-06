using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SA45TEAM07_VEHICLE
{
    public partial class FormRentDetails : BaseForm
    {
        private RentVehicleControl rentvehiclecontrol;
        public FormRentDetails()
        {
            InitializeComponent();
        }

        public FormRentDetails(RentVehicleControl rentvehiclecontrol) : this()
        {
            this.rentvehiclecontrol = rentvehiclecontrol;
        }

        internal void displayRentalDetails()
        {
            this.Show();
        }
    }
}
