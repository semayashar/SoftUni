using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using ORM_Fundamentals___Lection.Models;

namespace ORM_Fundamentals___Lection
{
    public class ApplicationDBContext : DbContext
    {
        private const string connectionString = "Server=DESKTOP-HRCKOHJ;Database=MinionsDB;Integrated Security=True;Encrypt=True;";

        public DbSet<Town> Towns { get; set; }
        public DbSet<Country> Countries { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
