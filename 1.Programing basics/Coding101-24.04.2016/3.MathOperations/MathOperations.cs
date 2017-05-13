using System;

class MathOperations
{
    static void Main()
    {
        double firstNumb = double.Parse(Console.ReadLine());
        double secondNumb = double.Parse(Console.ReadLine());
        string sign = Console.ReadLine();
        double result = 0;
        string evenOdd = null;

        if (sign.Equals("+"))
        {
            result = firstNumb + secondNumb;
            if (result % 2 == 0)
            {
                evenOdd = "even";
            }
            else
            {
                evenOdd = "odd";
            }
            Console.WriteLine("{0} {1} {2} = {3} - {4}", firstNumb, sign, secondNumb, result, evenOdd);
        }
        else if (sign.Equals("-"))
	    {
            result = firstNumb - secondNumb;
            if (result % 2 == 0)
            {
                evenOdd = "even";
            }
            else
            {
                evenOdd = "odd";
            }
            Console.WriteLine("{0} {1} {2} = {3} - {4}", firstNumb, sign, secondNumb, result, evenOdd);
	    }
        else if (sign.Equals("*"))
        {
            result = firstNumb * secondNumb;
            if (result % 2 == 0)
            {
                evenOdd = "even";
            }
            else
            {
                evenOdd = "odd";
            }
            Console.WriteLine("{0} {1} {2} = {3} - {4}", firstNumb, sign, secondNumb, result, evenOdd);
    	}
        else if (sign.Equals("/"))
        {
            if (secondNumb == 0)
	        {
                Console.WriteLine("Cannot divide {0} by zero", firstNumb);
	        }
            else
	        {
                result = firstNumb / secondNumb;
                Console.WriteLine("{0} {1} {2} = {3:F2}", firstNumb, sign, secondNumb, result);
	        }
        }
        else if (true)
        {
            if (secondNumb == 0)
	        {
                Console.WriteLine("Cannot divide {0} by zero", firstNumb);
	        }
            else
	        {
                result = firstNumb % secondNumb;
                Console.WriteLine("{0} {1} {2} = {3}", firstNumb, sign, secondNumb, result);
	        }
        }
    }
}
