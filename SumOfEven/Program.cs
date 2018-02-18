using System;
using System.Collections.Generic;

namespace SumOfEven
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            for (int i = 0; i < 10; i += 1)
            {
                numbers.Add(i + 1);
            }
            foreach (int item in numbers)
            {
                Console.WriteLine(item);
            }
            double sum = SumOfEven.sumOfEven(numbers);
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
