using Microsoft.AspNetCore.Mvc;
using FinanceTradingApi.Models;

namespace FinanceTradingApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StocksController : ControllerBase
    {
        // Mock data - In real applications, this would come from a service or external API
        private static readonly List<Stock> Stocks = new()
        {
            new Stock { Symbol = "AAPL", Name = "Apple Inc.", Price = 150.00m, Change = -1.00m, PercentChange = -0.66m },
            new Stock { Symbol = "MSFT", Name = "Microsoft Corporation", Price = 250.00m, Change = 2.00m, PercentChange = 0.80m },
        };

        [HttpGet]
        public ActionResult<IEnumerable<Stock>> GetStocks()
        {
            return Ok(Stocks);
        }

        [HttpGet("{symbol}")]
        public ActionResult<Stock> GetStock(string symbol)
        {
            var stock = Stocks.FirstOrDefault(s => s.Symbol.Equals(symbol, StringComparison.OrdinalIgnoreCase));
            if (stock == null)
            {
                return NotFound();
            }

            return Ok(stock);
        }
    }
}

