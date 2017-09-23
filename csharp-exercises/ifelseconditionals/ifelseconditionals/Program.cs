using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifelseconditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a grade");
            double grade = double.Parse(Console.ReadLine());


             
            if (grade<60)
            {
                Console.WriteLine("F");
            }
            else if (grade<70)
            {
                Console.WriteLine("D");
            }
            else if (grade < 80)
            {
                Console.WriteLine("C");
            }
            else if (grade < 90)
            {
                Console.WriteLine("B");
            }
            else
            {
                Console.WriteLine("A");
            }
            Console.ReadLine();
        }
    }
}
