using ProductManagementAPI.Models;

namespace ProductManagementAPI.Interfaces
{
    public interface IProductRepository
    {
        //Task<List<Product>> GetAllAsync();
        //Task<Product> GetByCodeAsync(string code);
        //Task AddAsync(Product product);
        //Task UpdateAsync(Product product);

        ICollection<Product> GetAllProducts();
        Product GetProductByCode(string code);



    }
}
