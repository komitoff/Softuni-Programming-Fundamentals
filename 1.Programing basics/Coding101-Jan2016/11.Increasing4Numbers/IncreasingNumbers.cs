using System;

class IncreasingNumbers
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        int count = 0;
        for (int i = a; i <= b; i++)
        {
            for (int j = a; j <= b; j++)
            {
                for (int k = a; k <= b; k++)
                {
                    for (int m = a; m <= b; m++)
                    {
                        if (i < j && j < k && k < m)
                        {
                            //in the task
                            //Console.WriteLine("{0}{1}{2}{3}", i, j, k, m);
                            //in the judge o.O
                            Console.WriteLine(i);
                            Console.WriteLine(j);
                            Console.WriteLine(k);
                            Console.WriteLine(m);
                            count++;
                        }
                    }
                }
            }
        }
        if (count == 0)
        {
            Console.WriteLine("No");
        }
    }
}
