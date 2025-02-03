namespace Patterns_3.Visitor_TemplateMethod;
public class ClientCode
{
    public void Main()
    {
        // Create an order manager
        var orderManager = new OrderManager();

        // Add orders
        orderManager.AddOrder(new StandardOrder { CustomerName = "John", Amount = 1000 });
        orderManager.AddOrder(new ExpressOrder { CustomerName = "Alice", Amount = 2000 });
        orderManager.AddOrder(new WholesaleOrder { CustomerName = "Company XYZ", Amount = 5000 });

        // Add visitors
        orderManager.AddVisitor(new DiscountVisitor());
        orderManager.AddVisitor(new LoggingVisitor());

        // Process orders
        orderManager.ProcessOrders();
    }
}