using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Transactions;


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
            if (btnEnter.Enabled == true)
            {
                if (!VehicleUtility.isNRICValid(txbNRIC.Text))
                {
                    MessageBox.Show(VehicleMessage.InvalidNRIC);
                    return;
                }
                try
                {
                    record.RentingCustomer = rentvehiclecontrol.RetrieveCustomer(txbNRIC.Text.Trim());
                    txbCusName.Text = record.RentingCustomer.Name;
                    txbPhone.Text = record.RentingCustomer.TelNum;
                    txbEmail.Text = record.RentingCustomer.Email;

                }
                catch (VehicleException)
                {
                    MessageBox.Show(VehicleMessage.CustomerRecordNotFound);
                    return;
                }
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (btnConfirm.Enabled == true)
            {
                record.RentStartDate = dateTimePickerRent.Value.Date;
                record.RentalPeriod = (dateTimePickerDue.Value.Date - dateTimePickerRent.Value.Date).Days;

                using (TransactionScope ts = new TransactionScope())
                {
                    rentvehiclecontrol.UpdateVehicleStatus(record.RentedVehicle);
                    rentvehiclecontrol.CreateRentalRecord(record);
                    ts.Complete();
                }

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
            btnEnter.Enabled = false;
            btnConfirm.Enabled = false;
            dateTimePickerDue.MinDate = dateTimePickerRent.Value.Date.AddDays(1);
            dateTimePickerDue.MaxDate = dateTimePickerRent.Value.Date.AddDays(99);
        }

        private void txbNRIC_TextChanged(object sender, EventArgs e)
        {
            if (txbNRIC.Text.Trim() != "")
            {
                btnEnter.Enabled = true;
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
