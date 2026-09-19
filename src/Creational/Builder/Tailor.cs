// The tailor - the director who runs the process
using System.Reflection.Emit;

public class Tailor
{
    public Suit MakeSuit(ISuitBuilder builder)
    {
        builder.SetFabric();
        builder.SetLining();
        builder.SetButtons();
        return builder.GetSuit();
    }
}