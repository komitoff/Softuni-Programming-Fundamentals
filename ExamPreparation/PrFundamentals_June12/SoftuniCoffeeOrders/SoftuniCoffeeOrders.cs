using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

public class SoftuniCoffeeOrders
{
    static void Main()
    {
        int count = int.Parse(Console.ReadLine());
        decimal currentPrice = 0;
        decimal totalPrice = 0;

        for (int i = 0; i < count; i++)
        {
            decimal pricePerCapsule = decimal.Parse(Console.ReadLine());
            DateTime orderDate = DateTime.ParseExact(
                Console.ReadLine(),
                "d/M/yyyy", 
                CultureInfo.InvariantCulture);

            decimal capsuleCount = decimal.Parse(Console.ReadLine());

            decimal daysInMount = DateTime.DaysInMonth(orderDate.Year, orderDate.Month);
            currentPrice = ((daysInMount * capsuleCount) * pricePerCapsule);
            totalPrice += currentPrice;
            Console.WriteLine($"The price for the coffee is: ${currentPrice:F2}");
        }

        Console.WriteLine($"Total: ${totalPrice:F2}");

        
    }
}