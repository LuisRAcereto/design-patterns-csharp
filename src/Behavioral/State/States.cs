// Concrete states, each knows waht comes after it.
public class PendingState : IOrderState
{
    public string Name => "Pending";

    public void Next(Order order) => order.State = new ShippedState();
}

public class ShippedState : IOrderState
{
    public string Name =>"Shipped";

    public void Next(Order order) => order.State = new DeliveredState();
}

public class DeliveredState : IOrderState
{
    public string Name => "Delivered";

    public void Next (Order order)
    {
        Console.WriteLine("Order has already been delivered. Nothing left to do.");
    }
}