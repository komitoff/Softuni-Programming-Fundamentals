using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class SalesReport
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        Sale[] sales = new Sale[n];
        for (int i = 0; i < n; i++)
        {
            sales[i] = readSale();
        }
        SortedDictionary<string, decimal> salesByTown = new SortedDictionary<string, decimal>();
        for (int i = 0; i < n; i++)
        {
            if (!salesByTown.ContainsKey(sales[i].town))
            {
                salesByTown.Add(sales[i].town, 0);
            }

            salesByTown[sales[i].town] += sales[i].price * sales[i].quantity;
        }
        foreach (var town in salesByTown)
        {
            Console.WriteLine($"{town.Key} -> {town.Value:f2}");
        }
    }

    private static Sale readSale()
    {

        string[] sale = Console.ReadLine().Split().ToArray();
        Sale singleSale = new Sale() { town = sale[0], product = sale[1], price = decimal.Parse(sale[2]), quantity = decimal.Parse(sale[3]) };
        return singleSale;
    }
}

class Sale
{
    public string town { get; set; }
    public string product { get; set; }
    public decimal price { get; set; }
    public decimal quantity { get; set; }
}