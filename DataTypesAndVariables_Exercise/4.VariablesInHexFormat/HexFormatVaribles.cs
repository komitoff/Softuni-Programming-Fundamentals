using System;

class HexFormatVaribles
{
    static void Main()
    {
        string input = Console.ReadLine();

        int decimalFormat = Convert.ToInt32(input, 16);
        Console.WriteLine(decimalFormat);
    }
}
