using System;
using System.Linq;

public class ArrayManipulator
{
    static void Main()
    {
        int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

        string command = Console.ReadLine();
        string evenOdd = null;
        int count = 0;
        while (!command.Equals("end"))
        {
            string[] tokens = command.Split();

            switch (tokens[0])
            {
                case "exchange":
                    int index = int.Parse(tokens[1]);
                    arr = Exchange(index, arr);
                    break;
                case "max":
                    evenOdd = tokens[1];
                    Max(evenOdd, arr);
                    break;
                case "min":
                    evenOdd = tokens[1];
                    Min(evenOdd, arr);
                    break;
                case "first":
                    count = int.Parse(tokens[1]);
                    evenOdd = tokens[2];
                    Console.WriteLine(First(evenOdd, count, arr));
                    break;
                case "last":
                    count = int.Parse(tokens[1]);
                    evenOdd = tokens[2];
                    Console.WriteLine(Last(evenOdd, count, arr));
                    break;
                default: 
                    break;
            }
            command = Console.ReadLine();
        }
        var output = string.Join(", ", arr);
        Console.WriteLine($"[{output}]");   
    }

    private static string Last(string evenOdd, int count, int[] arr)
    {
        var parity = evenOdd == "even" ? 0 : 1;
        var reversed = arr.Reverse().ToArray();
        var filtered = reversed.Where(x => x % 2 == parity).Take(count).ToArray();

        if (count > arr.Length || count < 0)
        {
            return "Invalid count";
        }
        var reversedFiltered = filtered.Reverse().ToArray();
        string numbers = string.Join(", ", reversedFiltered);
        string output = "[" + numbers + "]";
        return output;
    }

    private static string First(string evenOdd, int count, int[] arr)
    {
        var parity = evenOdd == "even" ? 0 : 1;
        var filtered = arr.Where(x => x % 2 == parity).Take(count).ToArray();

        if (count > arr.Length || count < 0)
        {
            return "Invalid count";
        }
        string numbers = string.Join(", ", filtered);
        string output = "[" + numbers + "]";
        return output;
    }

    private static void Min (string evenOdd, int[] arr)
    {
        int parity = evenOdd == "even" ? 0 : 1;
        var filtered = arr.Where(x => x % 2 == parity);
        if (!filtered.Any())
        {
            Console.WriteLine("No matches");
        }
        else
        {
            Console.WriteLine(Array.LastIndexOf(arr, filtered.Min()));
        }
    }

    private static void Max (string evenOdd, int[] arr)
    {
        int parity = evenOdd == "even" ? 0 : 1;
        var filtered = arr.Where(x => x % 2 == parity);
        if (!filtered.Any())
        {
            Console.WriteLine("No matches");
        }
        else
        {
            Console.WriteLine(Array.LastIndexOf(arr, filtered.Max()));
        }
        
    }

    private static int[] Exchange(int index, int[] arr)
    {
        if (index < 0 || index >= arr.Length)
        {
            Console.WriteLine("Invalid index");
            return arr;
        }
        var left = arr.Take(index + 1);
        var right = arr.Skip(index + 1);
        return right.Concat(left).ToArray();
    }
}