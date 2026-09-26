// The state interface, every state implements this
public interface IOrderState
{
    void Next(Order order);
    string Name { get; }
}