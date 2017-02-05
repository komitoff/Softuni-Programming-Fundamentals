using System;
using System.Collections.Generic;
using System.Linq;

public class FixEmails
{
    static void Main()
    {
        Dictionary<string, string> emailCatalog = new Dictionary<string, string>();
        string name = Console.ReadLine();
        while (!name.Equals("stop"))
        {
            string email = Console.ReadLine();
            AddContact(name, email, emailCatalog);

            name = Console.ReadLine();
        }

        foreach (var contact in emailCatalog)
        {
            Console.WriteLine($"{contact.Key} -> {contact.Value}");
        }
    }

    private static void AddContact(string name, string email, Dictionary<string, string> emailCatalog)
    {
        if (!emailCatalog.ContainsKey(name))
        {
            if (!(email[email.Length - 2] == 'u' &&
            (email[email.Length - 1] == 'k' ||
             email[email.Length - 1] == 's')))
            {
                emailCatalog.Add(name, email);
            }
        }
    }
}