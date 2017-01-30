using System;
using System.Collections.Generic;
using System.Linq;

class AppendLists
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split('|').ToArray();
        List<int> numbers = new List<int>();
        for (int i = input.Length - 1; i >= 0; i--)
        {
            numbers.AddRange(input[i].Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList());
        }

        foreach (var number in numbers)
        {
            Console.Write(number + " ");
        }
    }
}