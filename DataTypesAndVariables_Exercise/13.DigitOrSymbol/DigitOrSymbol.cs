using System;
using System.Text;

class DigitOrSymbol
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine().ToLower();

        byte[] asciiValue = Encoding.ASCII.GetBytes(input.ToCharArray());

        //check if it is vowel
        if (asciiValue[0] == 97   ||
            asciiValue[0] == 101  ||
            asciiValue[0] == 111  ||
            asciiValue[0] == 105  ||
            asciiValue[0] == 117  ||
            asciiValue[0] == 121)
        {
            Console.WriteLine("vowel");
        }
        else if (asciiValue[0] >= 48 || asciiValue[0] <= 57)
        {
            Console.WriteLine("digit");
        }
        else
        {
            Console.WriteLine("other");
        }


    }
}
