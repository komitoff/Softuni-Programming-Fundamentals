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
            bool isLanded = false;

            if (direction.Equals("right"))
            {
                while (!isLanded)
                {
                    if (start < 0
                    || start >= field.Length
                    || count < 0
                    || start + count >= field.Length)
                    {
                        break;
                    }

                    if (field[start] == 0)
                    {
                        break;
                    }

                    field[start] = 0;

                    if (field[start + count] == 0)
                    {
                        field[start + count] = 1;
                        isLanded = true;
                    }
                    else
                    {
                        start += count;
                    }
                }
                    
            }
            command = Console.ReadLine();
        }

        Console.WriteLine(string.Join(" ", field));
    }
}