using System;
using System.Collections.Generic;
using System.Linq;

class RandomizeWords
{
    static void Main()
    {
        string[] words = Console.ReadLine().Split();
        Random randomGenerator = new Random();
        for (int i = 0; i < words.Length; i++)
        {
            string currentWord = words[i];
            int randomIndex = randomGenerator.Next(0, words.Length - 1);
            string tempWord = words[randomIndex];
            words[i] = tempWord;
            words[randomIndex] = currentWord;
        }

        foreach (var word in words)
        {
            Console.WriteLine(word);
        }

    }
}