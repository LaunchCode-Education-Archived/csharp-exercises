using System;

namespace TempConv
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tempperature in F:");
            string input = Console.ReadLine();
            double fahrenheit = double.Parse(input);

            double celcius = (fahrenheit - 32) * 5 / 9;
            Console.WriteLine("The Temperature in C is: " + celcius);
            Console.ReadLine();
        }
    }
}
