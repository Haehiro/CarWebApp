using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace CarWebApp.Controllers
{
    public class CarController : Controller
    {

        private readonly CarService _carService;

        public CarController()
        {
            _carService = new CarService();
        }

        public async Task<ActionResult> Index()
        {
            var cars= await _carService.GetCars();

            return View(cars);
        }

        public ActionResult AddCar()
        {
            return View();
        }

        public ActionResult EditCar()
        {
            return View();
        }

        public ActionResult DeleteCar()
        {
            return RedirectToAction("Index");
        }
    }
}