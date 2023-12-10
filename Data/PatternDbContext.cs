using LojaAmigurumi.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
namespace LojaAmigurumi.Data
{
    public class PatternDbContext : IdentityDbContext
    {
        public DbSet<Pattern> Pattern { get; set; }
        public DbSet<Nivel> Nivel { get; set; }
        public DbSet<Categoria> Categoria { get; set; }
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
