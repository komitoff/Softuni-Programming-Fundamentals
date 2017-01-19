using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumHelp
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int sum = 0;

            for (int i = 0; i < input.Length; i++)
            {
                sum += int.Parse(reverse(input[i]));
            }

            Console.WriteLine(sum);
        }

        ////Method using LINQ
        //public static string reverse(string input)
        //{
        //    return new string(input.ToCharArray().Reverse().ToArray());
        //}


        public static string reverse(string input)
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
