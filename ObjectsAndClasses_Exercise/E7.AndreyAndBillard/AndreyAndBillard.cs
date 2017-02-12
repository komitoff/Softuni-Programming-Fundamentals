using System;
using System.Collections.Generic;
using System.Linq;

public class AndreyAndBillard
{
    static void Main()
    {
        int count = int.Parse(Console.ReadLine());
        Dictionary<string, decimal> menuPrices = 
            new Dictionary<string, decimal>();

        Dictionary<string, Dictionary<string, decimal>> clientOrders = 
            new Dictionary<string, Dictionary<string, decimal>>();

        decimal totalBill = 0;

        for (int i = 0; i < count; i++)
        {
            string[] productInfo = Console.ReadLine().Split('-');
            string productName = productInfo[0];
            decimal price = decimal.Parse(productInfo[1]);

            if (!menuPrices.ContainsKey(productName))
            {
                menuPrices[productName] = 0;
            }
            menuPrices[productName] = price;
        }

        string clients = Console.ReadLine();

        while (!clients.Equals("end of clients"))
        {
            string[] clientInfo = clients.Split(new char[] { '-', ',' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            string clientName = clientInfo[0];
            string order = clientInfo[1];
            int amount = int.Parse(clientInfo[2]);

            if (!clientOrders.ContainsKey(clientName) && menuPrices.ContainsKey(order))
            {
                clientOrders[clientName] = new Dictionary<string, decimal>();
                if (!clientOrders[clientName].ContainsKey(order))
                {
                    clientOrders[clientName][order] = amount;
                }
            }
            
            clients = Console.ReadLine();
        }

        foreach (var order in clientOrders.OrderBy(c => c.Key))
        {
            string clientName = order.Key;
            Dictionary<string, decimal> bill = order.Value;
            foreach (var item in bill)
            {
                decimal amount = item.Value;
                decimal productPrice = menuPrices[item.Key];
                if (menuPrices.ContainsKey(item.Key))
                {
                    Console.WriteLine(clientName);
                }
                Console.WriteLine($"-- {item.Key} - {item.Value}");
                Console.WriteLine($"Bill: {amount*productPrice:f2}");
                totalBill += amount * productPrice;
            }
        }
        Console.WriteLine($"Total bill: {totalBill:f2}");
    }
}