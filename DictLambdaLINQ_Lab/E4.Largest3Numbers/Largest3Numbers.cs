using System;
using System.Collections.Generic;
using System.Linq;


class Largest3Numbers
{
    static void Main()
    {
        List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        numbers.OrderByDescending(v => v);
        var sortedList = numbers.OrderByDescending(x => x);
        var largest3 = sortedList.Take(3);
        Console.WriteLine(string.Join(" ", largest3));
    }
}