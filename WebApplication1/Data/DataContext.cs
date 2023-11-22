using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;
namespace WebApplication1.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=HAMMAD\\SQLEXPRESS;Database=pizzadb;Trusted_Connection=True;TrustServerCertificate=True;");
        }

        public DbSet<Item> Items { get; set; }

    }
}
