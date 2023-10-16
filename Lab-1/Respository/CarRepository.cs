using CarManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace CarManagement
{
    public class CarRepository : ICarRepository
    {
        public void DeleteCar(int carId) => CarDBContext.Instance.Remove(carId);

        public Car GetCarByID(int carId) => CarDBContext.Instance.GetCarById(carId);

        public IEnumerable<Car> GetCars() => CarDBContext.Instance.GetCarList;

        public void InsertCar(Car car) => CarDBContext.Instance.AddNew(car);

        public void UpdateCar(Car car) => CarDBContext.Instance.Update(car);

        public IEnumerable<Car> SearchCar(Car car) => CarDBContext.Instance.SearchCar(car);
    }
}
