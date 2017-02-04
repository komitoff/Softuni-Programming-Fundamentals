using System;
using System.Collections.Generic;
using System.Linq;

class BombNumbers
{
    static void Main()
    {
        List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        
        int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int specialNumb = input[0];
        int count = input[1];
        int sum = Bomb(numbers, specialNumb, count);
        Console.WriteLine(sum);

    }


    //1 2 2 4 2 2 4
    //4 2 
    private static int Bomb(List<int> numbers,int specialNumb, int count)
    {
        int sum = 0;
        int startIndex = 0;
        int endIndex = 0;

        if (count > 0 && count < numbers.Count)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == specialNumb)
                {
                    if (i - count < 0)
                    {
                        startIndex = 0;
                    }
                    else
                    {
                        startIndex = i - count;
                    }

                    if (i + count >= numbers.Count)
                    {
                        endIndex = numbers.Count - 1;
                    }
                    else
                    {
                        endIndex = i + count;
                    }

                    for (int j = endIndex; j >= startIndex; j--)
                    {
                        numbers.RemoveAt(j);
                    }
                    i = 0;
                }
             
            }
        }

        foreach (var number in numbers)
        {
            sum += number;
        }
        return sum;
    }
}