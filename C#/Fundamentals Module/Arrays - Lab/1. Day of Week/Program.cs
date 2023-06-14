namespace _1._Day_of_Week
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Enter a number in range 1-7 and print out the word representing it or "Invalid Day!". Use an array of strings.
          
            string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(days[number -1]);
        }
    }
}