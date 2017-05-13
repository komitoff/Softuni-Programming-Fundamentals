using System;

class EnterEvenNumber
{
    static void Main(string[] args)
    {
        bool flag = true;
        while (flag)
        {

            Console.Write("Enter even number:");
            string input = Console.ReadLine();
            int n = 0;
            try
            {
                n = int.Parse(input);
                if (n % 2 == 0)
                {
                    Console.WriteLine("Even number entered: " + n);
                    flag = false;
                }
                else
                {
                    Console.WriteLine("The number is not even.");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid number!");
            }

            

        }
    }
}
