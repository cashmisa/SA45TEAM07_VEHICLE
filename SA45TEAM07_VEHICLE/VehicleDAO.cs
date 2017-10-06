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
        const int CAR = 0;
        const int TRUCK = 1;
        const int BUS = 2;

        SqlConnection cn;
        SqlCommand cmInsert;
        SqlCommand cmSelbyPK;
        SqlCommand cmSelCountbyPK;
        SqlCommand cmSelCarAvailable;
        SqlCommand cmSelTruckAvailable;
        SqlCommand cmSelBusAvailable;

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
            cmSelCarAvailable.CommandText = "SELECT FROM ";
        }

        private static VehicleDAO getInstance()
        {
            if(dbInstance == null)
            {
                dbInstance = new VehicleDAO();
            }

            return dbInstance;
        }

        public void OpenConnection()
        {
            cn.Open();
        }
        public void CloseConnection()
        {
            if (cn != null)
                cn.Close();
        }

        public DataTable RetrieveAvailableCarList()
        {
            SqlDataAdapter adapter = new SqlDataAdapter(cmSelCarAvailable);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "Cars");

            return ds.Tables["Cars"];
        }

        public DataTable RetrieveAvailableTruckList()
        {
            SqlDataAdapter adapter = new SqlDataAdapter(cmSelTruckAvailable);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "Trucks");

            return ds.Tables["Trucks"];
        }

        public DataTable RetrieveAvailableBusList()
        {
            SqlDataAdapter adapter = new SqlDataAdapter(cmSelBusAvailable);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "Buses");

            return ds.Tables["Buses"];
        }

        public DataTable RetrievAvailableVehicleList(int type)
        {
            string tableName = "";
            SqlDataAdapter adapter = null;
            switch (type)
            {
                case CAR:
                    tableName = "Cars";
                    adapter = new SqlDataAdapter(cmSelCarAvailable);
                    break;
                case TRUCK:
                    tableName = "Trucks";
                    adapter = new SqlDataAdapter(cmSelTruckAvailable);
                    break;
                case BUS:
                    tableName = "Buses";
                    adapter = new SqlDataAdapter(cmSelBusAvailable);
                    break;
                default:
                    return null;
            }

            DataSet ds = new DataSet();
            adapter.Fill(ds, tableName);

            return ds.Tables[tableName];
        }
    }
}
