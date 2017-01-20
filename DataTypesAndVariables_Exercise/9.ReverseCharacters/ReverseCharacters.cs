using System;
using System.Collections.Generic;

class ReverseCharacters
{
    static void Main()
    {
        Stack<string> letters = new Stack<string>();
        for (int i = 0; i < 3; i++)
        {
            letters.Push(Console.ReadLine());
        }

        foreach (var letter in letters)
        {
            Console.Write(letter);
        }
    }
}
