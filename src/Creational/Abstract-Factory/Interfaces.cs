// The product interfaces -every furniture type has a contract
public interface ISofa { void Describe(); }
public interface IChair { void Describe(); }

// Teh abstract factory - every store can produce a sofa and a chair
public interface IFurnitureFactory
{
    ISofa CreateSofa();
    IChair CreateChair();
}