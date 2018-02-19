using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 1, 2, 3, 5, 8 };
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.ReadLine();
        }
    }
}
