using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SA45TEAM07_VEHICLE
{
    public class RentVehicleControl
    {
        private MainControl mainControl;
        private FormCategorySearch formCategorySearch;
        private FormRentDetails formRentDetails;

        public RentVehicleControl(MainControl mainControl)
        {
            this.mainControl = mainControl;
        }

        public void SelectCategory()
        {
            formCategorySearch = new FormCategorySearch(this);
            ;
        }

        public void SelectVehicle()
        {
            formRentDetails = new FormRentDetails(this);
            ;
        }
    }
}
