using Microsoft.EntityFrameworkCore;
using Repository.Design.Pattern.Models;

namespace Repository.Design.Pattern.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }

        public DbSet<Products> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Products>().HasData(new Products
            {
                Id = 1,
                Name = "Test1",
                Price = 100

            });

            modelBuilder.Entity<Products>().HasData(new Products
            {
                Id = 2,
                Name = "Test2",
                Price = 200

            });
        }
    }
}
