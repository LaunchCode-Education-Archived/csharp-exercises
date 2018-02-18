using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SumOfEven
{
    class SumOfEven
    {
        public static double sumOfEven(List<int> numbers)
        {
            List<int> listOfEven = new List<int>();
            double sumOfEvens;
            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    listOfEven.Add(number);
                }
            }
            sumOfEvens = listOfEven.Sum();
            return sumOfEvens;
        }
    }
}
