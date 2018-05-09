using System;
using System.Collections.Generic;
using System.Text;

namespace AliceInWonderland
{
    class StringCheck
    {
        private static string stringToCheck = "Alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing to do: once or twice she had peeped into the book her sister was reading, but it had no pictures or conversations in it, 'and what is the use of a book,' thought Alice 'without pictures or conversation?'";
        public static Boolean DoesExist(string subString)
        {
            subString = subString.ToLower();
            string stringToCheckToLower = stringToCheck.ToLower();

            bool result = stringToCheckToLower.Contains(subString);
            return result;
        }
    }
}
