using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyApp.Models;

namespace MyApp.Controllers
{
    public class HomeController : Controller
    {
        List<Vehicle> allVehicles = new List<Vehicle>();

        public IActionResult Index()
        {
            bool hasTesla;

            foreach(Vehicle v in allVehicles)
            {
                if (allVehicles.Equals(v))
                {
                    hasTesla = true;
                    break;
                }
            }
            ViewBag.objInAllVehicles = allVehicles;
            return View();
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(string vehicletype, string brand, string color)
        {
            if (vehicletype == "car")
            {
                Vehicle newVehicle = new Car(brand, color);
                allVehicles.Add(newVehicle);
            }
            else
            {
                Vehicle newVehicle = new Motorcycle(brand, color);
                allVehicles.Add(newVehicle)
            }
            return Redirect("/Home");
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
