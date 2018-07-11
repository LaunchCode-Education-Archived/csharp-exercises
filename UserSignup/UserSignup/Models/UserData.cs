using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserSignup.Models
{
    public class UserData
    {
        static private List<User> users = new List<User>();
        

        //get all
        public static List<User> GetAll()
        {
            return users;
        }


        //Add all
        public static void AddUser(User newUser)
        {
            users.Add(newUser);
        }


        //get user by id  
        public static User GetUserById(int id)
        {
            return users.Single(x => x.UserId == id);
        }

        public static bool IsValidEmail(string email)
        {
            var foo = new EmailAddressAttribute();
            bool bar;
            bar = foo.IsValid(email);
            return bar;
        }

        public static bool IsValidUserName(string uname)
        {

            //regex tests whether a string includes all letters
            if ((uname.Length >= 5 && uname.Length <= 15) && (Regex.IsMatch(uname, @"^[a-zA-Z]+$")))
            {
                return true;
            }

            return false;
        }



    }
}