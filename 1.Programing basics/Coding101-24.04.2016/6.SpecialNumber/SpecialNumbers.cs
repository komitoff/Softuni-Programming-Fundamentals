using System;

class SpecialNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i < 10; i++)
        {
            for (int j = 1; j < 10; j++)
            {
                for (int k = 1; k < 10; k++)
                {
                    for (int m = 1; m < 10; m++)
                    {
                        if (n % i == 0 && n % j == 0 && n % k == 0 && n % m == 0)
                        {
                            Console.Write("{0}{1}{2}{3} ", i, j, k, m);
                        }
                    }
                }
            }
        }
    }
}
