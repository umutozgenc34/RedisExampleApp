

using Models;

namespace Repository;

public interface IProductRepository
{
    Task<List<Product>> GetAllAsync();
    Task<Product> GetAsync(int id);
    Task<Product> CreateAsync(Product product);
}
