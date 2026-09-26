// The context, delegates behavior to whatever state it currently holds
public class Order
{
    public IOrderState State { get; set; } = new PendingState();

    public void Next()
    {
        Console.WriteLine($"Order is currently: {State.Name}");
        State.Next(this);
    }
}