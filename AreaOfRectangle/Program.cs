using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOfRectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This will calculate the area of a rectangle");
            Console.WriteLine("What is the height of the rectangle?");
            double height = Double.Parse(Console.ReadLine());
            Console.WriteLine("What is the width of the rectangle?");
            double width = Double.Parse(Console.ReadLine());
            Console.WriteLine("The area is: " + (height * width));
            Console.ReadLine();
        }
    }
}
