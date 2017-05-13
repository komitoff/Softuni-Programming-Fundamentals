using System;

class NumberInRange
{
    static void Main(string[] args)
    {
        Console.Write("Еnter a number in the range [1...100]:");
        int number = int.Parse(Console.ReadLine());
        bool flag = true;

        while (flag)
        {
            if (number > 0 && number <= 100)
            {
                Console.WriteLine("The number is: " + number);
                flag = false;
            }
            else
            {
                Console.Write("Еnter a number in the range [1...100]:");
                number = int.Parse(Console.ReadLine());
            }
        }
    }
}
