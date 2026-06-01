using SQLite;
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
        [AutoIncrement,PrimaryKey]
        public int Id { get; set; }
        public string FelhasznaloNev { get; set; }
        public string Email { get; set; }
        public string Jelszo { get; set; }
        public string Szerep { get; set; }

        public User(string felhasznaloNev, string email, string password, string role)
        {
            FelhasznaloNev = felhasznaloNev;
            Email = email;
            Jelszo = password;
            Szerep = role;
        }
    }
}
