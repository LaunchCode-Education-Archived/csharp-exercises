using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserSignup.Models
{
    public class User
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int UserId { get; set; }

        public User(string username, string email, string password)
        {
            Email = email;
            Username = username;
            Password = password;

        }

        public User() { }
    }
}
