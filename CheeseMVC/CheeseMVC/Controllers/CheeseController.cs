using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CheeseMVC.Controllers
{
    public class CheeseController : Controller
    {
        static private Dictionary<string, string> Cheeses = new Dictionary<string, string>();

        // GET: /<controller>/
        public IActionResult Index()
        {
            ViewBag.cheeses = Cheeses;

            return View();
        }
        // Form Controller
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        // POST method @Add Cheese Form()
        [HttpPost]
        public IActionResult Add(string name, string description)
        {
            // Add the new cheese to existing cheeses
            Cheeses.Add(name, description);
            return Redirect("/Cheese");
        }

        [HttpGet]
        public IActionResult Shred()
        {
            ViewBag.cheeses = Cheeses;
            return View();
        }

        [HttpPost]
        public IActionResult Shred(string name)
        {
            Cheeses.Remove(name);
            return Redirect("/Cheese");
        }
    }
}