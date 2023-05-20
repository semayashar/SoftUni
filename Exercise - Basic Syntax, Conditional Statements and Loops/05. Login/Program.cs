namespace _05._Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            char[] stringArray = username.ToCharArray();
            Array.Reverse(stringArray);
            string password = new string(stringArray);

            string input = Console.ReadLine();

            while(input != password)
            {
                Console.WriteLine("Incorrect password. Try again.");
                input = Console.ReadLine();
            }

            Console.WriteLine($"User {username} logged in.");
        }
    }
}