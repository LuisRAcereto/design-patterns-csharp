// The context, holds a strategy and delegates the actual payment work to it.
public class ShoppingCart
{
    private readonly decimal _total;
    private IPaymentStrategy? _paymentMethod;

    public ShoppingCart(decimal total) => _total = total;

    public void SetPaymentMethod(IPaymentStrategy method) => _paymentMethod = method;

    public void CheckOut()
    {
        if (_paymentMethod is null)
        {
            Console.WriteLine("No payment method selected.");
            return;
        }

        _paymentMethod.Pay(_total);
    }
}