using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilesPerGallon
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This will calculate miles-per-gallon");
            Console.WriteLine("How many miles have you driven?");
            double miles = Double.Parse(Console.ReadLine());
            Console.WriteLine("How many gallons of gas has your vehicle consumed?");
            double gallons = Double.Parse(Console.ReadLine());
            Console.WriteLine("Your miles-per-gallon are: " + (miles / gallons));
            Console.ReadLine();
        }
    }
}
