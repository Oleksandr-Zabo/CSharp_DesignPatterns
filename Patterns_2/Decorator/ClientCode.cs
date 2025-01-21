using Patterns_2.Decorator.ConcreateDecorators;

namespace Patterns_2.Decorator;

public class ClientCode
{
    public void Main()
    {
        // Create simple coffee
        ICoffee coffee = new SimpleCoffee();
        Console.WriteLine($"Order: {coffee.GetDescription()}");
        Console.WriteLine($"Cost: ${coffee.GetCost()}");

        // Add milk
        coffee = new MilkDecorator(coffee);
        Console.WriteLine($"\nOrder: {coffee.GetDescription()}");
        Console.WriteLine($"Cost: ${coffee.GetCost()}");

        // Add sugar
        coffee = new SugarDecorator(coffee);
        Console.WriteLine($"\nOrder: {coffee.GetDescription()}");
        Console.WriteLine($"Cost: ${coffee.GetCost()}");

        // Add vanilla syrup
        coffee = new SyrupDecorator(coffee, "vanilla");
        Console.WriteLine($"\nOrder: {coffee.GetDescription()}");
        Console.WriteLine($"Cost: ${coffee.GetCost()}");
        
        // New coffee with milk and sugar
        ICoffee coffee2 = new SimpleCoffee();
        coffee2 = new MilkDecorator(coffee2);
        coffee2 = new SugarDecorator(coffee2);
        Console.WriteLine($"\nOrder 2: {coffee2.GetDescription()}");
        Console.WriteLine($"Cost: ${coffee2.GetCost()}");
    }
}