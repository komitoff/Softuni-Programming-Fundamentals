using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class ReverseString
{
    static void Main()
    {
        string input = Console.ReadLine();
        char[] letters = input.ToCharArray();
        Array.Reverse(letters);
        string reversed = new string(letters);
        Console.WriteLine(reversed);

    }
}
