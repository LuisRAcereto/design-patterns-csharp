// Concrete elements, each accepts a visitor and hands itself over.
public class Book : IItem
{
    public string Title { get; }
    public decimal Price { get; }

    public Book(string title, decimal price)
    {
        Title = title;
        Price = price;
    }

    public void Accept(IVisitor visitor) => visitor.Visit(this);
}

public class Electronic : IItem
{
    public string Name { get; }
    public decimal Price { get; }

    public Electronic(string name, decimal price)
    {
        Name = name;
        Price = price;
    }

    public void Accept(IVisitor visitor) => visitor.Visit(this);
}