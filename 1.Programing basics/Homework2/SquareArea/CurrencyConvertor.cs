using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        double amount = double.Parse(Console.ReadLine());
        string inputValue = Console.ReadLine();
        string outputValue = Console.ReadLine();
        double finalValue = 0;

        Dictionary<String, double> rates = new Dictionary<string, double>();
        rates["BGN"] = 1;
        rates["USD"] = 1.79549;
        rates["EUR"] = 1.95583;
        rates["GBP"] = 2.53405;

        double convertedToLevas = amount * rates[inputValue];
        finalValue = convertedToLevas * (1 / rates[outputValue]);
       
        Console.WriteLine(Math.Round(finalValue, 2) + " " + outputValue);
    }
}