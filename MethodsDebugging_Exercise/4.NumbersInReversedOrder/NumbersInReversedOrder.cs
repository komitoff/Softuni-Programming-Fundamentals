using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class NumbersInReversedOrder
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        Console.WriteLine(Reverse(input));
    }

    /// <summary>
    /// Returns reversed string
    /// </summary>
    /// <param name="input">String parameter</param>
    /// <returns></returns>
    private static string Reverse(string input)
    {
        char[] output = input.ToCharArray();
        Array.Reverse(output);
        return new string(output);
    }
}