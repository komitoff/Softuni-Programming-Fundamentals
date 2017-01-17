using System;

class ExactSumOfNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        decimal result = 0m;
        for (int i = 0; i < n; i++)
        {
            decimal current = decimal.Parse(Console.ReadLine());
            result += current;

        }
        Console.WriteLine(result);
    }
}
