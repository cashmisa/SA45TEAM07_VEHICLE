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
        RentalRecord record;

        public RentalRecord Record
        {
            get
            {
                return record;
            }

            set
            {
                record = value;
            }
        }

        public FormRentDetails(RentVehicleControl rentvehiclecontrol)
        {
            InitializeComponent();
            this.rentvehiclecontrol = rentvehiclecontrol;
            record = new RentalRecord();
        }

        internal void displayRentalDetails(string plateNum)
        {
            this.Show();
            toolStripStatusLabelRentInfo.Text = "Vehicle selected: " + plateNum;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //if (VehicleUtility.isNRICValid(txbNRIC.Text))
            //{
            //    MessageBox.Show(VehicleMessage.InvalidNRIC);
            //    return;
            //}
            
            record.RentingCustomer = rentvehiclecontrol.retrieveCustomerDetails(txbNRIC.Text.Trim());
            MessageBox.Show(record.RentingCustomer.CustomerID.ToString());
            txbCusName.Text = record.RentingCustomer.Name;
            txbPhone.Text = record.RentingCustomer.TelNum;
            txbEmail.Text = record.RentingCustomer.Email;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            //now that the form is holding the RentalRecord object 
            //and its Customer and Vehicle attribute

            record.RentStartDate = dateTimePickerRent.Value.Date;
            record.RentalPeriod = (dateTimePickerDue.Value.Date - dateTimePickerRent.Value.Date).Days;

            rentvehiclecontrol.updateVehicleStatus(record.RentedVehicle);
            //again it would have been better to pass vehicle object here


            rentvehiclecontrol.CreateRentalRecord(record);
            toolStripStatusLabelRentalStatus.Text = VehicleMessage.RentalrRecordSuccessful;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            rentvehiclecontrol.close(this);
        }
    }
}
