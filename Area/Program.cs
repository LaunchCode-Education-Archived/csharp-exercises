using System;

namespace Area
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter an radius: ");
            string input = Console.ReadLine();
            double radius = double.Parse(input);

            double area = 3.14 * radius * radius;

            Console.WriteLine("The area of circle of radius " + radius + " is: " + area);

            Console.ReadLine();
        }
    }
}
