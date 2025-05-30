using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagement.Models
{
    public class StockChange
    {
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }

        public string Unit { get; set; }
        public DateTime StockChangeDate { get; set; }
        public string Note { get; set; }
        public string TransactionType { get; set; }
    }
}