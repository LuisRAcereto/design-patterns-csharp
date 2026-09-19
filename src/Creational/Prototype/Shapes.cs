// Concrete shapes
public class Circle : Shape
{
    public override Shape Clone() => (Shape)this.MemberwiseClone();
    public override void Describe() => Console.WriteLine($"Cirle | Colour: {Colour} | Size: {Size}");
}

public class Rectangle : Shape
{
    public override Shape Clone() => (Shape)this.MemberwiseClone();
    public override void Describe() => Console.WriteLine($"Rectangle | Colour: {Colour} | Size: {Size}");
}