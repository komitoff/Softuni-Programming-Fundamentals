using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class DayOfWeek
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(Day(n));
    }

    private static string Day(int n)
    {
        if (n > 7 || n < 0) return "Invalid Day!.";
        string[] days = { "Invalid Day!.",
                           "Monday",
                           "Tuesday",
                           "Wednesday",
                           "Thursday",
                           "Friday",
                           "Saturday",
                           "Sunday"};
        return days[n];
    }
}