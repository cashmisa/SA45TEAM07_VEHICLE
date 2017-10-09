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

        public void DisplayRentalDetails(string plateNum)
        {
            this.Show();
            toolStripStatusLabelRentInfo.Text = "Vehicle selected: " + plateNum;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (btnSearch.Enabled == true)
            {
                if (!VehicleUtility.isNRICValid(txbNRIC.Text))
                {
                    MessageBox.Show(VehicleMessage.InvalidNRIC);
                    return;
                }

                record.RentingCustomer = rentvehiclecontrol.retrieveCustomerDetails(txbNRIC.Text.Trim());
                txbCusName.Text = record.RentingCustomer.Name;
                txbPhone.Text = record.RentingCustomer.TelNum;
                txbEmail.Text = record.RentingCustomer.Email;
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (btnConfirm.Enabled == true)
            {
                //now that the form is holding the RentalRecord object 
                //and its Customer and Vehicle attribute

                record.RentStartDate = dateTimePickerRent.Value.Date;
                record.RentalPeriod = (dateTimePickerDue.Value.Date - dateTimePickerRent.Value.Date).Days;

                rentvehiclecontrol.UpdateVehicleStatus(record.RentedVehicle);
   
                rentvehiclecontrol.CreateRentalRecord(record);
                MessageBox.Show(VehicleMessage.RentalrRecordSuccessful);
                rentvehiclecontrol.Close(this);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            rentvehiclecontrol.Close(this);
        }

        private void FormRentDetails_Load(object sender, EventArgs e)
        {
            btnSearch.Enabled = false;
            btnConfirm.Enabled = false;
            dateTimePickerDue.MinDate = dateTimePickerRent.Value.Date.AddDays(1);
            dateTimePickerDue.MaxDate = dateTimePickerRent.Value.Date.AddDays(99);
        }

        private void txbNRIC_TextChanged(object sender, EventArgs e)
        {
            if (txbNRIC.Text.Trim() != "")
            {
                btnSearch.Enabled = true;
            }
        }

        private void txbCusName_TextChanged(object sender, EventArgs e)
        {
            if (txbCusName.Text != "")
            {
                btnConfirm.Enabled = true;
            }
        }

    }
}
