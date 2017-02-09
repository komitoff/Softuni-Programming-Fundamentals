using System;
using System.Collections.Generic;
using System.Linq;

public class AdvertisementMessage
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Random randomGenerator = new Random();
        int randomPhrase = 0;
        int randomEvent = 0;
        int randomAuthor = 0;
        int randomCity = 0;

        string[] phrases = new string[] 
        {
            "Excellent product",
            "Such a great product.",
            "I always use that product.",
            "Best product of its category.",
            "Exceptional product.",
            "I can’t live without this product."
            };

        string[] events = new string[]
        {
            "Now I feel good.",
            "I have succeeded with this product.",
            "Makes miracles. I am happy of the results!",
            "I cannot believe but now I feel awesome.",
            "Try it yourself, I am very satisfied.",
            "I feel great!"
        };

        string[] author = new string[]
        {
            "Diana",
            "Petya",
            "Stella",
            "Elena",
            "Katya",
            "Iva",
            "Annie",
            "Eva"
        };

        string[] cities = new string[]
        {
            "Burgas",
            "Sofia",
            "Plovdiv",
            "Varna",
            "Ruse"
        };

        //{phrase} {event} {author} – {city}.
        for (int i = 0; i < n; i++)
        {
            randomPhrase = randomGenerator.Next(0, phrases.Length);
            randomEvent = randomGenerator.Next(0, events.Length);
            randomAuthor = randomGenerator.Next(0, author.Length);
            randomCity = randomGenerator.Next(0, cities.Length);
            Console.WriteLine($"{phrases[randomPhrase]} {events[randomEvent]} {author[randomAuthor]} - {cities[randomCity]}");
        }

    }
}