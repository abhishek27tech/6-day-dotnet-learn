using System;
using GradeLibrary;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter 3 marks:");
        int m1 = Convert.ToInt32(Console.ReadLine());
        int m2 = Convert.ToInt32(Console.ReadLine());
        int m3 = Convert.ToInt32(Console.ReadLine());

        double average = (m1 + m2 + m3) / 3.0;
        string grade = GradeHelper.GetGrade(average);

        Console.WriteLine($"Average: {average}");
        Console.WriteLine($"Grade: {grade}");
    }
}