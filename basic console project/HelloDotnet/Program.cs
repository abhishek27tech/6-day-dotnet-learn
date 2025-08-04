using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter marks for 3 subjects:");

        Console.Write("Subject 1: ");
        int m1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Subject 2: ");
        int m2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Subject 3: ");
        int m3 = Convert.ToInt32(Console.ReadLine());

        double average = (m1 + m2 + m3) / 3.0;

        string grade = GetGrade(average);

        Console.WriteLine($"Average Marks: {average}");
        Console.WriteLine($"Grade: {grade}");
    }

    static string GetGrade(double avg)
    {
        if (avg >= 90) return "A+";
        if (avg >= 75) return "A";
        if (avg >= 60) return "B";
        if (avg >= 45) return "C";
        return "Fail";
    }
}
