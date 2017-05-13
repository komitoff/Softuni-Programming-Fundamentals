using System;

class Cinema
{
    static void Main()
    {
        string type = Console.ReadLine();
        double rows = double.Parse(Console.ReadLine());
        double cols = double.Parse(Console.ReadLine());

        double ticket = -1;

        if (type == "Premiere")
        {
            ticket = 12.00;
        }
        else if (type == "Normal")
        {
            ticket = 7.5;
        }
        else if (type == "Discount")
        {
            ticket = 5.00;
        }

        if (ticket > 0 )
        {
            Console.WriteLine("{0:f2} leva", Math.Round((ticket * rows * cols), 2));
        }
        else
        {
            Console.WriteLine("error");
        }
    }
}