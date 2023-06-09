using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_Lab_2
{
    public class Owner
    {
        public string Name { get; set; }
        public DateTime Year { get; set; }
        public string Country { get; set; }
        public string[] Types { get; set; }
        public Owner() { }  
        public Owner(string name, DateTime year, string country, string[] types)
        {
            Name = name;
            Year = year;
            Country = country;
            Types = types;
        }
    }
}
