using System;
using System.Collections.Generic;
using System.Linq;

class Student
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public float Grade { get; set; }

    public Student(string firstName, string lastName, float grade)
    {
        FirstName = firstName;
        LastName = lastName;
        Grade = grade;
    }

    public override string ToString()
    {
        return $"{FirstName} {LastName}: {Grade}";
    }
}

class Program
{
    static void Main()
    {
        int numStudents = int.Parse(Console.ReadLine());
        List<Student> students = new List<Student>();

        for (int i = 0; i < numStudents; i++)
        {
            string[] studentInfo = Console.ReadLine().Split(" ");
            string firstName = studentInfo[0];
            string lastName = studentInfo[1];
            float grade = float.Parse(studentInfo[2]);

            Student student = new Student(firstName, lastName, grade);
            students.Add(student);
        }

        List<Student> sortedStudents = students.OrderByDescending(s => s.Grade).ToList();

        foreach (Student student in sortedStudents)
        {
            Console.WriteLine(student);
        }
    }
}
