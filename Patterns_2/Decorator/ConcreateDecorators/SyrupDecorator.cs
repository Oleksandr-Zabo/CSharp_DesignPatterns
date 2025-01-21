namespace Patterns_2.Decorator.ConcreateDecorators;

public class SyrupDecorator: CoffeDecorator
{
    private string syrupType;

    public SyrupDecorator(ICoffee coffee, string syrupType) : base(coffee)
    {
        this.syrupType = syrupType;
    }
    
    public override string GetDescription()
    {
        return $"{DecoratedCoffee.GetDescription()}, with {syrupType} syrup";
    }
    
    public override double GetCost()
    {
        return DecoratedCoffee.GetCost() + 10.0;
    }
}