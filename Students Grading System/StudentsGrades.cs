using System;
using System.Collections.Generic;

class StudentGrades
{
    static void Main()
    {
        Console.WriteLine("Enter the number of subjects:");
        int numberOfSubjects = int.Parse(Console.ReadLine());

        List<double> grades = new List<double>();
        double total = 0;

        for (int i = 0; i < numberOfSubjects; i++)
        {
            Console.WriteLine($"Enter the grade for subject {i + 1}: ");
            double grade = double.Parse(Console.ReadLine());
            grades.Add(grade);
            total += grade;
        }

        double average = total / numberOfSubjects;
        Console.WriteLine($"\nYour average grade is: {average}");

        string letterGrade = GetLetterGrade(average);
        Console.WriteLine($"Your letter grade is: {letterGrade}");
    }

    static string GetLetterGrade(double average)
    {
        if (average >= 90) return "A";
        else if (average >= 80) return "B";
        else if (average >= 70) return "C";
        else if (average >= 60) return "D";
        else return "F";
    }
}
