using System;

class SumingNubmers
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int finalSum = 0;

        for (int i = 0; i < n; i++)
        {
            finalSum += int.Parse(Console.ReadLine());
        }

        Console.WriteLine(finalSum);
    }
}
