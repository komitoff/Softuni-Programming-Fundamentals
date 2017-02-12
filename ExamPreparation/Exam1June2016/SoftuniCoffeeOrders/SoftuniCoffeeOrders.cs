using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

public class SoftuniCoffeeOrders
{
    static void Main()
    {
        long count = long.Parse(Console.ReadLine());
        decimal total = 0;
        decimal currentOrderPrice = 0;
        for (int i = 0; i < count; i++)
        {
            decimal pricePerCapsule = decimal.Parse(Console.ReadLine());
            DateTime orderDate = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);
            long capsuleCount = long.Parse(Console.ReadLine());
            long daysInMonth = DateTime.DaysInMonth(orderDate.Year, orderDate.Month);
            currentOrderPrice = ((daysInMonth * capsuleCount) * pricePerCapsule);
            total += currentOrderPrice;
            Console.WriteLine($"The price for the coffee is: ${currentOrderPrice:f2}");
        }

        Console.WriteLine($"Total: ${total:f2}");

    }
}