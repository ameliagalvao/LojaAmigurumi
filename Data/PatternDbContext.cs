using LojaAmigurumi.Models;
using Microsoft.EntityFrameworkCore;
namespace LojaAmigurumi.Data
{
    public class PatternDbContext : DbContext
    {
        public DbSet<Pattern> Pattern { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            string conn = config.GetConnectionString("Conn");

            optionsBuilder.UseSqlServer(conn);
        }
    }
}
