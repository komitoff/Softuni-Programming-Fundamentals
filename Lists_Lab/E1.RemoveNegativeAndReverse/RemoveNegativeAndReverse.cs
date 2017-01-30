using System;
using System.Collections.Generic;
using System.Linq;

class RemoveNegativeAndReverse
{
    static void Main()
    {
        List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

        numbers.RemoveAll(i => i < 0);
        numbers.Reverse();

        if (numbers.Count == 0)
        {
            Console.WriteLine("empty");
        }
        foreach (var number in numbers)
        {
            Console.Write(number + " ");
        }

        
    }
}