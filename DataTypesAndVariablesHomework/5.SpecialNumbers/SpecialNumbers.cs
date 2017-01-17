using System;

class SpecialNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int m = 0;
        int sumOfDigits = 0;
        bool flag = false;

        for (int i = 0; i <= n; i++)
        {
            m = i;
            while (m != 0)
            {
                sumOfDigits += m % 10;
                m /= 10;
                if (sumOfDigits == 5 || sumOfDigits == 7 || sumOfDigits == 11)
                {
                    flag = true; 
                }
            }

            if (sumOfDigits == 5 || sumOfDigits == 7 || sumOfDigits == 11)
            {
                Console.WriteLine("{0} -> True", i);
                flag = false;
            }
            else
            {
                Console.WriteLine("{0} -> False", i);
            }

            sumOfDigits = 0;
        }
    }
}
