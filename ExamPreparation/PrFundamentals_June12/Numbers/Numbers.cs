using System;
using System.Collections.Generic;
using System.Linq;

public class Numbers
{
    static void Main()
    {
        List<int> numbers = Console
            .ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList();

        List<int> output = new List<int>();

        int average = (int)Math.Round(numbers.Average(n => n));
        bool flag = false;
        for (int i = 0; i < numbers.Count; i++)
        {
            if (numbers[i] > average)
            {
                output.Add(numbers[i]);
                flag = true;
            }
        }
        int length = 0;
        if (!flag)
        {
            Console.WriteLine("No");
        }
        else
        {
            if (output.Count >= 5)
                length = 5;
            else
               length = output.Count;
            
            List<int> final = output.OrderByDescending(p => p).Take(length).ToList();
            Console.WriteLine(string.Join(" ", final));

        }

    }
}