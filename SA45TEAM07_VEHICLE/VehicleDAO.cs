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
        public const int CAR = 0;
        public const int TRUCK = 1;
        public const int BUS = 2;

        SqlConnection cn;
        SqlCommand cmSelCarbyPK;
        SqlCommand cmSelTruckbyPK;
        SqlCommand cmSelBusbyPK;
        SqlCommand cmSelCarAvailable;
        SqlCommand cmSelTruckAvailable;
        SqlCommand cmSelBusAvailable;
        SqlCommand cmSelCategory;

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
            cmSelCarbyPK = new SqlCommand();
            cmSelTruckbyPK = new SqlCommand();
            cmSelBusbyPK = new SqlCommand();

            cmSelCarAvailable = new SqlCommand();
            cmSelTruckAvailable = new SqlCommand();
            cmSelBusAvailable = new SqlCommand();

            cmSelCategory = new SqlCommand();


            cmSelCarbyPK.CommandText = "SELECT PlateNum, Category, Model, Color, EngineSN, Status" 
                + "FROM VehiclePlateNum, Car WHERE VehiclePlateNum.PlateNum = Car.CarPlateNum" 
                + "AND VehiclePlateNum.PlateNum = @platenum";
            cmSelCarbyPK.Connection = cn;

            cmSelTruckbyPK.CommandText = "SELECT PlateNum, Category, Model, Color, EngineSN, Status"
                + "FROM VehiclePlateNum, Truck WHERE VehiclePlateNum.PlateNum = Truck.TruckPlateNum"
                + "AND VehiclePlateNum.PlateNum = @PlateNum";
            cmSelTruckbyPK.Connection = cn;

            cmSelBusbyPK.CommandText = "SELECT PlateNum, Category, Model, Color, EngineSN, Status"
                + "FROM VehiclePlateNum, Bus WHERE VehiclePlateNum.PlateNum = Bus.BusPlateNum"
                + "AND VehiclePlateNum.PlateNum = @PlateNum";
            cmSelBusbyPK.Connection = cn;

            cmSelCarAvailable.CommandText = "SELECT * FROM Car WHERE Status = 'Available'";
            cmSelCarAvailable.Connection = cn;

            cmSelTruckAvailable.CommandText = "SELECT * FROM Truck WHERE Status = 'Available'";
            cmSelTruckAvailable.Connection = cn;

            cmSelBusAvailable.CommandText = "SELECT * FROM Bus WHERE Status = 'Available'";
            cmSelBusAvailable.Connection = cn;

            cmSelCategory.CommandText = "SELECT Category From VehicleCategory";
            cmSelCategory.Connection = cn;
        }

        public static VehicleDAO Instance
        {
            get
            {
                if (dbInstance == null)
                {
                    dbInstance = new VehicleDAO();
                }

                return dbInstance;
            }
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

        public Vehicle RetrieveVehicle(string plateNum)
        {
            SqlParameter pPlateNum = new SqlParameter("@PlateNum", SqlDbType.NVarChar, 7);
            pPlateNum.Value = plateNum;

            // clear any previous parameters set before adding new parameters
            cmSelCarbyPK.Parameters.Clear();
            cmSelCarbyPK.Parameters.Add(pPlateNum);

            Vehicle v = new Vehicle();

            // execute reader
            SqlDataReader rd = cmSelCarbyPK.ExecuteReader();
            if (rd.Read())
            {
                v.Model = rd["Model"].ToString();
                v.PlateNum = rd["PlateNum"].ToString();
                v.Color = rd["Color"].ToString();
                v.EngineSN = rd["EngineSN"].ToString();
            }
            else
            {
                throw new VehicleException(VehicleMessage.VehicleRecordNotFound);
            }

            // close reader
            rd.Close();
            return v;

        }

        public List<string> RetrieveCategoryList()
        {
            SqlDataAdapter adapter = new SqlDataAdapter(cmSelCategory);

            List<string> output = new List<string>();
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            DataTable table = ds.Tables[0];
            output = table.AsEnumerable().Select(x => x.Field<string>("Category")).ToList();

            return output;
        }

        [STAThread]
        static void Main(string[] args)
        {
            VehicleDAO vehicleDAO = VehicleDAO.Instance;
            vehicleDAO.OpenConnection();

            Vehicle v = vehicleDAO.RetrieveVehicle("BSS031E");
            vehicleDAO.CloseConnection();


            Console.WriteLine(v.PlateNum);
            Console.ReadLine();
        }
    }
}
