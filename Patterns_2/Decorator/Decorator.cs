namespace Patterns_2.Decorator;

public abstract class CoffeDecorator: ICoffee
{
    protected ICoffee DecoratedCoffee;

    public CoffeDecorator(ICoffee coffee)
    {
        DecoratedCoffee = coffee;
    }

    public virtual string GetDescription()
    {
        return DecoratedCoffee.GetDescription();
    }

    public virtual double GetCost()
    {
        return DecoratedCoffee.GetCost();
    }
}