using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloMethods
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string message = Message.GetMessage("fr");
            Console.WriteLine(message);
            Console.ReadLine();
        }
    }
}
