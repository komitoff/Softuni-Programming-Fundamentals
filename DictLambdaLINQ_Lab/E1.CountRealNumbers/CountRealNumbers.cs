using System;
using System.Collections.Generic;
using System.Linq;

class CountRealNumbers
{
    static void Main()
    {
        List<double> numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToList();

        Dictionary<double, int> count = new Dictionary<double, int>();
        numbers.Sort();
        foreach (var number in numbers)
        {
            if (!count.ContainsKey(number))
            {
                count.Add(number, 0);
            }
            count[number]++;
        }

        foreach (var item in count)
        {
            Console.Write(item.Key + " -> " + item.Value);
            Console.WriteLine();
        }
    }
}