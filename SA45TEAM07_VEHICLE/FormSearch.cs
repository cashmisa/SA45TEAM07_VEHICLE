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
    public partial class FormSearch : BaseForm
    {
        private EnquireVehicleStatusControl enquiryControl;

        public FormSearch()
        {
            InitializeComponent();
        }

        public FormSearch(EnquireVehicleStatusControl enquiryControl) : this()
        {
            this.enquiryControl = enquiryControl;
            this.MdiParent = enquiryControl.MainControl.PortalUI;
        }

        public void displaySearchUI()
        {
            this.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!VehicleUtility.isVehiclePlateValid(txbPlateNum.Text.Trim()))
            {
                MessageBox.Show(VehicleMessage.InvalidPlateNum);
                return;
            }
            enquiryControl.retrieveVehicle(txbPlateNum.Text.Trim());
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            enquiryControl.Close(this);
            enquiryControl.CloseUseCase();
        }

        private void FormSearch_FormClosed(object sender, FormClosedEventArgs e)
        {
            enquiryControl.CloseUseCase();
        }

        //protected override void WndProc(ref Message message)
        //{
        //    const int WM_SYSCOMMAND = 0x0112;
        //    const int SC_MOVE = 0xF010;

        //    switch (message.Msg)
        //    {
        //        case WM_SYSCOMMAND:
        //            int command = message.WParam.ToInt32() & 0xfff0;
        //            if (command == SC_MOVE)
        //                return;
        //            break;
        //    }

        //    base.WndProc(ref message);
        //}

        private void txbPlateNum_TextChanged(object sender, EventArgs e)
        {
            if (txbPlateNum.Text.Length > 0)
            {
                btnSearch.Enabled = true;
            }
            else
            {
                btnSearch.Enabled = false;
            }
        }
    }
}
