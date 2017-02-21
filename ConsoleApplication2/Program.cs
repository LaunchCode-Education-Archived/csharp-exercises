using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListFive
{
    class Program
    {
        static void PrintWords(List<string> words)
        {
            foreach (string value in words)
            {
                if (value.Length == 5)
                {
                    Console.WriteLine(value);
                }
            }
            
        }
        static void Main(string[] args)
        {
            string[] NameList = { "Patrick", "Chris", "Margaret", "Katie", "Elise", "Clark", "Bob", "Fiver" };
            PrintWords(NameList.ToList());
            Console.ReadLine();

        }
    }
}
