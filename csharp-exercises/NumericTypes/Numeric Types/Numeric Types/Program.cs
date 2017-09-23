using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numeric_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-This program calculates the area of a rectangle-".ToUpper());
            Console.WriteLine();

            int length, width;

            string input1, input2;

            Console.WriteLine("What is the length of your rectangle?");
            
            input1 = Console.ReadLine();
            length = int.Parse(input1);

            Console.WriteLine("What is the width of your rectangle?");

            input2 = Console.ReadLine();
            width = int.Parse(input2);

            Console.WriteLine("The area of a rectangle of length {0} and width {1} is : {2}.", length, width, (length*width));
            Console.ReadLine();


        }
    }
}
