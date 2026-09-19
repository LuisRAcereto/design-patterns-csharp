// Business suit builder
using System.Configuration.Assemblies;

public class BusinessSuitBuilder: ISuitBuilder
{
    private Suit _suit = new Suit();

    public void SetFabric() => _suit.Fabric = "Dark wool";
    public void SetLining() => _suit.Lining = "Silk";
    public void SetButtons() => _suit.Buttons = "Black horn";
    public Suit GetSuit() => _suit;
}

// Wedding suit builder
public class WeddingSuitBuilder : ISuitBuilder
{
    private Suit _suit = new Suit();

    public void SetFabric() => _suit.Fabric = "Ivory linen";
    public void SetLining() => _suit.Lining = "Satin";
    public void SetButtons() => _suit.Buttons = "Pearl";
    public Suit GetSuit() => _suit;
}