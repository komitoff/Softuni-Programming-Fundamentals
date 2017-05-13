using System;

class DateAfterFiveDays
{
    static void Main(string[] args)
    {
        int day = int.Parse(Console.ReadLine());
        int month = int.Parse(Console.ReadLine());

        if (month == 4 || month == 6 || month == 9 || month == 11)
        {
            if (day + 5 > 30)
            {
                month++;
                day = day + 5 - 30;
            }
            else
            {
                day += 5;
            }
        }
        else if (month == 2)
        {
            if (day + 5 > 28)
            {
                month++;
                day = day + 5 - 28;
            }
            else
            {
                day += 5;
            }
        }
        else if (month == 12)
        {
            if (day + 5 > 31)
            {
                month = 1;
                day = day + 5 - 31;
            }
            else
            {
                day += 5;
            }
        }
        else
	    {
            if (day + 5 > 31)
            {
                month++;
                day = day + 5 - 31;
            }
            else
            {
                day += 5;
            }
	    }


        if (month < 10)
        {
            Console.WriteLine("{0}.0{1}", day, month);
        }
        else
        {
            Console.WriteLine("{0}.{1}", day, month);
        }
    }
}
