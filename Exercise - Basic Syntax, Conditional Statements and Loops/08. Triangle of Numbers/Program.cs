namespace _08._Triangle_of_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                for (int y = 0; y < i-1; y++)
                {
                    Console.Write(i + " ");
                }
                Console.Write(i + "\n");
            }
        }
    }
}