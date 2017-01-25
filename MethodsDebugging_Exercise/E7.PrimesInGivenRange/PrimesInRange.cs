using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class PrimesInRange
{
    static void Main(string[] args)
    {
        int start = int.Parse(Console.ReadLine());
        int end = int.Parse(Console.ReadLine());
        List<int> primeNumbers = PrimeNumbersInGivenRange(start, end);
        StringBuilder sb = new StringBuilder();
        if (end > start && primeNumbers.Count > 0)
        {
            foreach (var prime in primeNumbers)
            {
                sb.Append(prime + ", ");
            }

            sb.Remove(sb.Length - 2, 2);
            Console.WriteLine(sb.ToString());
        }
    }

    /// <summary>
    /// Returns true if the given number is prime
    /// and false, if it is not.
    /// </summary>
    /// <param name="number">Integer parameter</param>
    /// <returns></returns>
    private static bool IsPrime(int number)
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

    /// <summary>
    /// Returns a lits of prime numbers in given range
    /// </summary>
    /// <param name="start">Integer parameter</param>
    /// <param name="end">Integer parameter</param>
    /// <returns></returns>
    private static List<int> PrimeNumbersInGivenRange(int start, int end)
    {
        List<int> primes = new List<int>();
        for (int i = start; i <= end; i++)
        {
            if (IsPrime(i))
            {
                primes.Add(i);
            }
        }

        return primes;
    }

}

