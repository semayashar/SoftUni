namespace _3._Calculations
{
    internal class Program
    {
        static void Add(double num1, double num2)
        {
            double result = num1 + num2;
            Console.WriteLine(result);
        }

        static void Multiply(double num1, double num2)
        {
            double result = num1 * num2;
            Console.WriteLine(result);
        }

        static void Subtract(double num1, double num2)
        {
            double result = num1 - num2;
            Console.WriteLine(result);
        }

        static void Divide(double num1, double num2)
        {
            if (num2 != 0)
            {
                double result = num1 / num2;
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Cannot divide by zero");
            }
        }

        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());

            switch (command)
            {
                case "add":
                    Add(num1, num2);
                    break;
                case "multiply":
                    Multiply(num1, num2);
                    break;
                case "subtract":
                    Subtract(num1, num2);
                    break;
                case "divide":
                    Divide(num1, num2);
                    break;
                default:
                    Console.WriteLine("Invalid command");
                    break;
            }
        }
    }
}