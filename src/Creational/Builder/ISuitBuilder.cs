// The builder - defines the steps
using System.Net.Security;

public interface ISuitBuilder
{
    void SetFabric();
    void SetLining();
    void SetButtons();
    Suit GetSuit();
}