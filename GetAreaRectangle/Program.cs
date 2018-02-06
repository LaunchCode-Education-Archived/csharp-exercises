using System;

namespace GetAreaRectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lets get the area of that rectangle! What is the Length?");
            int length = int.Parse(Console.ReadLine());
            Console.WriteLine("And what is the width?");
            int width = int.Parse(Console.ReadLine());
            Console.WriteLine("The Area of that rectangle is: " + (length * width) + "!");
            Console.ReadLine();
        }
    }
}
