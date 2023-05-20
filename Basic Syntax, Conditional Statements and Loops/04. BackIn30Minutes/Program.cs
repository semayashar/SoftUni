using System;

namespace BackIn30Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //A program, which calculates the time after 30 minutes:

            //Entering the time - hours(int), minutes(int):
            Console.Write("Enter hours: ");
            int hour = int.Parse(Console.ReadLine());
            Console.Write("Enter minutes: ");
            int minutes = int.Parse(Console.ReadLine());

            //Calculating:
            minutes += 30;
            if (minutes >= 60)
            {
                hour++;
                minutes = minutes - 60;
            }
            if (hour >= 23)
            {
                hour = 0;
            }

            //Output:
            Console.WriteLine($"{hour}:{minutes:D2}");
        }
    }
}