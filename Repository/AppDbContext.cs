
using Microsoft.EntityFrameworkCore;
using Models;

namespace Repository;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<Product> Products { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        modelBuilder.Entity<Product>().HasData(
            new Product() { Id=1 , Name ="Kalem",Price=100},
            new Product() { Id = 2, Name = "Silgi", Price = 50 },
            new Product() { Id = 3, Name = "Kitap", Price = 70 },
            new Product() { Id = 4, Name = "Defter", Price = 80 },
            new Product() { Id = 5, Name = "Cetvel", Price = 20 }
            );


        base.OnModelCreating(modelBuilder);
    }
}
