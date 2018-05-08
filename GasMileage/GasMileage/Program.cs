using System;

namespace GasMileage
{
    class Program
    {
        static void Main(string[] args)
        {
            double miles, gallons, milesPerGallon;

            Console.Write("Enter number of miles: ");
            miles = double.Parse(Console.ReadLine());
            Console.Write("Enter number of gallons used: ");
            gallons = double.Parse(Console.ReadLine());

            milesPerGallon = miles / gallons;

            Console.WriteLine("Your gas mileage is " + milesPerGallon + " miles per gallon.");
            Console.ReadLine();

        }
    }
}
