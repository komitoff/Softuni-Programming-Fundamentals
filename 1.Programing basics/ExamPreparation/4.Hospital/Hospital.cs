using System;

class Hospital
{
    static void Main()
    {
        int period = int.Parse(Console.ReadLine());
        int doctors = 7;
        int treated = 0;
        int untreated = 0;
        int treatedPerDay = 0;
        int incomingPatients = 0;

        for (int i = 1; i <= period; i++)
        {
            if (i % 3 == 0 && treated < untreated)
            {
                doctors++;
            }
            incomingPatients = int.Parse(Console.ReadLine());

            if (doctors >= incomingPatients)
            {
                treated += incomingPatients;
            }
            else
            {
                treated += doctors;
                untreated += incomingPatients - doctors;
            }
        }

        Console.WriteLine("Treated patients: {0}.", treated);
        Console.WriteLine("Untreated patients: {0}.",untreated);
    }
}