using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class ArrayManipulator
{
    static void Main()
    {
        int[] nums = new int[] { 1, 2, 3, 4, 5, 6, 7 };

        nums.Where(x => x % 2 == 0)
            .OrderByDescending(x => x)
            .Take(3)
            .ToList()
            .ForEach(Console.WriteLine);
    }
}