namespace _5._Add_and_Subtract
{
    internal class Program
    {
        static int Calculate(int a, int b, int c)
        {
            int sum = a + b;
            int result = sum - c;
            return result;
        }

        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            int result = Calculate(num1, num2, num3);

            Console.WriteLine(result);
        }
    }
}