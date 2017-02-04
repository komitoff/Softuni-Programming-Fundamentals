using System;
using System.Collections.Generic;
using System.Linq;

class MathOperations
{
    static void Main()
    {
        int length = int.Parse(Console.ReadLine());
        List<int> numbers = new List<int>();
        for (int i = 0; i < length; i++)
        {
            numbers.Add(int.Parse(Console.ReadLine()));
        }

        Console.WriteLine("Sum = {0}", numbers.Sum());
        Console.WriteLine("Min = {0}", numbers.Min());
        Console.WriteLine("Max = {0}", numbers.Max());
        Console.WriteLine("Average = {0}", numbers.Average());
    }
}