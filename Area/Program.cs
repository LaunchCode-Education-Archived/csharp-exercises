using System;

namespace Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius;
            double x;
            double y;
            double radiusSquared;
            double pi;
            double area;
            Console.WriteLine("Enter a radius:");
            radius = double.Parse(Console.ReadLine());
            if (radius <= 0)
            {
                x = 0;
                do
                {
                    x = 0;
                    Console.WriteLine("Invalid integer...Please enter a number greater than 0:");
                    y = double.Parse(Console.ReadLine());
                    x += y;
                } while (x <= 0);
                radius = x;
            }
            radiusSquared = (radius * radius);
            pi = 3.14;
            area = (pi * radiusSquared);
            Console.WriteLine("The area of a circle with radius " + radius + " is: " + area);
            Console.ReadLine();
        }
    }
}
