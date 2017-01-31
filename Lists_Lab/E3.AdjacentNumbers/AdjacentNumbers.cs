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
            for (int i = 0; i < numbers.Count; i++)
            {
                for (int j = i + 1; j < numbers.Count; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        numbers[i] = numbers[i] + numbers[j];
                        numbers.RemoveAt(j);
                        flag = true;
                        break;

                    }
                }
            }
        }

        foreach (var number in numbers)
        {
            Console.Write(number +  " ");
        }
    }
}