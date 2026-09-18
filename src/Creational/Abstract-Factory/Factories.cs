// Concrete factories -- each one produces its own collection
public class ModernFurnitureFactory: IFurnitureFactory
{
    public ISofa CreateSofa() => new ModernSofa();
    public IChair CreateChair() => new ModernChair();
}

public class VictorianFurnitureFactory: IFurnitureFactory
{
    public ISofa CreateSofa() => new VictorianSofa();
    public IChair CreateChair() => new VictorianChair();
}