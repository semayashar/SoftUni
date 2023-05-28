namespace _01._Convert_Meters_to_Kilometers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* A program that converts meters to
             * kilometers formatted to the second decimal point.*/

            // Read the distance in meters from the user
            int meters = int.Parse(Console.ReadLine());

            // Convert meters to kilometers
            float kilometers = meters / 1000.0f;

            // Display the result
            Console.WriteLine($"{kilometers:f2}");
        }
    }
}