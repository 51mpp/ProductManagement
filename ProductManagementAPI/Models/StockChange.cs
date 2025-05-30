namespace ProductManagementAPI.Models
{
    public class StockChange
    {
        public int Id { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }

        public string Unit { get; set; }
        public DateTime StockChangeDate { get; set; }
        public string Note { get; set; }
        public string TransactionType { get; set; } 

    }

}
