namespace Patterns_1.AbstractFactory;

public interface IAbstractFactory
{
    IChair CreateChair();
    ISofa CreateSofa();
    ICoffeeTable CreateCoffeeTable();
}
    
public abstract class AbstractFactory : IAbstractFactory
{
    public abstract IChair CreateChair();
    public abstract ISofa CreateSofa();
    public abstract ICoffeeTable CreateCoffeeTable();
}

// Each Concrete Factory has a corresponding product variant.

public class ModernFurnitureFactory : AbstractFactory
{
    public override IChair CreateChair()
    {
        return new ModernChair();
    }

    public override ISofa CreateSofa()
    {
        return new ModernSofa();
    }

    public override ICoffeeTable CreateCoffeeTable()
    {
        return new ModernCoffeeTable();
    }
}

public class VictorianFurnitureFactory : AbstractFactory
{
    public override IChair CreateChair()
    {
        return new VictorianChair();
    }

    public override ISofa CreateSofa()
    {
        return new VictorianSofa();
    }

    public override ICoffeeTable CreateCoffeeTable()
    {
        return new VictorianCoffeeTable();
    }
}