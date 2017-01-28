using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class TripleSum
{
    static void Main(string[] args)
    {
        string [] input = Console.ReadLine().Split(' ');
        long[] numbers = new long[input.Length];
        for (int i = 0; i < input.Length; i++)
        {
            numbers[i] = long.Parse(input[i]);
        }
        bool match = false;
        for (int i = 0; i < numbers.Length - 1; i++)
        {
            if (numbers[i] >= 0)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    long tmp = numbers[i] + numbers[j];
                    for (int k = 0; k < numbers.Length; k++)
                    {
                        if (tmp == 0)
                        {
                            Console.WriteLine($"{numbers[i]} + {numbers[j]} == {numbers[k]}");
                            match = true;
                            break;
                        }
                        else if (tmp == numbers[k])
                        {
                            Console.WriteLine($"{numbers[i]} + {numbers[j]} == {numbers[k]}");
                            match = true;
                        }
                    }
                }
            }
        }

        if (!match)
            Console.WriteLine("No");


    }
}