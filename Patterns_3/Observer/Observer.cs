namespace Patterns_3.Observer;

public interface IObserver
{
    void Update(string stockSymbol, double price);
}

public class Investor : IObserver
{
    private string _name;

    public Investor(string name)
    {
        _name = name;
    }

    // Method to update the observer, used by subject
    public void Update(string stockSymbol, double price)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"{_name} received update: {stockSymbol} is now ${price}");
        Console.ResetColor();
    }
}