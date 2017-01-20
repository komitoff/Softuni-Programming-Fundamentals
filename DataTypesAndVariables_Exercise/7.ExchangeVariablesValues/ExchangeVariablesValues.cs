using System;

class ExchangeVariablesValues
{
    static void Main()
    {


        int a = 5;
        int b = 10;
        Console.WriteLine("Before:");
        Console.WriteLine("a = " + a);
        Console.WriteLine("b = " + b);

        //exchange their values without using third variable
        a += b;
        b = a - b;
        a = a - b;
        Console.WriteLine("After:");
        Console.WriteLine("a = " + a);
        Console.WriteLine("b = " + b);

    }
}
