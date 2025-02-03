namespace Patterns_3.Visitor_TemplateMethod;

// Base class for an order (Template Method Pattern)
abstract class Order
{
    public double Amount { get; set; } // Order amount
    public string CustomerName { get; set; } // Customer name

    // Template Method: Defines the order processing algorithm
    public void ProcessOrder()
    {
        ValidateOrder();
        ApplyDiscount();
        ConfirmOrder();
        LogOrder();
    }

    // Steps to be implemented by subclasses
    protected abstract void ValidateOrder();
    protected abstract void ApplyDiscount();
    protected abstract void ConfirmOrder();
    protected abstract void LogOrder();
}

// Standard order (Template Method Pattern)
class StandardOrder : Order
{
    protected override void ValidateOrder()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Validating standard order for {CustomerName}...");
        Console.ResetColor();
    }

    protected override void ApplyDiscount()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Discount for standard order: 0%");
        Console.ResetColor();
    }

    protected override void ConfirmOrder()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"Standard order for {CustomerName} confirmed.");
        Console.ResetColor();
    }

    protected override void LogOrder()
    {
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine($"Logging standard order: {CustomerName}, Amount: {Amount}");
        Console.ResetColor();
    }
}

// Express order (Template Method Pattern)
class ExpressOrder : Order
{
    protected override void ValidateOrder()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Validating express order for {CustomerName}...");
        Console.ResetColor();
    }

    protected override void ApplyDiscount()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Discount for express order: 5%");
        Amount *= 0.95; // Apply 5% discount
        Console.ResetColor();
    }

    protected override void ConfirmOrder()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"Express order for {CustomerName} confirmed.");
        Console.ResetColor();
    }

    protected override void LogOrder()
    {
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine($"Logging express order: {CustomerName}, Amount: {Amount}");
        Console.ResetColor();
    }
}

// Wholesale order (Template Method Pattern)
class WholesaleOrder : Order
{
    protected override void ValidateOrder()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Validating wholesale order for {CustomerName}...");
        Console.ResetColor();
    }

    protected override void ApplyDiscount()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Discount for wholesale order: 10%");
        Amount *= 0.90; // Apply 10% discount
        Console.ResetColor();
    }

    protected override void ConfirmOrder()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"Wholesale order for {CustomerName} confirmed.");
        Console.ResetColor();
    }

    protected override void LogOrder()
    {
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine($"Logging wholesale order: {CustomerName}, Amount: {Amount}");
        Console.ResetColor();
    }
}