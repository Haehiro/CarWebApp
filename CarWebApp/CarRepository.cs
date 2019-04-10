using CarWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Linq;

namespace CarWebApp
{
    public class CarRepository
    {
        private static List<Car> _cars;

        public CarRepository()
        {
            _cars = new List<Car> {new Car { Id = 1, Mark = "BMW", Model = "2346", Price = 6065 } };
        }

        public async Task<List<Car>> GetCars()
        {
            return await Task.Run(() => _cars);
        }

        public async Task<Car> GetCar(int id)
        {
            return await Task.Run(() => _cars.FirstOrDefault(f => f.Id == id));
        }

        //public async Task<Car> AddCar(Car car)
        //{
        //    _cars.Add(car);
        //    return 
        //}



    }
}