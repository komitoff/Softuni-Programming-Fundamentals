using System;

class SumOfNumbers
{
    static void Main()
    {
        int first = int.Parse(Console.ReadLine());
        int second = int.Parse(Console.ReadLine());
        int third = int.Parse(Console.ReadLine());

        int[] numbers = new int[] { first, second, third };
        Array.Sort(numbers);

        if (numbers[2] == numbers[0] + numbers[1])
        {
            Console.WriteLine("{0} + {1} = {2}", numbers[0], numbers[1], numbers[2]);
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}
