using System;
using System.Collections.Generic;

namespace studio_2 {
    class Program {
        static void Main(string[] args) {
            Dictionary<char, int> charCount = new Dictionary<char, int>();
            Console.WriteLine("Enter a string to analyze");
            string userInput = Console.ReadLine();

            foreach(char character in userInput) {
                // if the key does not exist
                if (!charCount.ContainsKey(character)) {
                   charCount.Add(character, 1);  
                } else { // the key already exists
                    charCount[character] += 1;
                }
            }

            foreach(KeyValuePair<char, int> entry in charCount) {
                Console.WriteLine("{0}: {1}", entry.Key, entry.Value);
            }
        }
    }
}

