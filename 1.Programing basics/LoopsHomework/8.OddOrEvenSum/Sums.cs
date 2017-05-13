using System;

class Sums
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int odd = 0;
        int even = 0;
        bool flag = false;

        for (int i = 0; i < n; i++)
        {
            if (flag)
            {
                even += int.Parse(Console.ReadLine());
                flag = false;
            }
            else
            {
                odd += int.Parse(Console.ReadLine());
                flag = true;
            }
        }

        if (odd == even)
        {
            Console.WriteLine("Yes Sum = " + odd);
        }
        else
        {
            Console.WriteLine("No Diff = {0}", Math.Abs(odd - even));
        }
    }
}
