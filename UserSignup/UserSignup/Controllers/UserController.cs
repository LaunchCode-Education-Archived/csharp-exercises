using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserSignup.Models;

namespace UserSignup.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index(List<User> users)
        {
            users = UserData.GetAll() ;
            if (users == null)
            {
                List<User> theUsers = new List<User>();
                return View(theUsers);
            }
            else
            {
                return View(users);
            }
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View(new User());
        }

        [HttpPost]
        public IActionResult Add(User user, string verify)
        {
            bool emailVal = UserData.IsValidEmail(user.Email);
            bool usernameVal = UserData.IsValidUserName(user.Username);
            if (user.Password == verify && !String.IsNullOrEmpty(user.Password) && usernameVal == true)
            {
                List<User> users = UserData.GetAll();
                users.Add(user);
                return RedirectToAction("Index", users);
            }
            else
            {
                ViewBag.PasswordError = user.Password != verify ? "Your passwords must match" : "";
                ViewBag.UsernameError = !usernameVal ? "You must enter a valid username (all letters, 5 to 15 characters" : "";
                return View(user);
            }
        }
        
    }
}
