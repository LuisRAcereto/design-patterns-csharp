// Subsystem 3: generates a shipping label
public class ShippingService
{
    public string GenerateLabel(string item, string address)
    {
        Console.WriteLine($"Shipping: Generating label for {item} to {address}.");
        return "TRACK-29384";
    }
}