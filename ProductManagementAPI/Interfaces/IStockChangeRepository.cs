using ProductManagementAPI.DTO;
using ProductManagementAPI.Models;

namespace ProductManagementAPI.Interfaces
{
    public interface IStockChangeRepository
    {
        ICollection<StockChange> GetAll();
        void AddStockChange(StockChangeDTO stockChange);
    }

}
