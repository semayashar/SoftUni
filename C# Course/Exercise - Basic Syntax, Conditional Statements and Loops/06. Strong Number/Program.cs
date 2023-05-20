using System;

class StrongNumberChecker
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        if (IsStrongNumber(number))
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }
    }

    static bool IsStrongNumber(int number)
    {
        int originalNumber = number;
        int sum = 0;

        while (number != 0)
        {
            int digit = number % 10;
            sum += Factorial(digit);
            number /= 10;
        }

        return sum == originalNumber;
    }

    static int Factorial(int n)
    {
        int result = 1;

        for (int i = 2; i <= n; i++)
        {
            result *= i;
        }

        return result;
    }
}
