using System;

namespace Problem_1___Computer_Store
{
    internal class Program
    {
        static void Main()
        {
            double totalPriceWithoutTaxes = 0;
            string input = Console.ReadLine();

            while (input != "special" && input != "regular")
            {
                double price = double.Parse(input);

                if (price <= 0)
                {
                    Console.WriteLine("Invalid price!");
                }
                else
                {
                    totalPriceWithoutTaxes += price;
                }

                input = Console.ReadLine();
            }

            if (totalPriceWithoutTaxes == 0)
            {
                Console.WriteLine("Invalid order!");
                return;
            }

            double taxes = totalPriceWithoutTaxes * 0.2;
            double totalPriceWithTaxes = totalPriceWithoutTaxes + taxes;

            if (input == "special")
            {
                totalPriceWithTaxes *= 0.9;
            }

            Console.WriteLine("Congratulations you've just bought a new computer!");
            Console.WriteLine($"Price without taxes: {totalPriceWithoutTaxes:F2}$");
            Console.WriteLine($"Taxes: {taxes:F2}$");
            Console.WriteLine("-----------");
            Console.WriteLine($"Total price: {totalPriceWithTaxes:F2}$");
        }
    }

}
