using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class EnglishNameOfLastDigit
{
    static void Main(string[] args)
    {
        long number = long.Parse(Console.ReadLine());
        Console.WriteLine(GetNameOFLastDigit(Math.Abs(number)));
    }

    /// <summary>
    /// Returns the english name of the last digit of given number
    /// </summary>
    /// <param name="number"></param>
    /// <returns></returns>
    private static string GetNameOFLastDigit(long number)
    {
        long lastDigit = number % 10;

        switch (lastDigit)
        {
            case 0: return "zero"; break;
            case 1: return "one"; break;
            case 2: return "two"; break;
            case 3: return "three"; break;
            case 4: return "four"; break;
            case 5: return "five"; break;
            case 6: return "six"; break;
            case 7: return "seven"; break;
            case 8: return "eight"; break;
            case 9: return "nine"; break;
            default: return null; break;
        }
    }
}