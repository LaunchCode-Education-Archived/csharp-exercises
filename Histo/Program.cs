using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace Histo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> count = new List<int>();

            string rawData = Histo.Properties.Resources.test_data;
            string[] data = rawData.Split(' ');

            // Fill the list with zeros
            for (int i = 0; i < data.Length; i++) {
                count.Add(0);
            }

            for (int j = 0; j < data.Length; j++) {
                int val = int.Parse(data[j]);
                count[val] = count[val] + 1;
            }

            int idx = 0;
            foreach (var k in count) {
                Console.WriteLine(idx + " occurred " + k + " times");
                idx++;
            }

            Console.ReadLine();
        }
    }
}
