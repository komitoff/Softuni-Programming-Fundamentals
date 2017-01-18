using System;

class SpecialNumberRefactored
{
    static void Main()
    {
        int length = int.Parse(Console.ReadLine());
        int sum = 0;
        int current = 0; 
        bool isSpecialNumber = false;
        for (int i = 1; i <= length; i++)
        {
            current = i;
            while (i > 0)
            {
                sum += i % 10;
                i = i / 10;
            }
            isSpecialNumber = (sum == 5) || (sum == 7) || (sum == 11);
            Console.WriteLine("{0} -> {1}",current ,isSpecialNumber);
            sum = 0;
            i = current;
        }

    }
}
