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

            //if the start position is out of the arr boundaries
            if (start < 0 || start >= field.Length)
            {
                command = Console.ReadLine();
                continue;
            }

            MoveLadybugs(start, count, direction, field);
            command = Console.ReadLine();
        }

        output.Append(string.Join(" ", field));
        Console.WriteLine(output);
    }

    private static void MoveLadybugs(int start, int count, string direction, int[] field)
    {
        bool landed = false;

        if (direction.Equals("left"))
            count *= -1;
        
        field[start] = 0;

        while (!landed)
        {
            if (start + count >= field.Length
                || start + count < 0 )
            {
                break;
            }

            if (field[start + count] == 0)
            {
                field[start + count] = 1;
                landed = true;
            }

            count += count;
        }
    }
}