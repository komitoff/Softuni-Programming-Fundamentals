using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E5.FibonacciElements
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());

            Console.WriteLine(Fib(n));
        }


        /// <summary>
        /// Returns the n number from the Fibonacci sequence
        /// This method uses recursion in order to solve the problem 
        /// it is not recomended to use recursion for this problem !
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        private static long Fib(long n)
        {
            if (n == 0 || n == 1)
                return 1;
            else
                return Fib(n - 1) + Fib(n - 2);
        }
    }
}
