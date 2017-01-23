using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MathPower
{
    static void Main(string[] args)
    {
        double number = double.Parse(Console.ReadLine());
        int power = int.Parse(Console.ReadLine());

        Console.WriteLine(GetPoweredNumber(number, power));
    }
    

    /// <summary>
    /// Returns specified number raised to the specified power
    /// </summary>
    /// <param name="number">Double precision floating point number</param>
    /// <param name="power">Integer number</param>
    /// <returns></returns>
    private static double GetPoweredNumber(double number, int power)
    {
        double result = 1;
        for (int i = 1; i <= power; i++)
        {
            result *= number;
        }

        return result;
    }
}