// Concrete decorators - each one add its own layer
public class Milk : CoffeeDecorator
{
    public Milk(ICoffee coffee) : base(coffee) { }

    public override string GetDescription() => _coffee.GetDescription() + ", Milk";
    public override double GetCost()        => _coffee.GetCost() + 0.30;
}


public class VanillaSyrup : CoffeeDecorator
{
    public VanillaSyrup(ICoffee coffee) : base(coffee) { }

    public override string GetDescription() => _coffee.GetDescription() + ", Vanilla Syrup";
    public override double GetCost()        => _coffee.GetCost() + 0.50;
}

public class WhippedCream : CoffeeDecorator
{
    public WhippedCream(ICoffee coffee) : base(coffee) { }

    public override string GetDescription() => _coffee.GetDescription() + ", Whipped Cream";
    public override double GetCost()        => _coffee.GetCost() + 0.75;
}