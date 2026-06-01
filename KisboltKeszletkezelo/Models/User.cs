using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KisboltKeszletkezelo.Models
{
    public class User
    {

        public User()
        {
        }
        public int Id { get; set; }
        public string FelhasznaloNev { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }

        public User(string felhasznaloNev, string email, string password, string role)
        {
            FelhasznaloNev = felhasznaloNev;
            Email = email;
            Password = password;
            Role = role;
        }
    }
}
