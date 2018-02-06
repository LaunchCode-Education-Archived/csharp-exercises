using System;

namespace MilesPerGallon
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many miles have you traveled?");
            int miles = int.Parse(Console.ReadLine());
            Console.WriteLine("How many gallons of gas have you consumed?");
            int gallons = int.Parse(Console.ReadLine());
            float milesPerGallon = miles / gallons;
            Console.WriteLine("You gotten " + milesPerGallon + " miles per gallon.");
            Console.ReadLine();
        }
    }
}
