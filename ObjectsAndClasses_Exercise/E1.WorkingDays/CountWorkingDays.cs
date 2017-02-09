using System;
using System.Collections.Generic;
using System.Globalization;
public class CountWorkingDays
{
    static void Main()
    {
        string start = Console.ReadLine();
        string end = Console.ReadLine();

        DateTime startDate = DateTime.ParseExact(start, "dd-MM-yyyy", CultureInfo.InvariantCulture);
        DateTime endDate = DateTime.ParseExact(end, "dd-MM-yyyy", CultureInfo.InvariantCulture);
        List<DateTime> holydays = new List<DateTime>();
        holydays.Add(DateTime.ParseExact("01-01-2015", "dd-MM-yyyy", CultureInfo.InvariantCulture));
        holydays.Add(DateTime.ParseExact("03-03-2015", "dd-MM-yyyy", CultureInfo.InvariantCulture));
        holydays.Add(DateTime.ParseExact("01-05-2015", "dd-MM-yyyy", CultureInfo.InvariantCulture));
        holydays.Add(DateTime.ParseExact("06-05-2015", "dd-MM-yyyy", CultureInfo.InvariantCulture));
        holydays.Add(DateTime.ParseExact("24-05-2015", "dd-MM-yyyy", CultureInfo.InvariantCulture));
        holydays.Add(DateTime.ParseExact("06-09-2015", "dd-MM-yyyy", CultureInfo.InvariantCulture));
        holydays.Add(DateTime.ParseExact("22-09-2015", "dd-MM-yyyy", CultureInfo.InvariantCulture));
        holydays.Add(DateTime.ParseExact("01-11-2015", "dd-MM-yyyy", CultureInfo.InvariantCulture));
        holydays.Add(DateTime.ParseExact("24-12-2015", "dd-MM-yyyy", CultureInfo.InvariantCulture));
        holydays.Add(DateTime.ParseExact("25-12-2015", "dd-MM-yyyy", CultureInfo.InvariantCulture));
        holydays.Add(DateTime.ParseExact("26-12-2015", "dd-MM-yyyy", CultureInfo.InvariantCulture));

        for (DateTime i = startDate.d; i <= endDate; i++)
        {

        }

    }
}