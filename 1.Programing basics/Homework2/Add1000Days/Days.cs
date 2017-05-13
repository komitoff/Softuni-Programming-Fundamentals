using System;
using System.Globalization;

class Days
{
    static void Main()
    {
        string input = Console.ReadLine();
        DateTime time = DateTime.ParseExact(input, "dd-MM-yyyy", CultureInfo.InvariantCulture);
        DateTime newDate = time.AddDays(999);
        Console.WriteLine(newDate.ToString("dd-MM-yyyy"));
    }
}
