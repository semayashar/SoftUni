namespace _2._Grades
{
    internal class Program
    {
        public static void PrintGradeDefinition(double grade)
        {
            if (grade >= 2.00 && grade <= 2.99)
            {
                Console.WriteLine("Grade: Fail");
            }
            else if (grade >= 3.00 && grade <= 3.49)
            {
                Console.WriteLine("Grade: Poor");
            }
            else if (grade >= 3.50 && grade <= 4.49)
            {
                Console.WriteLine("Grade: Good");
            }
            else if (grade >= 4.50 && grade <= 5.49)
            {
                Console.WriteLine("Grade: Very good");
            }
            else if (grade >= 5.50 && grade <= 6.00)
            {
                Console.WriteLine("Grade: Excellent");
            }
            else
            {
                Console.WriteLine("Invalid grade. Please enter a grade between 2.00 and 6.00.");
            }
        }

        static void Main(string[] args)
        {
            PrintGradeDefinition(double.Parse(Console.ReadLine()));
        }
    }
}