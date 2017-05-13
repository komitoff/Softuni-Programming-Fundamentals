using System;

class Butterfly
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int high = 2 * (n - 2) + 1;
        int middle = (high / 2) + 1;

        string stars = new string('*', n - 2);
        string dashes = new string('-', n - 2);
        string emptySpaces = new string(' ', n - 1);

        string topStarsRow = stars + "\\ /" + stars;
        string topDashesRow = dashes + "\\ /" + dashes;
        string middleRow = emptySpaces + "@" + emptySpaces;
        string botStarsRow = stars + @"/ \" + stars;
        string botDashesRow = dashes + @"/ \" + dashes;

        for (int i = 1; i < middle; i++)
        {
            if (i % 2 != 0)
            {
                Console.WriteLine(topStarsRow);
            }
            else
            {
                Console.WriteLine(topDashesRow);
            }
        }
        Console.WriteLine(middleRow);
        for (int i = 1; i < middle; i++)
        {
            if (i % 2 != 0)
            {
                Console.WriteLine(botStarsRow);
            }
            else
            {
                Console.WriteLine(botDashesRow);
            }
        }
    }
}
