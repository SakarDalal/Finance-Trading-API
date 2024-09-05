﻿namespace FinanceTradingApi.Models
{
    public class Stock
    {
        public string Symbol { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public decimal Change { get; set; }
        public decimal PercentChange { get; set; }
    }
}
