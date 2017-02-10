using System;
using System.Collections.Generic;
using System.Linq;

public class AverageGrades
{
    static void Main()
    {
        int length = int.Parse(Console.ReadLine());
        List<Student> students = new List<Student>();

        for (int i = 0; i < length; i++)
        {
            string[] studentsInfo = Console.ReadLine().Split().ToArray();
            string name = studentsInfo[0];
            List<double> grades = new List<double>();
            for (int j = 1; j < studentsInfo.Length; j++)
            {
                grades.Add(double.Parse(studentsInfo[j]));
            }
            students.Add(new Student(name, grades));
        }

        foreach (var student in students
            .Where(s => s.AverageGrade >= 5)
            .OrderBy(s => s.Name)
            .ThenByDescending(s => s.AverageGrade))
        {
            Console.WriteLine($"{student.Name} -> {student.AverageGrade:f2}");
        }
    }
}