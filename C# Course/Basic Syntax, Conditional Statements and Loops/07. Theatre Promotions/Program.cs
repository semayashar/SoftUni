using System;

namespace TheatrePromotions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* A theatre sails tickets at discount and a program is needed to
             * calculate the price of a single ticket. If the given age
             * does not fit one of the categories, you should print "Error!". */

            /*Input
                The input comes in two lines. 
                On the first line you will receive the type of day - Holiday, Weekend, Weekday. 
                On the second – the age of the person - 0 <= age <= 18 18 < age <= 64 64 < age <= 122*/

            string day = Console.ReadLine();
            while (day != "Holiday" && day != "Weekend" && day != "Weekday")
            {
                Console.WriteLine("Error! Shoud be Holiday, Weekend or Weekday");
                day = Console.ReadLine();
            }

            int age = int.Parse(Console.ReadLine());
            if (age < 0)
            {
                Console.WriteLine("Error!");
            }

            //Logic:
            if (day == "Weekday")
            {
                if (0 <= age && age <= 18)
                {
                    Console.WriteLine("12$");
                }
                else if (18 < age && age <= 64)
                {
                    Console.WriteLine("18$");
                }
                else
                {
                    Console.WriteLine("12$");
                }
            }
            else if (day == "Weekend")
            {
                if (0 <= age && age <= 18)
                {
                    Console.WriteLine("15$");
                }
                else if (18 < age && age <= 64)
                {
                    Console.WriteLine("20$");
                }
                else
                {
                    Console.WriteLine("15$");
                }
            }
            else
            {
                if (0 <= age && age <= 18)
                {
                    Console.WriteLine("5$");
                }
                else if (18 < age && age <= 64)
                {
                    Console.WriteLine("12$");
                }
                else
                {
                    Console.WriteLine("10$");
                }
            }

        }
    }
}