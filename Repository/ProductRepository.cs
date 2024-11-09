using Microsoft.EntityFrameworkCore;
using Models;

namespace Repository;

public class ProductRepository(AppDbContext context) : IProductRepository
{
    public AppDbContext Context { get; } = context;

    public async Task<Product> CreateAsync(Product product)
    {
        await Context.Products.AddAsync(product);
        await Context.SaveChangesAsync();

        return product;

    }

    public async Task<List<Product>> GetAllAsync() => await Context.Products.ToListAsync();

    public async Task<Product> GetAsync(int id) => await Context.Products.FindAsync(id);
}
