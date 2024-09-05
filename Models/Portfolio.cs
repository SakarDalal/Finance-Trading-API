namespace FinanceTradingApi.Models
{
    public class Portfolio
    {
        public int Id { get; set; }
        public string UserId { get; set; } = string.Empty;
        public List<Stock> Stocks { get; set; } = new();
        public decimal TotalValue { get; set; }
    }
}

