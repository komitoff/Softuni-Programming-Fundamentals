using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MaxMethod
{
    static void Main(string[] args)
    {
        int firstNumb = int.Parse(Console.ReadLine());
        int secondNumb = int.Parse(Console.ReadLine());
        int thirdNumb = int.Parse(Console.ReadLine());

        Console.WriteLine(GetMax(GetMax(firstNumb, secondNumb), thirdNumb));
    }

    /// <summary>
    /// Returns the biggest of two numbers
    /// </summary>
    /// <param name="first">Integer Number</param>
    /// <param name="second">Integer Number</param>
    /// <returns></returns>
    private static int GetMax(int first, int second)
    {
        return first > second ? first : second;
    }
}