using System;

namespace StudentInformation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* program that receives 3 lines of input:
                • student name
                • age
                • average grade
               and prints all of the info about the student */

            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            double grade = double.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {name}, Age: {age}, Grade: {grade:F2}");
        }
    }
}
