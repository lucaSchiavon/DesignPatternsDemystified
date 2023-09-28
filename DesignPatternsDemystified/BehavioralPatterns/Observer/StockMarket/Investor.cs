using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemystified.BehavioralPatterns.Observer.StockMarket
{
    //Define Concrete Observers (Investors)
    public class Investor : IInvestor
    {
        private string name;

        public Investor(string name)
        {
            this.name = name;
        }

        public void Update(string stockSymbol, decimal stockPrice)
        {
            Console.WriteLine($"{name} received an update for {stockSymbol} - New Price: {stockPrice:C}");
        }
    }
}
