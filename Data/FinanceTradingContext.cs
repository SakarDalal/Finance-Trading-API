using Microsoft.EntityFrameworkCore;
using FinanceTradingApi.Models;
using System.Collections.Generic;

namespace FinanceTradingApi.Data
{
    public class FinanceTradingContext : DbContext
    {
        public FinanceTradingContext(DbContextOptions<FinanceTradingContext> options)
            : base(options)
        {
        }

        public DbSet<Portfolio> Portfolios { get; set; } = null!;
    }
}

