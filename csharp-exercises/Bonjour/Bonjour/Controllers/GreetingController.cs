using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Bonjour.Controllers
{
    public class GreetingController : Controller
    {
        // GET: /<controller>/
        [HttpGet]
        public IActionResult Index()
        {
            string form;

            form = String.Concat("<form method='post'>", "<input type='text' name ='this_name' placeholder='What is your name?'>",
                "<select name='lang'>", "<option value='en'>English</option>", "<option value='fr'>French</option>",
                "<option value='sp'>Spanish</option>", "<option value='sb'>Steve Lang</option>",
                "<select>" ,"<button type='submit'>Greet!</button>", "</form>");

            return Content(form, "text/html" );
        }
        [Route("/greeting")]
        [HttpPost]
        public IActionResult GreetUser(string this_name, string lang)
        {
            string greeting;
            greeting = "Hello";
            
            if (lang == "fr")
            {
                greeting = "Bonjour";
            }
            else if (lang == "sp")
            {
                greeting = "Hola";
            }
            else if (lang == "Steve Lang")
            {
                greeting = "Was' popin' Woedi";
            }
            
            /*
            switch (lang)
            {
                case "en":
                    greeting = "Good Morning";
                    break;
                case "fr":
                    greeting = "Bonjour";
                    break;
                case "sp":
                    greeting = "Hola!";
                    break;
                case "Steve Lang":
                    greeting = "Wassup Dawg";
                    break;
                default:
                    greeting = "Hello";
                    break;
            }
            */
            return Content(String.Concat(greeting," ",this_name), "text/html");
        }
    }
}
