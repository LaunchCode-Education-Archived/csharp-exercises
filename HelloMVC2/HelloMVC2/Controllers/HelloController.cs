using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HelloMVC2.Controllers
{
    public class HelloController : Controller
    {

        [HttpGet]
        public IActionResult Goodbye()
        {
            return Content(GetGoodbyeHtml(), "text/html");
        }

        [HttpPost]
        public IActionResult Goodbye(string name, string language)
        {

            return Content(CreateMessage(name, language));
        }

        public static string CreateMessage(string name, string language)
        {
            string greeting;

            if (language == "English")
            {
                greeting = "Hello, " + name;

            }
            else if (language == "Spanish")
            {
                greeting = "Hola, " + name;
            }
            else if (language == "Russian")
            {
                greeting = "Привет, " + name;
            }
            else if (language == "German")
            {
                greeting = "Guten Tag, " + name;
            }
            else
            {
                greeting = "Bonjour, " + name;
            }
            
            return greeting;
        }


        // GET: /<controller>/
        public  string  GetGoodbyeHtml()
        {
            return @"<html><h2>Goodbye</h2>
                <form method='post'>
                    <input type='text' name='name' />
                        <select name='language'>
                        <option value = 'English' selected> English </option>   
                        <option value = 'Spanish'> Spanish </option>         
                        <option value = 'French'> French </option>
                        <option value = 'Russian'> Russian </option>
                        <option value = 'German'> German </option>
                        </select> 
                    <input  type='submit' value='Greet me!'/>
                </form></html>";

            
        }

        
    }
}
