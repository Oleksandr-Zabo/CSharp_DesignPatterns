namespace Patterns_3.State;

// Base state class
public abstract class OrderState
{
    public virtual void Process(Order order)
    {
        Console.WriteLine($"Action 'Process' is unavailable for order '{order.Name}' in the current state.");
    }

    public virtual void Ship(Order order)
    {
        Console.WriteLine($"Action 'Ship' is unavailable for order '{order.Name}' in the current state.");
    }

    public virtual void Deliver(Order order)
    {
        Console.WriteLine($"Action 'Deliver' is unavailable for order '{order.Name}' in the current state.");
    }
}

// Concrete states
class NewState : OrderState
{
    public override void Process(Order order)
    {
        Console.WriteLine($"Processing the order '{order.Name}'...");
        order.SetState(new ProcessingState());
    }
}

class ProcessingState : OrderState
{
    public override void Ship(Order order)
    {
        Console.WriteLine($"Shipping the order '{order.Name}'...");
        order.SetState(new ShippedState());
    }
}

class ShippedState : OrderState
{
    public override void Deliver(Order order)
    {
        Console.WriteLine($"Delivering the order '{order.Name}'...");
        order.SetState(new DeliveredState());
    }
}

class DeliveredState : OrderState
{
    public override void Process(Order order)
    {
        Console.WriteLine($"Order '{order.Name}' has already been delivered.");
    }
}

