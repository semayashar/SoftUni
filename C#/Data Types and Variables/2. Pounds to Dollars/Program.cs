namespace _2._Pounds_to_Dollars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Program that converts British pounds 
             * to US dollars formatted to the 3rd decimal point.
             * British Pound = 1.31 Dollars*/

            // Read:
            double pounds = double.Parse(Console.ReadLine());

            // Convert pounds to dollars
            double dollars = pounds * 1.31;

            // Display the result
            Console.WriteLine($"{dollars:f3}");
        }
    }
}