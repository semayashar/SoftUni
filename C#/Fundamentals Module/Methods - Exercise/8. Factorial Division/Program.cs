namespace _8._Factorial_Division
{
    internal class Program
    {
        static double FactorialDivision(int num1, int num2)
        {
            double factorial1 = CalculateFactorial(num1);
            double factorial2 = CalculateFactorial(num2);

            return factorial1 / factorial2;
        }

        static double CalculateFactorial(int num)
        {
            double factorial = 1;

            for (int i = 2; i <= num; i++)
            {
                factorial *= i;
            }

            return factorial;
        }

        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            double result = FactorialDivision(num1, num2);

            Console.WriteLine(result.ToString("F2"));
        }
    }
}