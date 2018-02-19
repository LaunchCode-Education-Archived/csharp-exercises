using System;
using System.Collections.Generic;
using System.Text;

namespace ListsAndStrings
{
    class FiveLetterWords
    {
        public static List<string> fiveLetterWords(List<string> List)
        {
            List<string> newList = new List<string>();
            foreach (string item in List)
            {
                if (item.Length == 5)
                {
                    newList.Add(item);
                }
            }
            return newList;
        }
    }
}
