using System;

class Numers
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int tmp = number;
        int[] digits = new int[3];

        for (int i = 0; i < 3; i++)
        {
            digits[i] = tmp % 10;
            tmp /= 10;
        }

        int firstDigit = digits[2];
        int secondDigit = digits[1];
        int thirdDigit = digits[0];
        int n = firstDigit + secondDigit;
        int m = firstDigit + thirdDigit;

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (number % 5 == 0)
                {
                    number = number - firstDigit;
                }
                else if (number % 3 == 0)
                {
                    number = number - secondDigit;
                }
                else
                {
                    number = number + thirdDigit;
                }
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }
    }
}