namespace Patterns_3.Observer;

public class ClientCode
{
    public void Main()
    {
        // Create a stock market
        StockMarket stockMarket = new StockMarket();

        // Create investors
        Investor investor1 = new Investor("John");
        Investor investor2 = new Investor("Alice");

        // Subscribe investors to the stock market
        stockMarket.Attach(investor1);
        stockMarket.Attach(investor2);

        // Update the stock prices
        stockMarket.UpdateStockPrice("AAPL", 150.50); // Investors will receive notifications
        stockMarket.UpdateStockPrice("GOOGL", 2800.00); // Investors will receive notifications

        // Unsubscribe one investor
        stockMarket.Detach(investor2);

        // Update the stock prices
        stockMarket.UpdateStockPrice("TSLA", 750.00); // Only one investor will receive notification
    }
}