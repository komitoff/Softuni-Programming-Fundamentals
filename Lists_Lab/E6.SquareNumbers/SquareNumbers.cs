using System;
using System.Collections.Generic;
using System.Linq;

class SquareNumbers
{
    static void Main()
    {
        List<double> numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
        numbers.Sort();
        numbers.Reverse();
        foreach (var number in numbers)
        {
            if (Math.Sqrt(number) == (int) (Math.Sqrt(number)))
            {
                Console.Write(number + " ");
            }
        }
    }
}