using MyProject.Domain;

namespace MyProject.Application;

public interface IProductService
{
    public Task<IEnumerable<Product>> GetProductsAsync();
    public Task<Product?> GetProductById(int id);
    public Task AddProductAsync(Product product);
    public Task UpdateProductAsync(Product product);
    public Task DeleteProductAsync(int id);
}
