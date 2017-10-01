using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApp.Models
{
    public class Motorcycle : Vehicle
    {
        public Motorcycle(string brand, string color, int tires = 2 )
        {
            this.Brand = brand;
            this.Color = color;
            this.Tires = tires;
        }
    }
}
