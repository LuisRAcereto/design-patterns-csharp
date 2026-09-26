// A concrete class, fills in the steps specific to tea
public class Tea : Beverage
{
    protected override void Brew() => Console.WriteLine("Steeping the tea bag.");
    protected override void AddCondiments() => Console.WriteLine("Adding lemon.");
}

// Another concrete class, fills in the steps specific to coffee
public class Coffee : Beverage
{
    protected override void Brew() => Console.WriteLine("Brewing the coffee grounds.");
    protected override void AddCondiments() => Console.WriteLine("Adding sugar and milk.");
}