// A concerete visitor, adds a new operation without touching Book or Electronic
public class PricingVisitor : IVisitor
{
    public decimal Total { get; private set; }

    public void Visit (Book book)
    {
        Console.WriteLine($"Book: {book.Title} - ${book.Price:F2} (no tax).");
        Total += book.Price;
    }

    public void Visit(Electronic electronic)
    {
        var priceWithTax = electronic.Price * 1.15m;
        Console.WriteLine($"Electronic: {electronic.Name} - ${priceWithTax:F2} (with 15% tax)");
        Total += priceWithTax;
    }
}