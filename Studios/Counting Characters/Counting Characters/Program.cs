using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Counting_Characters
{   
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string to be counted.");
            string input = Console.ReadLine();

            Dictionary<char, int> countofletters = new Dictionary<char, int>();

            countofletters.Add('a', 0);
            countofletters.Add('b', 1);
            countofletters.Add('c', 1);
            countofletters.Add('d', 1);
            countofletters.Add('e', 1);
            countofletters.Add('f', 1);
            countofletters.Add('g', 1);
            countofletters.Add('h', 1);


            Console.WriteLine(countofletters['a']hy h);
            Console.ReadLine();
        }
        
    }
}