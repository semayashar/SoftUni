using ORM_Fundamentals___Lection.Models;

namespace ORM_Fundamentals___Lection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ApplicationDBContext db = new ApplicationDBContext();

            var towns = db.Towns;  // Corrected variable name

        }
    }
}
