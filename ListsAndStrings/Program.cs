using System;
using System.Collections.Generic;
using System.Linq;

namespace ListsAndStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> testList = new List<string>();
            testList.Add("bob");
            testList.Add("bobby");
            testList.Add("tom");
            var flw = FiveLetterWords.fiveLetterWords(testList);
            string result = "";
            foreach (string item in flw)
            {
                result = result + item;
            }
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
