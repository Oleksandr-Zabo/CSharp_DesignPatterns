namespace Patterns_3.State;

public class ClientCode
{
    public void Main()
    {
        // Create an order with a name
        Order order = new Order("Order #12345");

        order.Process(); // Process the order
        order.Ship();    // Ship the order
        order.Deliver(); // Deliver the order

        // Attempt to perform an action after delivery
        order.Process(); // This action is unavailable
        order.Ship();// This action is unavailable
    }
}