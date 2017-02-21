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
        List<int> field = new List<int>(new int[fieldLength]);

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
            if (fieldLength <= 0)
            {
                command = Console.ReadLine();
                continue;
            }
            string[] tokens = command.Split();

            int start = int.Parse(tokens[0]);
            int count = int.Parse(tokens[tokens.Length - 1]);
            string direction = tokens[1];

            if (direction.Equals("left"))
                count *= -1;

            for (int j = start + count; j <= field.Count; j += count)
            {
                bool landed = false;
                if (field[start] == 0 && landed)
                {
                    break;
                }
                else
                {
                    field[start] = 0;
                    if (j >= field.Count || j < 0)
                    {
                        landed = true;
                        break;
                    }
                    if (field[j] == 0)
                    {
                        landed = true;
                        field[j] = 1;
                        break;
                    }
                }
            }
            command = Console.ReadLine();
        }

        Console.WriteLine(string.Join(" ", field));
    }
}