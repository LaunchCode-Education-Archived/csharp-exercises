using System;
using System.Collections.Generic;

namespace Histo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Pull in data from a file as configured as a project resource
            string rawData = Histo.Properties.Resources.test_data;
            string[] data = rawData.Split(' ');
            
            // Fill the list with zeros
            List<int> count = new List<int>();
            for (int i = 0; i < data.Length; i++) {
                count.Add(0);
            }

            // Count occurences of each number in the file
            for (int j = 0; j < data.Length; j++) {
                int val = int.Parse(data[j]);
                count[val] = count[val] + 1;
            }

            // Display results
            int idx = 0;
            foreach (int k in count) {
                Console.WriteLine(idx + " occurred " + k + " times");
                idx++;
            }

            Console.ReadLine();
        }
    }
}
