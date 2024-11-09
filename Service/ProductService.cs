using Models;
using Repository;


namespace Services;

public class ProductService(IProductRepository productRepository) : IProductService
{
    public async Task<Product> CreateAsync(Product product) => await productRepository.CreateAsync(product);

    public async Task<List<Product>> GetAllAsync() => await productRepository.GetAllAsync();

    public async Task<Product> GetAsync(int id) => await productRepository.GetAsync(id);
}
