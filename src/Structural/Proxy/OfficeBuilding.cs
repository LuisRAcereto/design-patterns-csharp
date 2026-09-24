// The real subgject - the actual building, just grants entry
public class OfficeBuilding : IBuilding
{
    public void Enter(string visitorName)
    {
        Console.WriteLine($"Building: {visitorName} has entered.");
    }
}