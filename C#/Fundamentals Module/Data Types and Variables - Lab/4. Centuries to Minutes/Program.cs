namespace _4._Centuries_to_Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Program to enter an integer number of 
             * centuries and convert it to years, days, hours and minutes.*/

            // Read the number of centuries from the user
            Console.Write("Enter the number of centuries: ");
            int centuries = int.Parse(Console.ReadLine());

            // Calculate the equivalent values
            decimal years = centuries * 100;
            decimal days = years * 365.2422m;
            decimal hours = days * 24;
            decimal minutes = hours * 60;

            // Print the results
            Console.WriteLine("Equivalent years: " + years);
            Console.WriteLine("Equivalent days: " + days);
            Console.WriteLine("Equivalent hours: " + hours);
            Console.WriteLine("Equivalent minutes: " + minutes);
        }
    }
}