using System;

class Program
{
    static void Main(string[] args)
    {
        int numberOfStudents = int.Parse(Console.ReadLine());
        int numberOfLectures = int.Parse(Console.ReadLine());
        int additionalBonus = int.Parse(Console.ReadLine());

        string topStudent = "";
        double maxBonus = double.MinValue;

        for (int i = 0; i < numberOfStudents; i++)
        {
            int studentAttendances = int.Parse(Console.ReadLine());
            double bonus = (double)studentAttendances / numberOfLectures * (5 + additionalBonus);

            if (bonus > maxBonus)
            {
                maxBonus = bonus;
                topStudent = $"Max Bonus: {Math.Ceiling(maxBonus)}.";
            }
        }

        Console.WriteLine(topStudent);
        Console.WriteLine($"The student has attended {Math.Round(maxBonus / (5 + additionalBonus) * numberOfLectures)} lectures.");
    }
}
