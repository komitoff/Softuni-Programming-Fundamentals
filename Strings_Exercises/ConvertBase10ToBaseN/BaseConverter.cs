using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

public class BaseConverter
{
    static void Main()
    {
        string[] numberAndBase = Console.ReadLine().Split();
        BigInteger number = BigInteger.Parse(numberAndBase[1]);
        BigInteger nBase = BigInteger.Parse(numberAndBase[0]);
        StringBuilder output = ConvertToNBase(number, nBase);
        Console.WriteLine(output);
    }

    private static StringBuilder ConvertToNBase(BigInteger number, BigInteger nBase)
    {
        StringBuilder result = new StringBuilder();
        List<BigInteger> rem = new List<BigInteger>();
        if (nBase > 0)
        {
            while (number > 0)
            {
                rem.Add(number % nBase);
                number /= nBase;
            }
            for (int i = rem.Count - 1; i >= 0; i--)
            {
                result.Append(rem[i]);
            }
        }
        return result;
    }
}