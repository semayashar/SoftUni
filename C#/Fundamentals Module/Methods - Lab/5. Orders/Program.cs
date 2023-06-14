namespace _5._Orders
{
    internal class Program
    {
        static void CalculateTotalPrice(string product, int quantity)
        {
            double price = 0;

            switch (product)
            {
                case "coffee":
                    price = 1.50;
                    break;
                case "water":
                    price = 1.00;
                    break;
                case "coke":
                    price = 1.40;
                    break;
                case "snacks":
                    price = 2.00;
                    break;
                default:
                    Console.WriteLine("Invalid product");
                    return;
            }

            double total = price * quantity;
            Console.WriteLine(total.ToString("F2"));
        }

        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            CalculateTotalPrice(product, quantity);
        }
    }
}