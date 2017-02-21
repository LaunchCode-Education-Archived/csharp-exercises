using System;
class ArraySum
{
    public static void Main()
    {
        int[] MyNumber = { 1, 18, 6, 2, 86, 65, 103, 17, 404, 15, 46, 55, 82, 201 };
        int sum = 0;
        for (int i = 0; i <= 10; i++)
        {
            if (MyNumber[i] % 2 == 0)
            {
                sum = sum + MyNumber[i];
            }
        }
        Console.WriteLine("Sum:" + sum);
        Console.ReadLine();
    }
}