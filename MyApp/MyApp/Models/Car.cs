using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApp.Models
{
    public class Car : Vehicle
    {
        int Doors { get; set; }

        private bool AC = false;

        public Car(string brand, string color, int tires = 4)
        {
            this.Brand = brand;
            this.Color = color;
            this.Tires = tires;
        }
    }
}
