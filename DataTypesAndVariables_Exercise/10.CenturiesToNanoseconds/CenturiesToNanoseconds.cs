using System;
using System.Numerics;

class CenturiesToNanoseconds
{
    static void Main(string[] args)
    {
        ulong centuries = ulong.Parse(Console.ReadLine());

        ulong years = centuries * 100;
        ulong days = (ulong)(years * 365.2422);
        ulong hours = days * 24;
        ulong minutes = hours * 60;
        ulong seconds = minutes * 60;
        ulong miliseconds = seconds * 1000;
        ulong microseconds = miliseconds * 1000;
        BigInteger nanoseconds = (BigInteger) microseconds * 1000;

        Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = {miliseconds} milliseconds = {microseconds} microseconds = {nanoseconds} nanoseconds");
    }
}
