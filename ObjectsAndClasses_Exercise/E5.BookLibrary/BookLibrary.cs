using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

public class BookLibrary
{
    static void Main()
    {
        int count = int.Parse(Console.ReadLine());
        SortedDictionary<string, decimal> authors = new SortedDictionary<string, decimal>();
        List<Book> library = new List<Book>();
        for (int i = 0; i < count; i++)
        {
            string[] info = Console.ReadLine().Split();
            //{title} {author} {publisher} {release date} {ISBN} {price}.
            string title = info[0];
            string author = info[1];
            DateTime releaseDate = DateTime.ParseExact(info[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);
            decimal price = decimal.Parse(info[5]);
            if (!authors.ContainsKey(author))
            {
                authors.Add(author, price);
            }
            foreach (var book in library)
            {
                if (book.Author.Equals(author))
                {
                    authors[author] += price;
                }
            }
            Book currentBook = new Book(title, author);
            library.Add(currentBook);
        }

        foreach (var author in authors
            .OrderByDescending(a => a.Value)
            .ThenBy(a => a.Key))
        {
            Console.WriteLine($"{author.Key} -> {author.Value}");
        }
        
    }
}
