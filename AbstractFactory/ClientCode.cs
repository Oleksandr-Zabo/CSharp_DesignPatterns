namespace Patterns_1.AbstractFactory;

public class ClientCode
{
    public void Main()
    {
        Console.WriteLine("Furniture Shop Demo\n");

        // Demonstration of creating and using Modern furniture
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Creating Modern Furniture Set:");
        var modernShop = new FurnitureShop(new ModernFurnitureFactory());
        var modernSet = modernShop.CreateFurnitureSet();
        modernSet.ShowDescription();
        modernSet.DemonstrateUsage();

        // Demonstration of creating and using Victorian furniture
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("\nCreating Victorian Furniture Set:");
        var victorianShop = new FurnitureShop(new VictorianFurnitureFactory());
        var victorianSet = victorianShop.CreateFurnitureSet();
        victorianSet.ShowDescription();
        victorianSet.DemonstrateUsage();

        Console.ResetColor();
    }
}