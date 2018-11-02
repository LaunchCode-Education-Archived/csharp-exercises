using System;

namespace Recursion
{
    class Program
    {
        static int Recursive(int value, ref int count)
        {
            count++;
            if (value >= 10)
            {
                //throw new Exception("End");
                return value;
            }
            return Recursive(value + 1, ref count);
            
        }

        static void Main()
        {
            int count = 0;
            int total = Recursive(5, ref count);

            Console.WriteLine(total);
            Console.WriteLine(count);
        }
           

    }
}
