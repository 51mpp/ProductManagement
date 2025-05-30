using ProductManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagement.Interfaces
{
    internal interface IProductService
    {
        List<Product> GetAllProducts();
        Product GetProductByCode(int productcode);
    }
}
