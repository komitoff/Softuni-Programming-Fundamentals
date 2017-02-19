using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class CommandInterpreter
{
    static void Main()
    {
        List<string> numbers = Console
            .ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .ToList();

        string command = Console.ReadLine();

        while (!command.Equals("end"))
        {
            string[] tokens = command.Split();
            if (tokens[0].Equals("reverse"))
            {
                int start = int.Parse(tokens[2]);
                int count = int.Parse(tokens[4]);
                if (start < 0 || start >= numbers.Count || (start + count) > numbers.Count || count < 0)
                {
                    Console.WriteLine("Invalid input parameters.");
                }
                else
                {
                    List<string> reversed = numbers.Skip(start).Take(count).Reverse().ToList();
                    numbers.RemoveRange(start, count);
                    numbers.InsertRange(start, reversed);
                }
                
            }
            else if (tokens[0].Equals("sort"))
            {
                int start = int.Parse(tokens[2]);
                int count = int.Parse(tokens[4]);

                if (start < 0 || start >= numbers.Count || (start + count) > numbers.Count || count < 0)
                {
                    Console.WriteLine("Invalid input parameters.");
                }
                else
                {
                    List<string> reversed = numbers.Skip(start).Take(count).OrderBy(x => x).ToList();
                    numbers.RemoveRange(start, count);
                    numbers.InsertRange(start, reversed);
                }
                
            }
            else if (tokens[0].Equals("rollLeft"))
            {
                int count = int.Parse(tokens[1]);
                if (count < 0)
                {
                    Console.WriteLine("Invalid input parameters.");
                }
                else
                {
                    for (int i = 0; i < count % numbers.Count; i++)
                    {
                        string tmp = numbers[0];
                        numbers.RemoveAt(0);
                        numbers.Add(tmp);
                    }
                }
            }
            else if (tokens[0].Equals("rollRight"))
            {
                int count = int.Parse(tokens[1]);
                if (count < 0)
                {
                    Console.WriteLine("Invalid input parameters.");
                }
                else
                {
                    for (int i = 0; i < count % numbers.Count; i++)
                    {
                        string tmp = numbers[numbers.Count - 1];
                        numbers.RemoveAt(numbers.Count - 1);
                        numbers.Insert(0, tmp);
                    }
                }
            }

            command = Console.ReadLine();
        }

        string output = string.Join((", "), numbers);
        Console.WriteLine($"[{output}]");
    }
}