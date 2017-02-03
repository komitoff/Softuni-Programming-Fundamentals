using System;
using System.Collections.Generic;
using System.Linq;

class BombNumbers
{
    static void Main()
    {
        List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        int[] indexAndCount = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int index = indexAndCount[0];
        int count = indexAndCount[1];
        int sum = Bomb(numbers, index, count);
        Console.WriteLine(sum);

    }

    private static int Bomb(List<int> numbers,int index, int count)
    {
        int sum = 0;
        if (count > 0 && count < numbers.Count)
        {
            numbers.RemoveRange(index, count);
            numbers.Reverse();
            numbers.RemoveRange(index , count);
            
        }

        foreach (var number in numbers)
        {
            sum += number;
        }
        return sum;
    }
}