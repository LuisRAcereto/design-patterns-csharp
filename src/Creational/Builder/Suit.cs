// The product
public class Suit
{
    public string? Fabric { get; set; }
    public string? Lining { get; set; }
    public string? Buttons { get; set; }

    public void Describe()
    {
        Console.WriteLine($"Suit: {Fabric} fabric, {Lining} lining, {Buttons} buttons.");
    }
}