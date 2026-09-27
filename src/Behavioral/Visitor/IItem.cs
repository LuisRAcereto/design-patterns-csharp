// The element interface, every item is the car implements this.
public interface IItem
{
    void Accept(IVisitor visitor);
}