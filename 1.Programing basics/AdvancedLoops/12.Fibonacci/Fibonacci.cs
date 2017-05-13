using System;

class Fibonacci
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        //Console.WriteLine(fibonacci(n));
        Console.WriteLine(iFibonacci(n));

    }


    //iteratively method
    public static int iFibonacci(int n)
    {
        int a = 0;
        int b = 1;
        
        for (int i = 1; i <= n; i++)
        {
            int temp = a;
            a = b;
            b = temp + b;
        }
        return b;
    }


    //using the recursive method
    //public static int fibonacci(int n)
    //{
    //    if (n == 0 || n == 1)
    //    {
    //        return 1;
    //    }
    //    else
    //    {
    //        return fibonacci(n - 1) + fibonacci(n - 2);
    //    }
    //}
}
