namespace Patterns_2.Decorator;

public interface ICoffee
{
    string GetDescription();
    double GetCost();
}

public class SimpleCoffee : ICoffee
{
    public string GetDescription()
    {
        return "Simple coffee";
    }

    public double GetCost()
    {
        return 20.0;
    }
}