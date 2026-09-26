// Concrete strategies, each a different way to pay.
public class CreditCardPayment : IPaymentStrategy
{
    private readonly string _cardNumber;

    public CreditCardPayment(string cardNumber) => _cardNumber = cardNumber;

    public void Pay(decimal amount)
    {
        Console.WriteLine($"Chaged ${amount} to credit card ending in {_cardNumber[^4..]}.");
    }
}

public class PayPalPayment : IPaymentStrategy
{
    private readonly string _email;

    public PayPalPayment (string email) => _email = email;

    public void Pay(decimal amount)
    {
        Console.WriteLine($"Charged ${amount} via PayPal account {_email}.");
    }
}