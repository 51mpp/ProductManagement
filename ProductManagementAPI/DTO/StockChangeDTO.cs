namespace ProductManagementAPI.DTO
{
    /// <summary>
    /// DTO no need to send/get data that not necessary to client
    /// </summary>
    public class StockChangeDTO
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
