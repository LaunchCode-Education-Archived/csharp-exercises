using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Bob Tabor Lesson One
            Console.WriteLine("Hello World");
            Console.ReadLine();
            */

            /*Bob Tabor Lesson Two
             Explains 
                Code Management Conventions
                File Organization
            */

            /*Input/output: Modify your HelloWorld program to prompt the user for their name, and 
             greet them by name*/

            Console.WriteLine("-This Program greets the user.-".ToUpper());
            Console.WriteLine();
            Console.WriteLine("What is your name?");

            string username;
            
            username = Console.ReadLine();

            Console.WriteLine("Hello, {0}.", username);
            Console.ReadLine();




        }
    }
}
