using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemystified.BehavioralPatterns.Observer.StockMarket
{
    // Step 2: Define the Subject (Observable)
    public class StockMarket
    {
        private Dictionary<string, decimal> stocks = new Dictionary<string, decimal>();
        private List<IInvestor> investors = new List<IInvestor>();

        public void AddStock(string symbol, decimal price)
        {
            stocks[symbol] = price;
        }

        public void Attach(IInvestor investor)
        {
            investors.Add(investor);
        }

        public void Detach(IInvestor investor)
        {
            investors.Remove(investor);
        }

        public void UpdateStockPrice(string symbol, decimal newPrice)
        {
            if (stocks.ContainsKey(symbol))
            {
                stocks[symbol] = newPrice;
                NotifyInvestors(symbol, newPrice);
            }
        }

        private void NotifyInvestors(string symbol, decimal newPrice)
        {
            foreach (var investor in investors)
            {
                investor.Update(symbol, newPrice);
            }
        }
    }

}
