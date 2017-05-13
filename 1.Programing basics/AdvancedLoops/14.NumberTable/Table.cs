using System;

class Table
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        int row = n;
        int col = row;
        int num = 0;

        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                num = i + j + 1;
                if (num > n)
                {
                    int tmp  = 2 * n - num;
                    Console.Write(tmp + " ");
                }
                else
                {
                    Console.Write(num + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
