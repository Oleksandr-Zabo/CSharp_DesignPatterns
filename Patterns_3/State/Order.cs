namespace Patterns_3.State;
public class Order
{
    private OrderState _state;
    public string Name { get; private set; } // Name of the order

    public Order(string name)
    {
        Name = name; // Set the order name
        _state = new NewState(); // Initial state
    }

    public void SetState(OrderState state)
    {
        _state = state;
    }

    public void Process()
    {
        _state.Process(this);
    }

    public void Ship()
    {
        _state.Ship(this);
    }

    public void Deliver()
    {
        _state.Deliver(this);
    }
}


