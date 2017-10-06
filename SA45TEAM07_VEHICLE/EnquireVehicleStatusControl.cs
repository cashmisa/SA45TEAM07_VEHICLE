using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SA45TEAM07_VEHICLE
{
    public class EnquireVehicleStatusControl
    {
        private frmSearchUI searchUI;
        private MainControl mainControl;

        public EnquireVehicleStatusControl(MainControl mainControl)
        {
            this.mainControl = mainControl;
            displaySearchUI();      
        }

        public frmSearchUI SearchUI
        {
            get
            {
                return searchUI;
            }
        }

        public void displaySearchUI()
        {
            if (searchUI == null)
            {
                searchUI = new frmSearchUI();
                searchUI.Show();
            }
        }

        public void retrieveVehicle(string plateNum)
        {

        }


        public void close()
        {

        }

        public void closeUseCase()
        {

        }

        public void destroy()
        {

        }




    }
}
