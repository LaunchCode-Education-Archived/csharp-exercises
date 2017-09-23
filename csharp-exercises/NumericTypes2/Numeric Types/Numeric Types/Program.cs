using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numeric_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-This program calculates the miles per gallon of a user vehicle.-".ToUpper());
            Console.WriteLine();

            float miles, gallons;

            string input1, input2;

            Console.WriteLine("How many total miles traveled?");
            
            input1 = Console.ReadLine();
            miles = float.Parse(input1);

            Console.WriteLine("How many total gallons spent?");

            input2 = Console.ReadLine();
            gallons = float.Parse(input2);

            Console.WriteLine("The miles per gallon for user vehicle at {0} miles and {1} gallons is : {2}.", miles, gallons, (miles/gallons));
            Console.ReadLine();
        }
    }
}
