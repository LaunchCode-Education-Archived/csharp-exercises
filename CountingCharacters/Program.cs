using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CountingCharacters
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string testString = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc accumsan sem ut ligula scelerisque sollicitudin. Ut at sagittis augue. Praesent quis rhoncus justo. Aliquam erat volutpat. Donec sit amet suscipit metus, non lobortis massa. Vestibulum augue ex, dapibus ac suscipit vel, volutpat eget massa. Donec nec velit non ligula efficitur luctus.";

            Dictionary<char, int> counts = new Dictionary<char, int>();

            foreach (char c in testString)
            {
                if (!counts.Keys.Contains(c))
                {
                    counts.Add(c, 1);
                }
                else
                {
                    counts[c]++;
                }
            }

            foreach (KeyValuePair<char, int> count in counts)
            {
                Console.WriteLine(count.Key + ": " + count.Value);
            }

            Console.ReadLine();
        }
    }
}
