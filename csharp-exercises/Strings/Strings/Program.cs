
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string Alice, searchterm;

            Alice = "Alice was beginning to get very tired of sitting by her sister on the bank"+
                ", and of having nothing to do: once or twice she had peeped into the book her sister" +
                " was reading, but it had no pictures or conversations in it, 'and what is the use of a +" +
                "book,' thought Alice 'without pictures or conversation?'".ToLower();

            Console.WriteLine("-Search the hidden paragraph for strings of characters from book Alice in Wonderland.-".ToUpper());
            Console.WriteLine();

            searchterm = Console.ReadLine();

            if (Alice.Contains(searchterm.ToLower()))
            {
                Console.WriteLine("True");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("False");
                Console.ReadLine();
            }
        }
    }
}
