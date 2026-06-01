using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KisboltKeszletkezelo.Models
{
    public class Product
    {
        public Product()
        {
        }
        [AutoIncrement,PrimaryKey]
        public int Id { get; set; }
        public string Nev { get; set; }
        public string Leiras { get; set; }
        public decimal Ar { get; set; }
        public int Mennyiseg { get; set; }

        public Product(string nev, string leiras, decimal ar, int mennyiseg)
        {
            Nev = nev;
            Leiras = leiras;
            Ar = ar;
            Mennyiseg = mennyiseg;
        }
    }
}
