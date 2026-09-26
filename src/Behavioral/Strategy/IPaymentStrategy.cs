// The strategy interface, every payment method implement this
public interface IPaymentStrategy
{
    void Pay(decimal amount);
}