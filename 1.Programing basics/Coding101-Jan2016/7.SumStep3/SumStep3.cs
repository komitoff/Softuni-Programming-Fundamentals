using System;

    class SumStep3
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int sum1 = 0;
            int sum2 = 0;
            int sum3 = 0;
            int count1 = 0;
            int count2 = 1;
            int count3 = 2;

            for (int i = 0; i < n; i++)
            {
                int numb = int.Parse(Console.ReadLine());
                if (i == count1)
                {
                    sum1 += numb;
                    count1 += 3;
                }
                else if (i == count2)
                {
                    sum2 += numb;
                    count2 += 3;
                }
                else if (i == count3)
                {
                    count3 += 3;
                    sum3 += numb;
                }
            }

            Console.WriteLine("sum1 = " + sum1);
            Console.WriteLine("sum2 = " + sum2);
            Console.WriteLine("sum3 = " + sum3);
        }
    }