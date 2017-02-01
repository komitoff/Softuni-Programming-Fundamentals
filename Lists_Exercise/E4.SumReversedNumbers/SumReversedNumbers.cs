using System;
using System.Collections.Generic;
using System.Linq;

class SumReversedNumbers
{
    static void Main()
    {
        List<string> inputNumbers = Console.ReadLine().Split(' ').ToList();
        List<int> reversedNumbers = new List<int>();
        int sum = 0;
        for (int i = 0; i < inputNumbers.Count; i++)
        {
            int number = Reverse(inputNumbers[i]);
            reversedNumbers.Add(number);
            sum += reversedNumbers[i];
        }
        
        Console.WriteLine(sum);


    }

    private static int Reverse(string input)
    {
        char[] symbols = input.ToCharArray();
        Array.Reverse(symbols);
        string reversedInput = new string(symbols);
        int result = int.Parse(reversedInput);
        return result;
    }
}