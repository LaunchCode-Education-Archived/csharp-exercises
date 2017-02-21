using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenSum
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> MyNumbers = new List<int>() {2,4,6,76,85,34,56 };

            SumEven(MyNumbers);

            int sum = 0;
            // Cycle through my List
            for (int i = 0; i <= MyNumbers.Count; i++)
            {
                int currentNumber = MyNumbers[i];
                if (i % 2 == 0) // find my even numbers
                {
                    sum = sum + i; // add my even numbers together
                }
            };
            Console.WriteLine("Sum:" + sum);
            Console.ReadLine();
        }

        public static int SumEven(List<int> listOfNumber)
        {
            int sum = 0;
            // Cycle through my List
            for (int i = 0; i <= listOfNumber.Count; i++)
            {
                int currentNumber = listOfNumber[i];
                if (i % 2 == 0) // find my even numbers
                {
                    sum = sum + i; // add my even numbers together
                }
            };
            return sum;
        }
    }
}
