using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace CarManagement
{
    public class CarDBContext
    {
		private readonly string connectionString;

		private readonly IConfiguration _configuration = new ConfigurationBuilder()
		.SetBasePath(Directory.GetCurrentDirectory())
		.AddJsonFile("appsettings.json")
		.Build();
        private static List<Car> CarList;


		public CarDBContext()
        {

			CarList = GetAllCars();
	    }

        

		/*private static List<Car> CarList = new List<Car>()
        {
             new Car
            {
                CarImg = "images/mercedes.jpeg",
                CarID = 1,
                CarName = "Mercedes",
                Manufacturer = "Honda",
                CarDescription = "- Color: Orange\n- Transmission: Automatic\n- Fuel Type: Hybrid\n- Engine size: 3",
                Price = 30000,
                ReleaseYear = 2021
            },
            new Car
            {
                CarImg = "images/audi.jpeg",
                CarID = 2,
                CarName = "A6",
                Manufacturer = "Audi",
                CarDescription = "- Color: Black\n- Transmission: Automatic\n- Fuel Type: Hybrid\n- Engine size: 3",
                Price = 3000000,
                ReleaseYear = 2020

            },
            new Car
            {
                CarImg = "images/bmw.jpeg",
                CarID = 3,
                CarName = "A10",
                Manufacturer = "BMW",
                CarDescription = "- Color: Black\n- Transmission: Automatic\n- Fuel Type: Hybrid\n- Engine size: 3",
                Price = 3000000,
                ReleaseYear = 2020

            },
            new Car
            {
                CarImg = "images/ford.jpeg",
                CarID = 4,
                CarName = "Yam",
                Manufacturer = "Ford",
                CarDescription = "- Color: Orange\n- Transmission: Manual\n- Fuel Type: Diesel\n- Engine size: 2",
                Price = 3000000,
                ReleaseYear = 2020

            }
        };*/




		public List<Car> GetAllCars()
		{
			List<Car> Cars = new List<Car>();
            string s = _configuration["ConnectionStrings:DefaultConnection"];
			using (SqlConnection connection = new SqlConnection(_configuration["ConnectionStrings:DefaultConnection"]))
			{
				connection.Open();

				string query = "SELECT * FROM Cars";
				SqlCommand command = new SqlCommand(query, connection);

				using (SqlDataReader reader = command.ExecuteReader())
				{
					while (reader.Read())
					{
						Car Car = new Car
						{
							CarID = Convert.ToInt32(reader["CarID"]),
							CarName = reader["CarName"].ToString(),
							CarImg = reader["CarImg"].ToString(),
							Manufacturer = reader["Manufacturer"].ToString(),
							CarDescription = reader["CarDescription"].ToString(),
							Price = int.Parse(reader["Price"].ToString()),
							ReleaseYear = int.Parse(reader["ReleaseYear"].ToString())
						};

						Cars.Add(Car);
					}
				}
			}
			return Cars;
		}


        private static CarDBContext instance = null;
        public static readonly object instanceLook = new object();
        public static CarDBContext Instance
        {
            get
            {
                lock (instanceLook)
                {
                    if (instance == null)
                    {
                        instance = new CarDBContext();
                    }
                    return instance;
                }
            }
        }

        public List<Car> GetCarList => CarList;
        public Car GetCarById(int carID)
        {
            Car car = CarList.SingleOrDefault(pro => pro.CarID == carID);
            return car;
        }

        public List<Car> SearchCar(Car car)
        {
            IQueryable<Car> query = CarList.AsQueryable();
            try
            {
                if (car.CarID != 0)
                {
                    query = query.Where(x => x.CarID == car.CarID);
                }
                if (!string.IsNullOrEmpty(car.CarName))
                {
                    query = query.Where(x => x.CarName.Contains(car.CarName, StringComparison.CurrentCultureIgnoreCase));
                }
                if (!string.IsNullOrEmpty(car.Manufacturer))
                {
                    query = query.Where(x => x.Manufacturer.Contains(car.Manufacturer, StringComparison.CurrentCultureIgnoreCase));
                }
                if (car.Price != 0)
                {
                    query = query.Where(x => x.Price >= car.Price);
                }
                if (car.ReleaseYear != 0)
                {
                    query = query.Where(x => x.ReleaseYear >= car.ReleaseYear);
                }
                if (query.ToList().Count == 0) { throw new Exception("Not found!!!"); }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return query.ToList<Car>();
        }
        public void AddNew(Car car)
        {
            Car pro = GetCarById(car.CarID);
            if (pro == null)
            {
                CarList.Add(car);
            }
            else
            {
                throw new Exception("Car is already exists!");
            }
        }
        public void Update(Car car)
        {
            Car c = GetCarById(car.CarID);
            if (c != null)
            {
                var ind = CarList.IndexOf(c);
                CarList[ind] = car;
            }
            else
            {
                throw new Exception("Car does not already exists!");
            }
        }

        public void Remove(int CarID)
        {
            Car p = GetCarById(CarID);
            if (p != null)
            {
                CarList.Remove(p);
            }
            else
            {
                throw new Exception("Car does not already exists!");
            }
        }

    }
}
