using System;

namespace Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius, area, pi;
            pi = 3.14;            
            Console.WriteLine("Enter a radius: ");
            radius = double.Parse(Console.ReadLine());
            area = pi * radius * radius;
            Console.WriteLine("The area of a circle with radius " + radius + " is " + area);
            Console.ReadLine();
                        
        }
    }
}
