// The Facade - one method, hides all four subsystems.
public class OrderFacade
{
    private readonly InventoryService _inventory = new();
    private readonly PaymentService _payment = new();
    private readonly ShippingService _shipping = new();
    private readonly EmailService _email = new();

    public void PlaceOrder(string item, string cardNumber, double amount, string address, string email)
    {
        Console.WriteLine("=== Placing Order ===");

        if (!_inventory.CheckStock(item))
        {
            Console.WriteLine("Order failed: item out of stock.");
            return;
        }

        if (!_payment.ProcessPayment(cardNumber, amount))
        {
            Console.WriteLine("Order failed: payment declined.");
        }

        string trackingCode = _shipping.GenerateLabel(item, address);
        _email.SendConfirmation(email, trackingCode);

        Console.WriteLine($"\nOrder complete. Your tracking code is {trackingCode}.");
    }
}