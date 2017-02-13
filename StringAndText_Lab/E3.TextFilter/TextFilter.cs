using System;

public class TextFilter
{
    static void Main()
    {
        string[] bannedWords = Console.ReadLine().Split(new char[] { ',', ' '}, StringSplitOptions.RemoveEmptyEntries);
        string text = Console.ReadLine();
        for (int i = 0; i < bannedWords.Length; i++)
        {
            if (text.Contains(bannedWords[i]))
            {
                text = text.Replace(bannedWords[i], new string('*', bannedWords[i].Length));
            }
        }

        Console.WriteLine(text);
    }
}