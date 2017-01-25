using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class PrimeChecker
{
    static void Main(string[] args)
    {
        long input = long.Parse(Console.ReadLine());

        Console.WriteLine(IsPrime(input));

    }


    /// <summary>
    /// Returns true if the given number is prime
    /// and false, if it is not.
    /// </summary>
    /// <param name="number"></param>
    /// <returns></returns>
    private static bool IsPrime(long number)
    {
        var boundary = (long)Math.Floor(Math.Sqrt(number));
        if (number == 0 || number == 1)
            return false;
        for (int i = 2; i <= boundary; i++)
        {
            if (number % i == 0)
            {
                return false;
            }
        }
        return true;
    }
}