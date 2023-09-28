using System;
using System.Collections.Generic;

// Step 1: Define the Observer interface
public interface IInvestor
{
    void Update(string stockSymbol, decimal stockPrice);
}

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

// Step 3: Define Concrete Observers (Investors)
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

public class Program
{
    public static void Main()
    {
        // Step 4: Create the stock market and investors
        StockMarket stockMarket = new StockMarket();
        Investor investor1 = new Investor("John");
        Investor investor2 = new Investor("Alice");

        // Step 5: Attach investors to the stock market
        stockMarket.Attach(investor1);
        stockMarket.Attach(investor2);

        // Step 6: Add stocks to the market
        stockMarket.AddStock("AAPL", 150.0m);
        stockMarket.AddStock("GOOGL", 2800.0m);

        // Step 7: Update stock prices
        stockMarket.UpdateStockPrice("AAPL", 155.0m);
        stockMarket.UpdateStockPrice("GOOGL", 2850.0m);

        // Output:
        // John received an update for AAPL - New Price: $155.00
        // Alice received an update for AAPL - New Price: $155.00
        // John received an update for GOOGL - New Price: $2850.00
        // Alice received an update for GOOGL - New Price: $2850.00
    }
}
