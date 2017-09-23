using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            //Populate using Add() method
            Dictionary<string, int> stringAndint = new Dictionary<string, int>();

            stringAndint.Add("Steven", 33);
            stringAndint.Add("Jasmine", 23);
            stringAndint.Add("Omono", 30);
            stringAndint.Add("Edward", 25);

            int one = stringAndint["Edward"];
            Console.WriteLine("Edward is {0} years old.",one);
            Console.WriteLine("The number of people in the dictionary is {0}", stringAndint.Count);
            Console.ReadLine();


        }
    }
}
