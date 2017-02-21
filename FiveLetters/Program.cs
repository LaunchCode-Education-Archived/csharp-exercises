using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiveLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                string[] NameList = { "Patrick", "Chris", "Maggie", "Katherine", "Elise", "Clark" };
                // Find string of length 5.
                string result = NameList.FindAll(NameList, s => s.Length == 5);
                Console.WriteLine(result);
            }
            Console.ReadLine();
        }
    }
}
