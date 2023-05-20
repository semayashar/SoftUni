namespace _04._Print_and_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startNumber = int.Parse(Console.ReadLine());
            int endNumber = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = startNumber; i < endNumber-1; i++)
            {
                Console.Write($"{i} ");
                sum += i;
            }
            Console.Write(endNumber + "\n");
            Console.WriteLine($"Sum: {sum}");
        }
    }
}