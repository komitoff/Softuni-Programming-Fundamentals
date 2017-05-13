using System;

class Vacation
{
    static void Main()
    {
        double oldPpl = double.Parse(Console.ReadLine());
        double students = double.Parse(Console.ReadLine());
        double nights = double.Parse(Console.ReadLine());
        string transport = Console.ReadLine();

        double transportPrice = 0;
        double hotelPrice = 0;
        double totalPrice = 0;

        if (oldPpl + students == 0)
        {
            Console.WriteLine("0");
        }
        if (transport.Equals("train"))
        {
            transportPrice = 2* ((oldPpl * 24.99) + (students * 14.99));
            hotelPrice = nights * 82.99;
            
            if (oldPpl + students >= 50)
            {
                transportPrice = transportPrice / 2;
            }
            totalPrice = 1.1 * (transportPrice + hotelPrice);
            Console.WriteLine("{0:F2}", totalPrice);
        }
        else if (transport.Equals("bus"))
        {
            transportPrice = 2*((oldPpl * 32.50) + (students * 28.5));
            hotelPrice = nights * 82.99;
            totalPrice = 1.1 * (transportPrice + hotelPrice);
            Console.WriteLine("{0:F2}", totalPrice);
        }
        else if (transport.Equals("boat"))
        {
            transportPrice = 2*((oldPpl * 42.99) + (students * 39.99));
            hotelPrice = nights * 82.99;
            totalPrice = 1.1 * (transportPrice + hotelPrice);
            Console.WriteLine("{0:F2}", totalPrice);
        }
        else if (transport.Equals("airplane"))
        {
            transportPrice = 2 * (oldPpl * 70 + students * 50);
            hotelPrice = nights * 82.99;
            totalPrice = 1.1 * (transportPrice + hotelPrice);
            Console.WriteLine("{0:F2}", totalPrice);
        }
    }
}