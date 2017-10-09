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
    public partial class FormAvailableVehicles : BaseForm
    {
        private RentVehicleControl rentvehiclecontrol;

        public FormAvailableVehicles(RentVehicleControl rentvehiclecontrol)
        {
            InitializeComponent();
            this.rentvehiclecontrol = rentvehiclecontrol;
        }

        internal void displayCategorySearchUI()
        {
            this.Show();
        }

        private void btnRetreive_Click(object sender, EventArgs e)
        {
            RetreiveClicked();
        }

        private void btnRent_Click(object sender, EventArgs e)
        {
            rentButtonClicked();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            rentvehiclecontrol.Close(this);
            rentvehiclecontrol.CloseUseCase();
        }

        private void FormCategorySearch_FormClosed(object sender, FormClosedEventArgs e)
        {
            rentvehiclecontrol.CloseUseCase();
        }

        public void displayCategory(List<string> vehiclecategory)
        {
            lbxCategory.DataSource = vehiclecategory;
        }

        internal void displayAvailableVehicle(DataTable dt)
        {
            dataGridViewAvailableVehicles.DataSource = dt;
        }

        private void rentButtonClicked()
        {
            string plateNum = "";
            if (dataGridViewAvailableVehicles.SelectedCells.Count > 0)
            {
                int a = dataGridViewAvailableVehicles.SelectedCells[0].RowIndex;
                plateNum = dataGridViewAvailableVehicles.Rows[a].Cells[0].Value.ToString();
            }

            //Rent button is grayed out
            //only after a selection is made,

            rentvehiclecontrol.SelectVehicle(plateNum);
        }

        private void dataGridViewAvailableVehicles_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            rentButtonClicked();
        }

        private void lbxCategory_DoubleClick(object sender, EventArgs e)
        {
            RetreiveClicked();
        }

        public void RetreiveClicked()
        {
            rentvehiclecontrol.SelectCategory(lbxCategory.SelectedItem.ToString());
        }
    }
}
