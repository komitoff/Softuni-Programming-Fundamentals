using System;

class IntegerToHexAndBinary
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());
        string hex = Convert.ToString(input, 16);
        string binary = Convert.ToString(input, 2);
        Console.WriteLine(hex.ToUpper());
        Console.WriteLine(binary.ToUpper());
    }
}
