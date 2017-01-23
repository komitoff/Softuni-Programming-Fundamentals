using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class GreaterOfTwoValues
{
    static void Main(string[] args)
    {
        string dataType = Console.ReadLine().ToLower();
        if (dataType.Equals("int"))
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            Console.WriteLine(GetMax(first, second));
        }
        else if (dataType.Equals("char"))
        {
            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());
            Console.WriteLine(GetMax(first, second));
        }
        else if(dataType.Equals("string"))
        {
            string first = Console.ReadLine();
            string second = Console.ReadLine();
            Console.WriteLine(GetMax(first, second));
        }
    }


    /// <summary>
    /// Return biggest of two integer numbers
    /// </summary>
    /// <param name="first">Integer number</param>
    /// <param name="second">Integer number</param>
    /// <returns></returns>
    private static int GetMax(int first, int second)
    {
        return Math.Max(first, second);
    }
    
    /// <summary>
    /// Returns biggest of the character numbers (Alphabetically)
    /// </summary>
    /// <param name="first">Char parameter</param>
    /// <param name="second">Char parameter</param>
    /// <returns></returns>
    private static char GetMax(char first, char second)
    {
        return first.CompareTo(second) > 0 ? first : second;
    }

    /// <summary>
    /// Returns biggest of two strings 
    /// </summary>
    /// <param name="first">string parameter</param>
    /// <param name="second">string parameter</param>
    /// <returns></returns>
    private static string GetMax(string first, string second)
    {
        return first.CompareTo(second) > 0 ? first : second;
    }
}
