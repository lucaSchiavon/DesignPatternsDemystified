using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemystified.BehavioralPatterns.Observer.StockMarket
{
    //Define the Observer interface
    public interface IInvestor
    {
        void Update(string stockSymbol, decimal stockPrice);
    }
}
