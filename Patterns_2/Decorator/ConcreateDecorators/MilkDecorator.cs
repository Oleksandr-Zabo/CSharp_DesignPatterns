namespace Patterns_2.Decorator.ConcreateDecorators;

public class MilkDecorator: CoffeDecorator
{
    public MilkDecorator(ICoffee coffee) : base(coffee) { }
    
    public override string GetDescription()
    {
        return $"{DecoratedCoffee.GetDescription()}, milk";
    }
    
    public override double GetCost()
    {
        return DecoratedCoffee.GetCost() + 7.0;
    }
}