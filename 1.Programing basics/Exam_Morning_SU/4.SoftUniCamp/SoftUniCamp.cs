using System;

class SoftUniCamp
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        double totalStudents = 0;
        double byCar = 0;
        double bySmallBus = 0;
        double byMiddleBus = 0;
        double byBigBus = 0;
        double byTrain = 0;

        for (int i = 0; i < n; i++)
        {
            int students = int.Parse(Console.ReadLine());
            totalStudents += students;
            if (students <= 5)
            {
                byCar += students;
            }
            else if (students > 5 && students <= 12)
            {
                bySmallBus += students;
            }
            else if (students > 12 && students <= 25)
            {
                byMiddleBus += students;
            }
            else if (students > 25 && students <= 40)
            {
                byBigBus += students;
            }
            else
            {
                byTrain += students;
            }
        }

        Console.WriteLine("{0:F2}%", (byCar / totalStudents) * 100);
        Console.WriteLine("{0:F2}%", (bySmallBus / totalStudents) * 100);
        Console.WriteLine("{0:F2}%", (byMiddleBus / totalStudents) * 100);
        Console.WriteLine("{0:F2}%", (byBigBus / totalStudents) * 100);
        Console.WriteLine("{0:F2}%", (byTrain / totalStudents) * 100);
    }
}
