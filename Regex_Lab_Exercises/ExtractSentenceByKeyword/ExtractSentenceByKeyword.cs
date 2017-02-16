using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class ExtractSentenceByKeyword
{
    static void Main()
    {
        string keyword = Console.ReadLine();
        string[] text = Console.ReadLine()
            .Split(new char[] { '.', '!', '?' },
            StringSplitOptions.RemoveEmptyEntries);
        foreach (var sentence in text)
        {
            string[] wordsInSentence = sentence
                .Split(new char[] { ' ', ',', '-', ':', ';' },
                StringSplitOptions.RemoveEmptyEntries);
            foreach (var word in wordsInSentence)
            {
                if (keyword.Equals(word))
                {
                    Console.WriteLine(sentence.TrimStart());
                }
            }
        }
    }
}