using System;
using System.Collections.Generic;
using System.Linq;

public class CommandInterpreter
{
    static void Main()
    {
        string[] numbers = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .ToArray();

        string command = Console.ReadLine();

        while (!command.Equals("end"))
        {
            string[] tokens = command.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (tokens[0].Equals("reverse"))
            {
                int start = int.Parse(tokens[2]);
                int count = int.Parse(tokens[4]);
                Reverse(start, count, numbers);
            }
            else if (tokens[0].Equals("sort"))
            {
                int start = int.Parse(tokens[2]);
                int count = int.Parse(tokens[4]);
                Sort(start, count, numbers);
            }
            else if (tokens[0].Equals("rollLeft"))
            {
                int count = int.Parse(tokens[1]);
                RollLeft(count, numbers);
            }
            else if (tokens[0].Equals("rollRight"))
            {
                int count = int.Parse(tokens[1]);
                RollRight(count, numbers);
            }
            
            command = Console.ReadLine();
        }
        Console.Write("[");
        Console.WriteLine(string.Join(", ", numbers) + "]");
    }

    private static void RollRight(int count, string[] numbers)
    {
        if (count >= 0)
        {
            if (count % numbers.Length == 0)
            {
                count = numbers.Length;
            }
            for (int i = 0; i < count; i++)
            {
                string tmp = numbers[0];
                numbers[0] = numbers[numbers.Length - 1];
                numbers[numbers.Length - 1] = tmp;

                for (int j = numbers.Length - 1; j > 1; j--)
                {
                    string tmp2 = numbers[j];
                    numbers[j] = numbers[j - 1];
                    numbers[j - 1] = tmp2;
                }
            }
        }
        else
        {
            Console.WriteLine("Invalid input parameters.");
        }
    }

    private static void RollLeft(int count, string[] numbers)
    {
        if (count >= 0)
        {
            if (count % numbers.Length == 0)
            {
                count = numbers.Length;
            }
            for (int i = 0; i < count; i++)
            {
                string tmp = numbers[0];
                numbers[0] = numbers[numbers.Length - 1];
                numbers[numbers.Length - 1] = tmp;

                for (int j = 0; j < numbers.Length - 2; j++)
                {
                    string tmp2 = numbers[j];
                    numbers[j] = numbers[j + 1];
                    numbers[j + 1] = tmp2;
                }
            }
        }
        else
        {
            Console.WriteLine("Invalid input parameters.");
        }

    }

    private static void Sort(int start, int count, string[] numbers)
    {
        if (start >= 0 && count >= 0 && start <= numbers.Length && start + count <= numbers.Length && count <= numbers.Length)
        {
            string[] subArr = new string[count];
            for (int i = start, j = 0; i < count + start; i++, j++)
            {
                subArr[j] = numbers[i];
            }
            Array.Sort(subArr);

            for (int i = start, j = 0; i < count + start; i++, j++)
            {
                numbers[i] = subArr[j];
            }
        }
        else
        {
            Console.WriteLine("Invalid input parameters.");
        }
    }

    private static void Reverse(int start, int count, string[] numbers)
    {

        if (start >= 0 && count >= 0 && start <= numbers.Length && start + count <= numbers.Length && count <= numbers.Length)
        {
            string[] subArr = new string[count];
            for (int i = start, j = 0; i < count + start; i++, j++)
            {
                subArr[j] = numbers[i];
            }
            Array.Reverse(subArr);

            for (int i = start, j = 0; i < count + start; i++, j++)
            {
                numbers[i] = subArr[j];
            }
        }
        else
        {
            Console.WriteLine("Invalid input parameters.");
        }
    }
}