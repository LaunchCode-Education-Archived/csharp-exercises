using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Caesar
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();

            foreach (char c in input.ToCharArray())
            {
                Console.WriteLine((int) c);
            }

            Console.ReadLine();
        }
    }
}
