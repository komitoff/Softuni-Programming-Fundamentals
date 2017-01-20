using System;

class ConvertSpeedUnits
{
    static void Main(string[] args)
    {
        float distane = float.Parse(Console.ReadLine());
        float hours = float.Parse(Console.ReadLine());
        float minutes = float.Parse(Console.ReadLine());
        float seconds = float.Parse(Console.ReadLine());
        float milesDistance = distane / 1609;

        float totalSeconds = (hours * 3600) + (minutes * 60) + seconds;
        float totalHours = totalSeconds / 3600;
        float totalMinutes = totalSeconds / 60;

        float mettersPerSecond = distane / totalSeconds;
        float kmPerHour = ((distane / 1000) / totalHours);
        float milesPerHour = milesDistance / totalHours;


        Console.WriteLine(mettersPerSecond);
        Console.WriteLine(kmPerHour);
        Console.WriteLine(milesPerHour);
    }
}
