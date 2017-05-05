using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Temperature
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Temperature temp = new Temperature();
            temp.Fahrenheit = 32;

            Console.WriteLine(temp.Celsius);
            Console.WriteLine(temp.Fahrenheit);
            Console.ReadLine();
        }
    }
}
