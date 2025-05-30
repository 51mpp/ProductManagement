using ProductManagementAPI.Data;
using ProductManagementAPI.Interfaces;
using ProductManagementAPI.Models;

namespace ProductManagementAPI.Repositorys
{
    public class ProductRepository : IProductRepository
    {
        // This class implements the IProductRepository interface, providing methods to interact with the Product entity in the database.
        private readonly ApplicationDbContext _context;
        public ProductRepository(ApplicationDbContext context) => _context = context;



        public ICollection<Product> GetAllProducts()
        {
            // Retrieves all products from the database.
            return _context.Products.OrderBy(p => p.ProductCode).ToList();
        }

        public Product GetProductByCode(string code)
        {
            return _context.Products.FirstOrDefault(p => p.ProductCode == code); // Retrieves a product by its code.
        }

    }

}
