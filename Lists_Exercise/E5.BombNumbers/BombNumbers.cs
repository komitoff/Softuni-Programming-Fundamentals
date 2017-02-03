using System;
using System.Collections.Generic;
using System.Linq;

class BombNumbers
{
    static void Main()
    {
        List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        int index = int.Parse(Console.ReadLine());
        int sum = 0;

        if (index < 0 || index >= numbers.Count)
        {
            foreach (var number in numbers)
            {
                sum += number;
            }
            Console.WriteLine(sum);
        }
        else
        {

        }

    }
}