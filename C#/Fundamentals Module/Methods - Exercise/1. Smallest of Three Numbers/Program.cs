namespace _1._Smallest_of_Three_Numbers
{
    internal class Program
    {
        static void PrintSmallest(int num1, int num2, int num3)
        {
            int smallest = Math.Min(Math.Min(num1, num2), num3);
            Console.WriteLine(smallest);
        }
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            PrintSmallest(a, b, c);
        }
    }
}