using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class IndexOfLetters
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        char[] letters = input.ToCharArray();
        for (int i = 0; i < letters.Length; i++)
        {
            int position = (int)letters[i] - 97;
            Console.WriteLine($"{letters[i]} -> {position}");
        }
        
    }
}
