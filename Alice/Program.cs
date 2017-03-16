using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alice
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing to do: once or twice she had peeped into the book her sister was reading, but it had no pictures or conversations in it, 'and what is the use of a book,' thought Alice 'without pictures or conversation?'";
            Console.WriteLine("Given the following text:");
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine(text);
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("What should I search for within it?");
            string query = Console.ReadLine().ToLower();
            if (text.ToLower().Contains(query))
            {
                Console.WriteLine("true");
            } else
            {
                Console.WriteLine("false");
            }
            Console.ReadLine();
        }
    }
}
