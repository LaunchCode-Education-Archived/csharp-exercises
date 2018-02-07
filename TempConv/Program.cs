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

            Console.WriteLine("Tempperature in F:");
            fahrenheit = double.Parse(Console.ReadLine());
           

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
