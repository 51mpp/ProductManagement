using ProductManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagement.Interfaces
{
    internal interface IStockChangeService
    {
        List<StockChange> GetStockChanges();
        void AddStockChange(StockChange stockChange);

    }
}
