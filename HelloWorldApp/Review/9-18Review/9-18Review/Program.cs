using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_18Review
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose your language fr or sp and english by default.");
            string str;

            str = Console.ReadLine();
            Console.WriteLine(Message.GetMessage(str));
            Console.ReadLine();
        }

        
    }
    public class Message
    {
        public static string GetMessage(string lang)
        {
            if (lang.Equals("sp"))
            {
                return "Hola";
            }
            else if (lang.Equals("fr"))
            {
                return "Bonjour";
            }
            else
            {
                return "Hello";
            }
        }
    }
}
