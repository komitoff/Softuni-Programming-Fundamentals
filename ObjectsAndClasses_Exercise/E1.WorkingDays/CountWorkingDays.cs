using System;
using System.Collections.Generic;
using System.Globalization;
public class CountWorkingDays
{
    static void Main()
    {
        string start = Console.ReadLine();
        string end = Console.ReadLine();
        long holydaysCounter = 0;
        DateTime startDate = DateTime.ParseExact(start, "dd-MM-yyyy", CultureInfo.InvariantCulture);
        DateTime endDate = DateTime.ParseExact(end, "dd-MM-yyyy", CultureInfo.InvariantCulture);
        List<DateTime> holydays = new List<DateTime>();
        holydays.Add(DateTime.ParseExact("01-01-2016", "dd-MM-yyyy", CultureInfo.InvariantCulture));
        holydays.Add(DateTime.ParseExact("03-03-2016", "dd-MM-yyyy", CultureInfo.InvariantCulture));
        holydays.Add(DateTime.ParseExact("01-05-2016", "dd-MM-yyyy", CultureInfo.InvariantCulture));
        holydays.Add(DateTime.ParseExact("06-05-2016", "dd-MM-yyyy", CultureInfo.InvariantCulture));
        holydays.Add(DateTime.ParseExact("24-05-2016", "dd-MM-yyyy", CultureInfo.InvariantCulture));
        holydays.Add(DateTime.ParseExact("06-09-2016", "dd-MM-yyyy", CultureInfo.InvariantCulture));
        holydays.Add(DateTime.ParseExact("22-09-2016", "dd-MM-yyyy", CultureInfo.InvariantCulture));
        holydays.Add(DateTime.ParseExact("01-11-2016", "dd-MM-yyyy", CultureInfo.InvariantCulture));
        holydays.Add(DateTime.ParseExact("24-12-2016", "dd-MM-yyyy", CultureInfo.InvariantCulture));
        holydays.Add(DateTime.ParseExact("25-12-2016", "dd-MM-yyyy", CultureInfo.InvariantCulture));
        holydays.Add(DateTime.ParseExact("26-12-2016", "dd-MM-yyyy", CultureInfo.InvariantCulture));

        for (DateTime currentDate = startDate; currentDate <= endDate; currentDate = currentDate.AddDays(1))
        {
            DateTime checkDate = new DateTime(2016, currentDate.Month, currentDate.Day);
            if (!holydays.Contains(checkDate) && currentDate.DayOfWeek != DayOfWeek.Sunday && currentDate.DayOfWeek != DayOfWeek.Saturday)
            {
                holydaysCounter++;
            }
        }
        Console.WriteLine(holydaysCounter);
    }
}