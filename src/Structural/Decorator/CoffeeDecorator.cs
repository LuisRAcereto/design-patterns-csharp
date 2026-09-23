// The base decorator - wraps any ICoffee and delegates to it.
public abstract class CoffeeDecorator : ICoffee
{
    protected readonly ICoffee _coffee;

    protected CoffeeDecorator(ICoffee coffee)   { _coffee = coffee; }

    public virtual string GetDescription()  => _coffee.GetDescription();
    public virtual double GetCost()         => _coffee.GetCost();
}