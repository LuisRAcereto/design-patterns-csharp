// Subsystem 2: handles the payment.
public class PaymentService
{
    public bool ProcessPayment(string cardNumber, double amount)
    {
        Console.WriteLine($"Payment: Charging ${amount:F2} to card ending {cardNumber[^4..]}.");
        return true;
    }
}