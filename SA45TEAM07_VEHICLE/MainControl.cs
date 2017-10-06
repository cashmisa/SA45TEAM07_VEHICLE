using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SA45TEAM07_VEHICLE
{
    public class MainControl
    {
        private EnquireVehicleStatusControl enquiryControl;
        private RentVehicleControl rentControl;
        private FormMain portalUI;

        public MainControl()
        {
            if (PortalUI == null)
            {
                PortalUI = new FormMain(this);
                PortalUI.displayPortalUI();
            }
        }

        public FormMain PortalUI
        {
            get
            {
                return portalUI;
            }
            set
            {
                portalUI = value;
            }
        }

        public EnquireVehicleStatusControl EnquiryControl
        {
            get
            {
                return enquiryControl;
            }
        }

        public RentVehicleControl RentControl
        {
            get
            {
                return rentControl;
            }
        }

        public void initialiseEnquiryControl()
        {
            this.enquiryControl = new EnquireVehicleStatusControl(this);
        }

        public void initialiseRentControl()
        {
            this.rentControl = new RentVehicleControl(this);
        }

        public void closeUseCase(EnquireVehicleStatusControl enquiryControl)
        {

        }

        public void closeUseCase(RentVehicleControl rentControl)
        {

        }
    }
}
