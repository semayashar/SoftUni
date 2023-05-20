namespace _03._Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*You will receive three lines from the console:
                • A count of people who are going on vacation.
                • Type of the group (Students, Business or Regular).
                • The day of the week which the group will stay on (Friday, Saturday or Sunday).
              Based on the given information calculate how much the group will pay for the entire vacation. */

            int count = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string day = Console.ReadLine();

            float pricePerPerson = 0, price = 0;

            if (type == "Students")
            {
                if (day == "Friday")
                {
                    pricePerPerson = 8.45f;
                }
                else if (day == "Saturday")
                {
                    pricePerPerson = 9.80f;
                }
                else if (day == "Sunday")
                {
                    pricePerPerson = 10.46f;
                }

                if (count >= 30)
                {
                    price = count * pricePerPerson - (count * pricePerPerson * 0.15f);
                }
                else
                {
                    price = count * pricePerPerson;
                }
            }
            else if (type == "Business")
            {
                if (day == "Friday")
                {
                    pricePerPerson = 10.90f;
                }
                else if (day == "Saturday")
                {
                    pricePerPerson = 15.60f;
                }
                else if (day == "Sunday")
                {
                    pricePerPerson = 16f;
                }

                if (count >= 100)
                {
                    count = -10;
                }
                price = count * pricePerPerson;

            }
            else if (type == "Regular")
            {
                if (day == "Friday")
                {
                    pricePerPerson = 15f;
                }
                else if (day == "Saturday")
                {
                    pricePerPerson = 20f;
                }
                else if (day == "Sunday")
                {
                    pricePerPerson = 22.50f;
                }

                if (count >= 10 && count <= 20)
                {
                   price = count * pricePerPerson - (count * pricePerPerson * 0.05f);
                }
                else
                {
                    price = count * pricePerPerson;
                }
               
            }
            Console.WriteLine($"Total price: {price:F2}");
        }
    }
}