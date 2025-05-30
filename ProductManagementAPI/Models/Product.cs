using System.ComponentModel.DataAnnotations;

namespace ProductManagementAPI.Models
{
    public class Product
    {
        [Key]
        public string ProductCode { get; set; }

        public string ProductName { get; set; }

        public int Quantity { get; set; }
        public string Unit { get; set; }


        public DateTime LastStockUpdateDate { get; set; } 
    }

}
