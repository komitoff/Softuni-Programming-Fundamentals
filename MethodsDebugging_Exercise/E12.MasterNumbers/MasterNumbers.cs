using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MasterNumbers
{
    static void Main(string[] args)
    {
        int input = int.Parse(Console.ReadLine());
        List<int> masterNumbers = new List<int>();
        for (int i = 1; i <= input; i++)
        {
            if (ContainsEvenDigit(i))
            {
                if (SumOfDigits(i))
                {
                    if (IsSymetric(i))
                    {
                        masterNumbers.Add(i);
                    }
                }
            }
        }

        foreach (int number in masterNumbers)
        {
            Console.WriteLine(number);
        }
    }

    private static bool IsSymetric(int input)
    {
        string number = input.ToString();
        char[] digits = number.ToCharArray();
        for (int i = 0; i < digits.Length / 2; i++)
        {
            if (digits[i] != digits[digits.Length - i - 1])
            {
                return false;
            }
        }
        return true;
        
    }

    private static bool SumOfDigits(int input)
    {
        int sum = 0;
        while (input > 0)
        {
            sum += input % 10;
            input /= 10;
        }
        if (sum % 7 == 0)
            return true;
        else
            return false;
    }

    private static bool ContainsEvenDigit(int input)
    {
        int digit = 0;
        while (input > 0)
        {
            digit = input % 10;
            if (digit % 2 == 0)
                return true;
            input /= 10;
        }
        return false;
    }
}