using System;
using System.Collections.Generic;
using System.Linq;

class SplitByWordCasing
{
    static void Main()
    {
        String inputText = Console.ReadLine();
        string[] words = inputText
                            .Split(new char[] { ',', '.', ';', ':', '!', '(', ')', '"', '\'', '\\', '/', '[', ']', ' '}, StringSplitOptions.RemoveEmptyEntries);

        List<string> lowerCase = new List<string>();
        List<string> upperCase = new List<string>();
        List<string> mixedCase = new List<string>();

        for (int i = 0; i < words.Length; i++)
        {
            string upCase = words[i].ToUpper();
            string lowCase = words[i].ToLower();

            //check if the word is the same as the same word, but upper Case
            if (words[i].Equals(upCase) && !CheckForSymbols(words[i])) 
            {
                upperCase.Add(words[i]);
            }
            //check if the word is the same as the same word, but lower Case
            else if (words[i].Equals(lowCase) && !CheckForSymbols(words[i]))
            {
                lowerCase.Add(words[i]);
            }
            else
            {
                mixedCase.Add(words[i]);
            }
        }
        Console.WriteLine();

        Console.Write("Lower-case: ");
        Console.WriteLine(string.Join(", ", lowerCase));
        //foreach (var word in lowerCase)
        //{
        //    Console.WriteLine(string.Join(" , ", word));
        //}
        Console.Write("Mixed-case: ");
        Console.WriteLine(string.Join(", ", mixedCase));
        //foreach (var word in mixedCase)
        //{
        //    Console.WriteLine(string.Join(" , ", word));
        //}
        Console.Write("Upper-case: ");
        Console.WriteLine(string.Join(", ", upperCase));
        //foreach (var word in upperCase)
        //{
        //    Console.WriteLine(string.Join(" , ", word));
        //}
        
    }

    /// <summary>
    /// Returns true if there is a special symbol.
    /// Checks only for symbols less than 65 in the ascii table
    /// cuase all other symbols are used for split.
    /// </summary>
    /// <param name="word"></param>
    /// <returns></returns>
    private static bool CheckForSymbols(string word)
    {
        char[] symbols = word.ToCharArray();
        for (int i = 0; i < word.Length; i++)
        {
            if ((int) symbols[i] < 65)
            {
                return true;
            }
        }

        return false;
    }
}