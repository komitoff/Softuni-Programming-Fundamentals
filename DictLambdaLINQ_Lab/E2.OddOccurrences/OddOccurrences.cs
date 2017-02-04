using System;
using System.Collections.Generic;
using System.Linq;

class OddOccurrences
{
    static void Main()
    {
        string[] words = Console.ReadLine().Split(' ');
        Dictionary<string, int> countWords = new Dictionary<string, int>();

        for (int i = 0; i < words.Length; i++)
        {
            string currentWord = words[i].ToLower();
            if (!countWords.ContainsKey(currentWord))
            {
                countWords.Add(currentWord, 0);
            }
            countWords[currentWord]++;
        }
        List<string> sortedWords = new List<string>();
        foreach (var item in countWords)
        {
            if (!(item.Value % 2 == 0))
            {
                sortedWords.Add(item.Key);
            }
        }
        Console.WriteLine(string.Join(", ", sortedWords));
    }
}
