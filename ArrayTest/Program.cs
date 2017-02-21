using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ArrayList = { 1, 1, 2, 3, 5, 8 };

            foreach (int value in ArrayList)
            {
                Console.WriteLine(value);
                Console.ReadLine();
            }
        }
    }
}
