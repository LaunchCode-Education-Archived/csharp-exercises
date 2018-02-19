using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CountingCharacters
{
    class CountCharacters
    {
        public static Dictionary<char, double> countCharacters(string str)
        {
            Dictionary<char, double> characterCount = new Dictionary<char, double>();
            double charCount = 0;
            foreach (char character in str)
            {
                charCount = str.Count(x => x ==character);
                if (characterCount.ContainsKey(character))
                {

                }
                else
                {
                characterCount.Add(character, charCount);
                }
            }
            
            return characterCount;
        }
    }
}
