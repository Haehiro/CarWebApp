using CarWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace CarWebApp
{
    public class CarService
    {
        private readonly CarRepository _carRepository;

        public CarService()
        {
            _carRepository = new CarRepository();
        }

        public async Task<List<Car>> GetCars()
        {
            return await _carRepository.GetCars();
        }
    }
}