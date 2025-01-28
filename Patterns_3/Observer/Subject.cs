namespace Patterns_3.Observer;

public interface ISubject
{
    void Attach(IObserver observer);
    void Detach(IObserver observer);
    void Notify(string stockSymbol, double price);
}

public class StockMarket : ISubject
{
    private List<IObserver> _observers = new List<IObserver>();
    private Dictionary<string, double> _stockPrices = new Dictionary<string, double>();

    // Add an observer to the list
    public void Attach(IObserver observer)
    {
        _observers.Add(observer);
    }

    // Delete an observer from the list
    public void Detach(IObserver observer)
    {
        _observers.Remove(observer);
    }

    // Notify all observers about the price change
    public void Notify(string stockSymbol, double price)
    {
        foreach (var observer in _observers)
        {
            observer.Update(stockSymbol, price);
        }
    }

    // Update the price of a stock
    public void UpdateStockPrice(string stockSymbol, double price)
    {
        if (_stockPrices.ContainsKey(stockSymbol))
        {
            _stockPrices[stockSymbol] = price;
        }
        else
        {
            _stockPrices.Add(stockSymbol, price);
        }
        
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"Stock {stockSymbol} price updated to ${price}");
        Console.ResetColor();
        Notify(stockSymbol, price);
    }
}