using System;
using System.Collections.Generic;
using System.Linq;

public class Student
{
    public string Name { get; set; }
    public List<double> Grades { get; set; }
    public double AverageGrade { get; set; }

    public Student(string name, List<double> grades)
    {
        this.Name = name;
        this.Grades = grades;
        this.AverageGrade = this.Grades.Average(x => x);
    }


}

