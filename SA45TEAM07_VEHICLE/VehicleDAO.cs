using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SA45TEAM07_VEHICLE
{
    class VehicleDAO
    {
        SqlConnection cn;
        SqlCommand cmInsert;
        SqlCommand cmSelbyPK;
        SqlCommand cmSelCountbyPK;
        SqlCommand cmSelAll;

        private static VehicleDAO dbInstance;

        private VehicleDAO()
        {
            string strCN = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                           @"AttachDbFilename =|DataDirectory|VehicleRental.mdf;" +
                           @"Integrated Security = true";

            cn = new SqlConnection(strCN);

            InitializeSQLCmd();
        }

        private void InitializeSQLCmd()
        {
            throw new NotImplementedException();
        }

        private static VehicleDAO getInstance()
        {
            if(dbInstance == null)
            {
                dbInstance = new VehicleDAO();
            }

            return dbInstance;
        }

        public void openConnection()
        {
            cn.Open();
        }
        public void CloseConnection()
        {
            if (cn != null)
                cn.Close();
        }

    }
}
