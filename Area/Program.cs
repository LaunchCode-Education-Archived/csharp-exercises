using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Radius: ");
            string input = Console.ReadLine();
            double radius = double.Parse(input);

            double area = 3.14 * radius * radius;

            Console.WriteLine("The area of a circle of radius " + radius + " is " + area);
            Console.ReadLine();
        }
    }
}
