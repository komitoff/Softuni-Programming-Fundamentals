using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

class Converter
{
    static void Main()
    {
        string[] numberAndBase = Console.ReadLine().Split();
        int currentBase = int.Parse(numberAndBase[0]);
        BigInteger number = BigInteger.Parse(numberAndBase[1]);

        BigInteger dec = ConvertToDecimal(number, currentBase);
        Console.WriteLine(dec);
    }

    private static BigInteger ConvertToDecimal(BigInteger number, int currentBase)
    {
        BigInteger dec = 0;
        int i = 0;
        if (currentBase >= 2 && currentBase <= 10)
        {
            while (number > 0)
            {
                dec += (number % 10) * (BigInteger)(Math.Pow(currentBase, i));
                number /= 10;
                i++;
            }
        }

        return dec;
    }
}