using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

class DayOfWeek
{
    static void Main()
    {
        string inputDate = Console.ReadLine();

        var date = DateTime.ParseExact(inputDate, "d-M-yyyy", CultureInfo.InvariantCulture);
        Console.WriteLine(date.DayOfWeek);
    }
}