// The abstract class, defines the skeleton of the algorithm
public abstract class Beverage
{
    // The template method, the steps and their order never change
    public void Prepare()
    {
        BoilWater();
        Brew();
        PourInCup();
        AddCondiments();
    }

    private void BoilWater() => Console.WriteLine("Boiling water.");
    private void PourInCup() => Console.WriteLine("Pouring into cup.");

    // Steps left for subclasses to fill in
    protected abstract void Brew();
    protected abstract void AddCondiments();
}