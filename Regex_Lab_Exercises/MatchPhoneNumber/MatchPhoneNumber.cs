using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

public class MatchPhoneNumber
{
    static void Main()
    {
        string number = Console.ReadLine();
        string pattern = @"\+[0-9]{3}\s+[0-9]{1}\s+[0-9]{3}\s+[0-9]{4}";
        Regex rgx = new Regex(pattern);
        MatchCollection matches = rgx.Matches(number);
        Console.WriteLine("Found {0} results ", matches.Count);

        foreach (Match match in matches)
        {
            Console.WriteLine("Found : {0}", match);
        }

    }
}