using System;
using System.Collections.Generic;
using System.Linq;

class ShortWordSorted
{
    static void Main()
    {
        string input = Console.ReadLine().ToLower();
        List<string> words = input.Split(
            new char [] { '.', ',', ':', ';', '(', ')', '[', ']', '"', '\'', '\\', '/', '!', '?', ' ' }, 
            StringSplitOptions.RemoveEmptyEntries)
            .Where(x => x.Length < 5)
            .OrderBy(x => x)
            .Distinct()
            .ToList();

        Console.WriteLine(string.Join(", ", words));
    }
}