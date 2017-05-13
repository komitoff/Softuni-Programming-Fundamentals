using System;

class BiggestNumber
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] allNumbers = new int[n];

        for (int i = 0; i < n; i++)
        {
            allNumbers[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(allNumbers);
        Console.WriteLine(allNumbers[0]);
    }
}
