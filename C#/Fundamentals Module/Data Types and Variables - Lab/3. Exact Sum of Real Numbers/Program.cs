namespace _3._Exact_Sum_of_Real_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Program to enter n numbers and 
             *calculate and print their exact sum.*/
            
            int count = int.Parse(Console.ReadLine());
            decimal sum = 0;
            for (int i = 0; i < count; i++)
            {
                decimal number = decimal.Parse(Console.ReadLine());
                sum += number;
            }
            Console.WriteLine($"{sum}");
        }
    }
}