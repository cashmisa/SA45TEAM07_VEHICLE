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
    public partial class FormCategorySearch : BaseForm
    {
        private RentVehicleControl rentvehiclecontrol;

        public FormCategorySearch()
        {
            InitializeComponent();
        }

        public FormCategorySearch(RentVehicleControl rentvehiclecontrol) : this()
        {
            this.rentvehiclecontrol = rentvehiclecontrol;
        }

        internal void displayCategorySearchUI()
        {
            this.Show();
        }

        private void btnRetreive_Click(object sender, EventArgs e)
        {
            
        }

        private void btnRent_Click(object sender, EventArgs e)
        {
            rentvehiclecontrol.SelectVehicle();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        public void displayCategory(List<string> vehiclecategory)
        {
            lbxCategory.DataSource = vehiclecategory;
            //foreach(var veh in vehiclecategory)
            //{
            //    this.lbxCategory.Items.Add(veh);
            //}
        }
    }
}
