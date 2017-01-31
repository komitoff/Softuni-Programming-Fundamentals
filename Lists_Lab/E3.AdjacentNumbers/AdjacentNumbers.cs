using System;
using System.Collections.Generic;
using System.Linq;

class AdjacentNumbers
{
    static void Main()
    {
        List<double> numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
        int length = numbers.Count;
        bool flag = true;
        while (flag)
        {
            flag = false;
            for (int i = 0; i < numbers.Count - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    numbers[i] = numbers[i] + numbers[i + 1];
                    numbers.RemoveAt(i + 1);
                    flag = true;
                    break;
                }
            }
        }

        foreach (var number in numbers)
        {
            Console.Write(number +  " ");
        }
    }
}