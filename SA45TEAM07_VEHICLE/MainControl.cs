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
            if (portalUI == null)
            {
                portalUI = new FormMain(this);
                portalUI.displayPortalUI();
            }
        }

        public FormMain PortalUI
        {
            get
            {
                return portalUI;
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

        public void InitialiseEnquiryControl()
        {
            if(this.enquiryControl == null)
            {
                this.enquiryControl = new EnquireVehicleStatusControl(this);
            }
        }

        public void InitialiseRentControl()
        {
            if (this.rentControl == null)
            {
                this.rentControl = new RentVehicleControl(this);
            }
        }

        public void CloseUseCase(EnquireVehicleStatusControl enquiryControl)
        {
            enquiryControl.Destroy();
            this.enquiryControl = null;
        }

        public void CloseUseCase(RentVehicleControl rentControl)
        {
            rentControl.Destroy();
            this.rentControl = null;
        }
    }
}
