// Write a program that finds all prime numbers in the range [1...10 000 000]. 
// Use the sieve of Eratosthenes algorithm (find it in Wikipedia).

using System;

class SieveOfEratosthenes
{
    static void Main()
    {
        uint range = uint.Parse(Console.ReadLine());
        bool[] prime = new bool[range + 1];

        for (uint i = 2; i <= range; i++)
        {
            prime[i] = true;
        }
        
        for (uint j = 2; j <= range; j++)
        {
            if (prime[j])
            {
                for (uint p = 2; (p * j) <= range; p++)
                {
                    prime[p * j] = false;
                }
            }
        }

        int countPrimes = 0;
        for (int i = 0; i <= range; i++)
        {
            if (prime[i])
            {
                countPrimes++;
            }
        }
        
        uint tenNumbers = 0;
        for (uint i = 0; i <= range; i++)
        {
            if (prime[i])
            {
                Console.Write(i + " ");
                tenNumbers++;
            }
            if (tenNumbers == 10 || i == range)
            {
                Console.WriteLine();
                tenNumbers = 0;
            }
        }
    }
}