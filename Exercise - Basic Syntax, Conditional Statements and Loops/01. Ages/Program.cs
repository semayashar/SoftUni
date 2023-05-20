namespace _01._Ages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //A program that determines if a person is baby, child, teenager, adult or elder based on the given age:

            Console.Write("Enter your age: ");
            int age = int.Parse(Console.ReadLine());

            string category;

            if (age >= 0 && age <= 2)
            {
                category = "baby";
            }
            else if (age >= 3 && age <= 13)
            {
                category = "child";
            }
            else if (age >= 14 && age <= 19)
            {
                category = "teenager";
            }
            else if (age >= 20 && age <= 65)
            {
                category = "adult";
            }
            else
            {
                category = "elder";
            }

            Console.WriteLine("Age category: " + category);
        }
    }
}