// The base component - a plain espresso.
public class Espresso : ICoffee
{
    public string GetDescription()  => "Espresso.";
    public double GetCost()         => 1.00;
}