using System;

class HotelRoom
{
    static void Main()
    {
        string month = Console.ReadLine();
        int nights = int.Parse(Console.ReadLine());
        double studio = 0;
        double flat = 0;
        double totalStudio = 0;
        double totalFlat = 0;

        if (month.Equals("May") ||  month.Equals("October"))
        {
            studio = 50;
            flat = 65;
            if (nights > 7 && nights <= 14)
            {
                studio *= 0.95;
            }
            else if (nights > 14)
            {
                studio *= 0.7;
                flat *= 0.9;
            }

            totalStudio = nights * studio;
            totalFlat = nights * flat;
        }
        else if(month.Equals("June") || month.Equals("September"))
        {
            studio = 75.2;
            flat = 68.7;
            if (nights > 14)
            {
                studio *= 0.8;
                flat *= 0.9;
            }

            totalFlat = nights * flat;
            totalStudio = nights * studio;
        }
        else
        {
            studio = 76;
            flat = 77;
            if (nights > 14)
            {
                flat *= 0.9;
            }

            totalFlat = nights * flat;
            totalStudio = nights * studio;
        }

        Console.WriteLine("Apartment: {0:F2} lv.", totalFlat);
        Console.WriteLine("Studio: {0:F2} lv.", totalStudio);
    }
}
