using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace SA45TEAM07_VEHICLE
{
    class VehicleUtility
    {
        public static bool isVehiclePlateValid(string plateNum)
        {
            //(?i) = case insensitive; match CC or TT; [0 to 9] 4 times, [a to z] 1 times OR match BSS[0 to 9] 3 times, [a to z] 1 times
            Regex regex = new Regex(@"(^(?i)(CC|TT)[0-9]{4}[A-Za-z]{1}$)|(^(?i)(BSS)[0-9]{3}[A-Za-z]{1}$)");
            Match match = regex.Match(plateNum);
            if (match.Success)
                return true;
            else
                return false;
        }



    }
}
