using System;

namespace RectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double length, width, area;                      

            Console.Write("Enter length: ");
            length = double.Parse(Console.ReadLine());
            Console.Write("Enter width: ");
            width = double.Parse(Console.ReadLine());

            area = (length * width);

            Console.WriteLine("The area of a rectangle is " + area);
            Console.ReadLine();

        }
    }
}
