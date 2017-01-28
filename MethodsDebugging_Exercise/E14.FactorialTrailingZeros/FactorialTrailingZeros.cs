using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


class FactorialTrailingZeros
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        BigInteger factorial = FactorialNumber(n);
        Console.WriteLine(TrailingZeros(factorial));
    }

    private static int TrailingZeros(BigInteger number)
    {

        string factorial = number.ToString();
        MatchCollection zeros = Regex.Matches(factorial, "0+$");
        StringBuilder matches = new StringBuilder();
        foreach (var zero in zeros)
        {
            matches.Append(zero);
        }
        string trailingZeros = matches.ToString();
        return trailingZeros.Length;
    }

    private static BigInteger FactorialNumber(int n)
    {
        BigInteger factorial = 1;
        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
        }

        return factorial;
    }
}
