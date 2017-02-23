using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class SweetDesert
{
    static void Main()
    {
        decimal cashAmount = decimal.Parse(Console.ReadLine());
        int numberOfGuests = int.Parse(Console.ReadLine());
        decimal bananasPrice = decimal.Parse(Console.ReadLine());
        decimal eggsPrice = decimal.Parse(Console.ReadLine());
        decimal berriesPrice = decimal.Parse(Console.ReadLine());

        int portions = (numberOfGuests / 6 );
        if (numberOfGuests % 6 != 0)
            portions += 1;

        decimal bananaNeeded = 2m * portions;
        decimal eggsNeeded = 4m * portions;
        decimal berriesNeeded = 0.2m * portions;
        decimal moneyNeeded = (bananaNeeded * bananasPrice) + (eggsNeeded * eggsPrice) + (berriesNeeded * berriesPrice);
        
        if (moneyNeeded <= cashAmount)
            Console.WriteLine($"Ivancho has enough money - it would cost {moneyNeeded:F2}lv.");
        else
            Console.WriteLine($"Ivancho will have to withdraw money - he will need {(moneyNeeded - cashAmount):F2}lv more.");
    }
}