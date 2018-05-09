using System;

namespace AliceInWonderland
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Search string: ");
            string userInput = Console.ReadLine();
            bool result = StringCheck.DoesExist(userInput);
            Console.WriteLine(result);
            Console.ReadLine();

        }
    }
}
