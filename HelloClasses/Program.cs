using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloClasses
{
    public class Program
    {
        public static void Main(string[] args)
        {
            HelloWorld hello = new HelloWorld();
            hello.SayHello();

            Console.ReadLine();
        }
    }
}
