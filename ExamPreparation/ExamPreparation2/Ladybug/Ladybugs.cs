using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Ladybugs
{
    static void Main()
    {
        int fieldLength = int.Parse(Console.ReadLine());
        List<int> indexes = Console.ReadLine().Split().Select(int.Parse).ToList();
        int[] field = new int[fieldLength];
        StringBuilder output = new StringBuilder();
        //fill the field with fellow bugs
        for (int i = 0; i < fieldLength; i++)
        {
            if (indexes.Contains(i))
                field[i] = 1;
            else
                field[i] = 0;
        }

        string command = Console.ReadLine();
        while (!command.Equals("end"))
        {
            string[] tokens = command.Split();

            int start = int.Parse(tokens[0]);
            int count = int.Parse(tokens[tokens.Length - 1]);
            string direction = tokens[1];

            if (direction.Equals("left"))
                count *= -1;

            if (fieldLength <= 0
                || start > field.Length
                || start + count < 0
                || start < 0)
            {
                command = Console.ReadLine();
                continue;
            }
            bool landed = false;
            var j = start + count;
            while (!landed)
            {
                if (field[start] == 0 || landed)
                {
                    break;
                }
                else
                {
                    if (j >= field.Length || j < 0)
                    {
                        field[start] = 0;
                        landed = true;
                        break;
                    }
                    if (field[j] != 1)
                    {
                        int tmp = field[start];
                        field[start] = 0;
                        landed = true;
                        field[j] = tmp;
                        break;
                    }
                }
                j += count;
            }
            command = Console.ReadLine();
        }

        output.Append(string.Join(" ", field));
        Console.WriteLine(output);
    }
}