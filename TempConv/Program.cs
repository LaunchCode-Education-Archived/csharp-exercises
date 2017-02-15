using System;
using System.Collections.Generic;

namespace TempConv
{
    class Program
    {
        static void Main(string[] args)
        {
            double fahrenheit;
            double celcius;
            string input;

            Console.WriteLine("Tempperature in F:");
            input = Console.ReadLine();
            fahrenheit = double.Parse(input);

            string str = "asdf";
            foreach (char c in str)
            {
                Console.WriteLine(c);
            }

            celcius = (fahrenheit - 32) * 5 / 9;
            Console.WriteLine("The Temperature in C is: " + celcius);
            Console.ReadLine();
        }
    }
}
