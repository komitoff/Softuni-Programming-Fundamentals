using System;

class PyramidNumbers
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        bool flag = true;
        int j = 2;
        int printNumber = 1;

        while (flag)
        {
            for (int i = 1; i < j; i++)
            {
                if (printNumber > n)
                {
                    flag = false;
                    break;
                }
                else
                {
                    Console.Write(printNumber + " ");
                    printNumber += 1;
                }
            }
            j++;
            Console.WriteLine();
        }
    }
}
