using System;

class Sale
{
    public string Town { get; set; }
    public string Stock { get; set; }
    public decimal Price { get; set; }
    public decimal Quantity { get; set; }

    public Sale ReadSale(string input)
    {
        string[] items = input.Split(' ');
        return new Sale()
        {
            Town = items[0],
            Stock = items[1],
            Price = decimal.Parse(items[2]),
            Quantity = decimal.Parse(items[3])
        };
    }

}

