using System;

class MagicalNumbers
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
                    for (int l = 1; l < 10; l++)
                    {
                        for (int m = 1; m < 10; m++)
                        {
                            for (int v = 1; v < 10; v++)
                            {
                                if (i*j*k*l*m*v == n)
                                {
                                    Console.Write("{0}{1}{2}{3}{4}{5} ", i, j, k, l, m, v);
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
