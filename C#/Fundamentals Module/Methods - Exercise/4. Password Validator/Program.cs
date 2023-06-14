namespace _4._Password_Validator
{
    internal class Program
    {
        static void ValidatePassword(string password)
        {
            if (password.Length < 6 || password.Length > 10)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            else if (!password.All(char.IsLetterOrDigit))
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            else if (password.Count(char.IsDigit) < 2)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
            else
            {
                Console.WriteLine("Password is valid");
            }
        }

        static void Main(string[] args)
        {
            string pass = Console.ReadLine();
            ValidatePassword(pass);
        }
    }
}