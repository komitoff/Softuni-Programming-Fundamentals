using System;
using System.Collections.Generic;
using System.Linq;

class SplitByWordCasing
{
    static void Main()
    {
        String inputText = Console.ReadLine();
        string[] words = inputText
                            .Split(new char[] { ',', '.', ';', ':', '!', '(', ')', '"', '\'', '\\', '/', '[', ']', ' '});

        List<string> lowerCase = new List<string>();
        List<string> upperCase = new List<string>();
        List<string> mixedCase = new List<string>();

        for (int i = 0; i < words.Length; i++)
        {
            string upCase = words[i].ToUpper();
            string lowCase = words[i].ToLower();

            if (words[i].Equals(upCase))
            {
                upperCase.Add(words[i]);
            }
            else if (words[i].Equals(lowCase))
            {
                lowerCase.Add(words[i]);
            }
            else
            {
                mixedCase.Add(words[i]);
            }
        }

        Console.Write("Lower case : ");
        Console.WriteLine(string.Join(", ", lowerCase));
        //foreach (var word in lowerCase)
        //{
        //    Console.WriteLine(string.Join(" , ", word));
        //}
        Console.Write("Mixed case : ");
        Console.WriteLine(string.Join(", ", mixedCase));
        //foreach (var word in mixedCase)
        //{
        //    Console.WriteLine(string.Join(" , ", word));
        //}
        Console.Write("Upper case : ");
        Console.WriteLine(string.Join(", ", upperCase));
        //foreach (var word in upperCase)
        //{
        //    Console.WriteLine(string.Join(" , ", word));
        //}
        
    }
}