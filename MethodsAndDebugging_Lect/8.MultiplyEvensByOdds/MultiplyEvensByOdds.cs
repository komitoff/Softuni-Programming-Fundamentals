using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MultiplyEvensByOdds
{
    static void Main(string[] args)
    {
        int input = int.Parse(Console.ReadLine());
        Console.WriteLine(GetMultipleOfEvenAndOdds(Math.Abs(input)));
    }

    /// <summary>
    /// Returns the multiple of the summ of all even and odd digits
    /// </summary>
    /// <param name="input">Integer number</param>
    /// <returns></returns>
    private static int GetMultipleOfEvenAndOdds(int input)
    {
        return GetSumOfEvenDigits(input) * GetSumOfOddDigits(input);
    }

    /// <summary>
    /// Returns the summ of all even digits in the given number
    /// </summary>
    /// <param name="n">Integer number</param>
    /// <returns></returns>
    private static int GetSumOfEvenDigits(int n)
    {
        int sum = 0;

        while (n > 0)
        {
            if (n % 2 == 0)
            {
                sum += (n % 10);
            }
            n /= 10;
        }
        return sum;
    }

    /// <summary>
    /// Returns the sum of all odd digits in the given number
    /// </summary>
    /// <param name="n">Integer number</param>
    /// <returns></returns>
    private static int GetSumOfOddDigits(int n)
    {
        int sum = 0;
        while (n > 0)
        {
            if (n % 2 != 0)
            {
                sum += (n % 10);
            }
            n /= 10;
        }
        return sum;
    }
}