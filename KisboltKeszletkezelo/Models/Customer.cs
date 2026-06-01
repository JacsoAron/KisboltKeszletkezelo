using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KisboltKeszletkezelo.Models
{
    public class Customer
    {
        public Customer()
        {
        }
        [AutoIncrement, PrimaryKey]
        public int Id { get; set; } 
        public string Varos { get; set; }
        public string Orszag { get; set; }
        public string TelefonSzam { get; set; }
        public string Nev {  get; set; }

        public Customer(string varos, string orszag, string telefonSzam, string nev)
        {
            Varos = varos;
            Orszag = orszag;
            TelefonSzam = telefonSzam;
            Nev = nev;
        }
    }
}
