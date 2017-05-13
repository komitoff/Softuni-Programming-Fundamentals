using System;

class CheckPrime
{
    static void Main(string[] args)
    {
        double n = double.Parse(Console.ReadLine());
        double count = 0;

        for (double i = 2; i <= n; i++)
        {
            if (n % i == 0)
            {
                count++;
                if (count > 1)
                {
                    break;
                }
            }
        }
        if (count > 1 || n < 2)
        {
            Console.WriteLine("Not Prime");
        }
        else
        {
            Console.WriteLine("Prime");
        }

    }
}
