// The prototype interface -every shape must be able to clone itself
public abstract class Shape
{
    public string? Colour { get; set; }
    public int Size { get; set; }

    public abstract Shape Clone();
    public abstract void Describe();
}