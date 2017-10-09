using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SA45TEAM07_VEHICLE
{
    public class VehicleDAO
    {
        public const int CAR = 0;
        public const int TRUCK = 1;
        public const int BUS = 2;

        SqlConnection cn;
        SqlCommand cmSelCarByPK;
        SqlCommand cmSelTruckByPK;
        SqlCommand cmSelBusByPK;
        SqlCommand cmSelVehicleByPK;
        SqlCommand cmSelCarAvailable;
        SqlCommand cmSelTruckAvailable;
        SqlCommand cmSelBusAvailable;
        SqlCommand cmSelCategory;
        SqlCommand cmUpdateCarStatus;
        SqlCommand cmUpdateTruckStatus;
        SqlCommand cmUpdateBusStatus;

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
            cmSelCarByPK = new SqlCommand();
            cmSelTruckByPK = new SqlCommand();
            cmSelBusByPK = new SqlCommand();
            cmSelVehicleByPK = new SqlCommand();

            cmSelCarAvailable = new SqlCommand();
            cmSelTruckAvailable = new SqlCommand();
            cmSelBusAvailable = new SqlCommand();

            cmSelCategory = new SqlCommand();
            cmUpdateCarStatus = new SqlCommand();
            cmUpdateTruckStatus = new SqlCommand();
            cmUpdateBusStatus = new SqlCommand();

            cmSelCarByPK.CommandText = "SELECT PlateNum, Category, Model, Color, EngineSN, Status"
                + " FROM VehiclePlateNum, Car WHERE VehiclePlateNum.PlateNum = Car.CarPlateNum"
                + " AND VehiclePlateNum.PlateNum = @Platenum";
            cmSelCarByPK.Connection = cn;

            cmSelTruckByPK.CommandText = "SELECT PlateNum, Category, Model, Color, EngineSN, Status"
                + " FROM VehiclePlateNum, Truck WHERE VehiclePlateNum.PlateNum = Truck.TruckPlateNum"
                + " AND VehiclePlateNum.PlateNum = @PlateNum";
            cmSelTruckByPK.Connection = cn;

            cmSelBusByPK.CommandText = "SELECT PlateNum, Category, Model, Color, EngineSN, Status"
                + " FROM VehiclePlateNum, Bus WHERE VehiclePlateNum.PlateNum = Bus.BusPlateNum"
                + " AND VehiclePlateNum.PlateNum = @PlateNum";
            cmSelBusByPK.Connection = cn;

            cmSelVehicleByPK.CommandText = cmSelCarByPK.CommandText + " UNION "
                + cmSelTruckByPK.CommandText + " UNION "
                + cmSelCarByPK.CommandText + " AND VehiclePlateNum.PlateNum = @PlateNum";
            cmSelVehicleByPK.Connection = cn;

            cmSelCarAvailable.CommandText = "SELECT * FROM Car WHERE Status = 'Available'";
            cmSelCarAvailable.Connection = cn;

            cmSelTruckAvailable.CommandText = "SELECT * FROM Truck WHERE Status = 'Available'";
            cmSelTruckAvailable.Connection = cn;

            cmSelBusAvailable.CommandText = "SELECT * FROM Bus WHERE Status = 'Available'";
            cmSelBusAvailable.Connection = cn;

            cmSelCategory.CommandText = "SELECT Category From VehicleCategory";
            cmSelCategory.Connection = cn;

            cmUpdateCarStatus.CommandText = "UPDATE Car SET Status = 'Rented Out' WHERE CarPlateNum = @PlateNum";
            cmUpdateCarStatus.Connection = cn;

            cmUpdateTruckStatus.CommandText = "UPDATE Truck SET Status = 'Rented Out' WHERE TruckPlateNum = @PlateNum";
            cmUpdateTruckStatus.Connection = cn;

            cmUpdateBusStatus.CommandText = "UPDATE Bus SET Status = 'Rented Out' WHERE BusPlateNum = @PlateNum";
            cmUpdateBusStatus.Connection = cn;
        }

        public void UpdateVehicleStatus(Vehicle rentedVehicle)
        {
            //rentedVehicle.category = name of the table to be retrieved;
            //rentedVehicle.plateNum = plateNum
            SqlParameter pPlateNum = new SqlParameter("@PlateNum", SqlDbType.NVarChar, 7);
            pPlateNum.Value = rentedVehicle.PlateNum;

            switch (rentedVehicle.Category)
            {
                case "Car":
                    cmUpdateCarStatus.Parameters.Clear();
                    cmUpdateCarStatus.Parameters.Add(pPlateNum);
                    cmUpdateCarStatus.ExecuteNonQuery();
                    break;
                case "Truck":
                    cmUpdateTruckStatus.Parameters.Clear();
                    cmUpdateTruckStatus.Parameters.Add(pPlateNum);
                    cmUpdateTruckStatus.ExecuteNonQuery();
                    break;
                case "Bus":
                    cmUpdateBusStatus.Parameters.Clear();
                    cmUpdateBusStatus.Parameters.Add(pPlateNum);
                    cmUpdateBusStatus.ExecuteNonQuery();
                    break;
                default:
                    break;
            }
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
            SqlParameter pVehiclePlateNum = new SqlParameter("@PlateNum", SqlDbType.NVarChar, 7);
            pVehiclePlateNum.Value = plateNum;

            cmSelVehicleByPK.Parameters.Clear();
            cmSelVehicleByPK.Parameters.Add(pVehiclePlateNum);

            Vehicle v = new Vehicle();

            SqlDataReader rdVehicle = cmSelVehicleByPK.ExecuteReader();
            if (rdVehicle.Read())
            {
                v.Model = rdVehicle["Model"].ToString();
                v.PlateNum = rdVehicle["PlateNum"].ToString();
                v.Color = rdVehicle["Color"].ToString();
                v.EngineSN = rdVehicle["EngineSN"].ToString();
                v.Status = rdVehicle["Status"].ToString();
                v.Category = rdVehicle["Category"].ToString();
            }
            else
            {
                throw new VehicleException(VehicleMessage.VehicleRecordNotFound);
            }

            rdVehicle.Close();
            return v;
        }

        public Car RetrieveCar(string plateNum)
        {
            SqlParameter pCarPlateNum = new SqlParameter("@PlateNum", SqlDbType.NVarChar, 7);
            pCarPlateNum.Value = plateNum;

            //clear any previous parameters set before adding new parameters
            cmSelCarByPK.Parameters.Clear();
            cmSelCarByPK.Parameters.Add(pCarPlateNum);

            Car c = new Car();

            // execute reader
            SqlDataReader rdCar = cmSelCarByPK.ExecuteReader();

            if (rdCar.Read())
            {
                c.Model = rdCar["Model"].ToString();
                c.PlateNum = rdCar["PlateNum"].ToString();
                c.Color = rdCar["Color"].ToString();
                c.EngineSN = rdCar["EngineSN"].ToString();
                c.Status = rdCar["Status"].ToString();
                c.Category = rdCar["Category"].ToString();
            }
            else
            {
                throw new VehicleException(VehicleMessage.VehicleRecordNotFound);
            }

            rdCar.Close();
            return c;
        }

        public Truck RetrieveTruck(string plateNum)
        {
            SqlParameter pTruckPlateNum = new SqlParameter("@PlateNum", SqlDbType.NVarChar, 7);
            pTruckPlateNum.Value = plateNum;

            cmSelTruckByPK.Parameters.Clear();
            cmSelTruckByPK.Parameters.Add(pTruckPlateNum);

            Truck t = new Truck();

            SqlDataReader rdTruck = cmSelTruckByPK.ExecuteReader();
            if (rdTruck.Read())
            {
                t.Model = rdTruck["Model"].ToString();
                t.PlateNum = rdTruck["PlateNum"].ToString();
                t.Color = rdTruck["Color"].ToString();
                t.EngineSN = rdTruck["EngineSN"].ToString();
                t.Status = rdTruck["Status"].ToString();
                t.Category = rdTruck["Category"].ToString();
            }
            else
            {
                throw new VehicleException(VehicleMessage.VehicleRecordNotFound);
            }

            rdTruck.Close();
            return t;
        }

        public Bus RetrieveBus(string plateNum)
        {
            SqlParameter pBusPlateNum = new SqlParameter("@PlateNum", SqlDbType.NVarChar, 7);
            pBusPlateNum.Value = plateNum;

            cmSelBusByPK.Parameters.Clear();
            cmSelBusByPK.Parameters.Add(pBusPlateNum);

            Bus b = new Bus();

            SqlDataReader rdBus = cmSelBusByPK.ExecuteReader();
            if (rdBus.Read())
            {
                b.Model = rdBus["Model"].ToString();
                b.PlateNum = rdBus["PlateNum"].ToString();
                b.Color = rdBus["Color"].ToString();
                b.EngineSN = rdBus["EngineSN"].ToString();
                b.Status = rdBus["Status"].ToString();
                b.Category = rdBus["Category"].ToString();
            }
            else
            {
                throw new VehicleException(VehicleMessage.VehicleRecordNotFound);
            }

            rdBus.Close();
            return b;
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

            Vehicle v = vehicleDAO.RetrieveVehicle("BSS671Z");
            vehicleDAO.CloseConnection();

            Console.WriteLine(v.PlateNum);
            Console.ReadLine();
        }
    }
}
