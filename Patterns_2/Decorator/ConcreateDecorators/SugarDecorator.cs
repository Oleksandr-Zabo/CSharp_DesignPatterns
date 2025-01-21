namespace Patterns_2.Decorator.ConcreateDecorators;

public class SugarDecorator: CoffeDecorator
{
    public SugarDecorator(ICoffee coffee) : base(coffee) { }
    
    public override string GetDescription()
    {
        return $"{DecoratedCoffee.GetDescription()}, sugar";
    }
    
    public override double GetCost()
    {
        return DecoratedCoffee.GetCost() + 5.0;
    }
}