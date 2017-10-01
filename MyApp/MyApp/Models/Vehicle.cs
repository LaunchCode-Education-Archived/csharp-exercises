using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApp.Models
{
    public abstract class Vehicle
    {
        // Abstract means never going to instance a Vehicle object!! Never ever!!
        // Don't WORK =>Vehicle v1 = new Vehicle();

        //Write a piece of code and explain something!!!!

        public string Brand { get; protected set; }

        //You can only modify the Brand within Vehicle, Car or Motorcycle

        public string Color { get; set; }
        //I want them to get the year but not be able to set the year of the child classes
        public int Year { get; }
        public int Tires { get; protected set; }

        private bool ignition = false;
        bool Ignition
        {
            get { return ignition; }
            set { ignition = value; }
        }
        // Creating share action  common to both Motorcycle and Car

        // Lambda constructor => public Vehicle() { }
        
        public Vehicle(int tires, string color, string brand)
        {
            this.Tires = tires;
            this.Color = color;
            this.Brand = brand;
        }

        public override string ToString()
        {
            return base.ToString() + "Override used";
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }


        //Define a static method Now

        






















        public Vehicle (string brand, string color)
        {
            //ToString, gethashcode, getType and Equals
        }

        public Vehicle() { }

       /* public Vehicle():this(brand,"Black",tires){}
        public Vehicle():this(brand,"Black",tires){}

        public Vehicle()
        {
           
        }*/
        public static bool Equals( Vehicle obj)
        {
            return obj.Brand.ToLower() == "tesla";

        }

        var veh1 = Vehicle.First()
        var veh2 = Vehicle.Last()

            veh1 == veh2;
            veh1.Equals(veh2);

            //The first ex
    }
}
