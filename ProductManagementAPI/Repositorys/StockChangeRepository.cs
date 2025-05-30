using ProductManagementAPI.Data;
using ProductManagementAPI.DTO;
using ProductManagementAPI.Interfaces;
using ProductManagementAPI.Models;

namespace ProductManagementAPI.Repositorys
{
    public class StockChangeRepository : IStockChangeRepository
    {
        private readonly ApplicationDbContext _context;
        public StockChangeRepository(ApplicationDbContext context) => _context = context;

        public ICollection<StockChange> GetAll()
        {
            return _context.StockChanges.OrderBy(x => x.StockChangeDate).ToList();
        }

        //AddStockChange and Update Product
        public void AddStockChange(StockChangeDTO stockChange)
        {
            // Map StockChangeDTO to StockChange
            var stockChangeEntity = new StockChange
            {
                ProductCode = stockChange.ProductCode,
                ProductName = stockChange.ProductName,
                Quantity = stockChange.Quantity,
                Unit = stockChange.Unit,
                StockChangeDate = stockChange.StockChangeDate,
                Note = stockChange.Note,
                TransactionType = stockChange.TransactionType
            };

            _context.StockChanges.Add(stockChangeEntity);

            var product = _context.Products.FirstOrDefault(p => p.ProductCode == stockChange.ProductCode);

            // Check if the product exists in the database
            if (stockChange.TransactionType == "OUT")
            {
                if (product == null)
                {
                    throw new InvalidOperationException("Product not found.");
                }
                if (product.Quantity < stockChange.Quantity)
                {
                    throw new InvalidOperationException("Stock is not enough to withdraw.");
                }
            }


            if (product != null)
            {
                // ถ้ามีอยู่แล้ว → อัปเดต stock

                if (stockChange.TransactionType == "OUT")
                {
                    product.Quantity -= stockChange.Quantity;
                }
                else if (stockChange.TransactionType == "IN")
                {
                    product.Quantity += stockChange.Quantity;
                }
                product.LastStockUpdateDate = DateTime.Now;
                product.Unit = stockChange.Unit; 
                product.ProductName = stockChange.ProductName; 
            }
            else
            {
                // ถ้ายังไม่มี → เพิ่ม product ใหม่
                var newProduct = new Product
                {
                    ProductCode = stockChange.ProductCode,
                    ProductName = stockChange.ProductName, // ต้องส่งชื่อมาด้วย
                    Quantity = stockChange.Quantity,
                    LastStockUpdateDate = stockChange.StockChangeDate,
                    Unit = stockChange.Unit // ต้องส่งมาด้วย
                };
                _context.Products.Add(newProduct);
            }

            _context.SaveChanges();
        }
    }

}
