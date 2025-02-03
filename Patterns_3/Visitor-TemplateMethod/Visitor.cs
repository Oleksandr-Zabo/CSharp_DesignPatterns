namespace Patterns_3.Visitor_TemplateMethod;

// Visitor interface (Visitor Pattern)
interface IOrderVisitor
{
    void Visit(StandardOrder order);
    void Visit(ExpressOrder order);
    void Visit(WholesaleOrder order);
}

// Discount visitor (Visitor Pattern)
class DiscountVisitor : IOrderVisitor
{
    public void Visit(StandardOrder order)
    {
        Console.WriteLine("No discount applied for standard order.");
    }

    public void Visit(ExpressOrder order)
    {
        Console.WriteLine("Applying 5% discount for express order.");
        order.Amount *= 0.95; // Apply 5% discount
    }

    public void Visit(WholesaleOrder order)
    {
        Console.WriteLine("Applying 10% discount for wholesale order.");
        order.Amount *= 0.90; // Apply 10% discount
    }
}

// Logging visitor (Visitor Pattern)
class LoggingVisitor : IOrderVisitor
{
    public void Visit(StandardOrder order)
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine($"[Log] Standard order: {order.CustomerName}, Amount: {order.Amount}");
        Console.ResetColor();
    }

    public void Visit(ExpressOrder order)
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine($"[Log] Express order: {order.CustomerName}, Amount: {order.Amount}");
        Console.ResetColor();
    }

    public void Visit(WholesaleOrder order)
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine($"[Log] Wholesale order: {order.CustomerName}, Amount: {order.Amount}");
        Console.ResetColor();
    }
}