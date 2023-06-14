namespace _7._Water_Overflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int tankCapacity = 255;
            int litersInTank = 0;

            for (int i = 0; i < n; i++)
            {
                int litersToAdd = int.Parse(Console.ReadLine());

                if (litersInTank + litersToAdd > tankCapacity)
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                else
                {
                    litersInTank += litersToAdd;
                }
            }

            Console.WriteLine(litersInTank);
        }
    }
}