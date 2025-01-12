namespace Patterns_1.AbstractFactory;

// Class for creating furniture
public class FurnitureShop
{
    private readonly IAbstractFactory _factory;

    public FurnitureShop(IAbstractFactory factory)
    {
        _factory = factory;
    }

    // Method for creating a set of furniture
    public FurnitureSet CreateFurnitureSet()
    {
        return new FurnitureSet
        {
            Chair = _factory.CreateChair(),
            Sofa = _factory.CreateSofa(),
            CoffeeTable = _factory.CreateCoffeeTable()
        };
    }
}

// Class for a set of furniture
public class FurnitureSet
{
    public IChair Chair { get; set; }
    public ISofa Sofa { get; set; }
    public ICoffeeTable CoffeeTable { get; set; }

    public void ShowDescription()
    {
        Console.WriteLine("\nFurniture Set contains:");
        Console.WriteLine($"Chair: {Chair.Description()}");
        Console.WriteLine($"Sofa: {Sofa.Description()}");
        Console.WriteLine($"Coffee Table: {CoffeeTable.Description()}");
    }

    public void DemonstrateUsage()
    {
        Console.WriteLine("\nTrying furniture:");
        Console.WriteLine(Chair.SitOn());
        Console.WriteLine(Chair.Move());
        Console.WriteLine($"Chair: {Chair.Description()}");
        Console.WriteLine(Sofa.SitOn());
        Console.WriteLine(Sofa.Lying());
        Console.WriteLine($"Sofa: {Sofa.Description()}");
        Console.WriteLine(CoffeeTable.PutOn());
        Console.WriteLine(CoffeeTable.Eat());
        Console.WriteLine(CoffeeTable.TakeOff());
        Console.WriteLine($"Coffee Table: {CoffeeTable.Description()}");
    }
}