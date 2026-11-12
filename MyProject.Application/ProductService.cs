using MyProject.Domain;
using MyProject.Infrastructure;

namespace MyProject.Application;

public class ProductService : IProductService
{
    public readonly IProductRepository _productRepository;

    public ProductService(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public async Task<IEnumerable<Product>> GetProductsAsync() => await _productRepository.GetAllAsync();
    public async Task<Product?> GetProductById(int id) => await _productRepository.GetByIdAsync(id);
    public async Task AddProductAsync(Product product) => await _productRepository.AddAsync(product);
    public async Task UpdateProductAsync(Product product) => await _productRepository.UpdateAsync(product);
    public async Task DeleteProductAsync(int id) => await _productRepository.DeleteAsync(id);
}
