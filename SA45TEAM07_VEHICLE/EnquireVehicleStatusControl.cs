using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SA45TEAM07_VEHICLE
{
    public class EnquireVehicleStatusControl
    {
        private FormSearch searchUI;
        private MainControl mainControl;

        public EnquireVehicleStatusControl(MainControl mainControl)
        {
            this.mainControl = mainControl;

            if (searchUI == null)
            {
                searchUI = new FormSearch(this);
                searchUI.displaySearchUI();
            }   
        }

        public MainControl MainControl
        {
            get
            {
                return mainControl;
            }
        }


        public FormSearch SearchUI
        {
            get
            {
                return searchUI;
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
