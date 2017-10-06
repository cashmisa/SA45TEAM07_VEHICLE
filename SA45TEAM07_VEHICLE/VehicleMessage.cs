using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SA45TEAM07_VEHICLE
{
    class VehicleMessage
    {
        public const String GeneralErrorMsg
            = "T07001E Services not available. Please contact helpdesk.";

        public const String VehicleRecordNotFound
            = "DFT012E Vehicle record not found.  Please enter another plate number.";

        public const String CustomerRecordNotFound
            = "DFT013E Customer record not found.  Please enter another NRIC/FIN.";

        public const String CustomerRecordSuccessful
            = "DFT099I Rental record successfully created!";

    }
}
