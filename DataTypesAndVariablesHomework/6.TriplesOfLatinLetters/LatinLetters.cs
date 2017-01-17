using System;

class LatinLetters
{
    static void Main()
    {
        int nn = int.Parse(Console.ReadLine());

        char n = Convert.ToChar(nn + 97);

        //print all the couples of latin letters
        for (char i = 'a'; i < n; i++)
        {
            for (char j = 'a'; j < n; j++)
            {
                for (char k = 'a'; k < n; k++)
                {
                    Console.WriteLine("{0}{1}{2}", i, j, k);
                }
            }
        }
    }
}
