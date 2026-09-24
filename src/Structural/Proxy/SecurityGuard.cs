// The proxy - the security guard controls who gets through
public class SecurityGuard : IBuilding
{
    private readonly OfficeBuilding _building               = new();
    private readonly List<string> _authorisedVisitors       = new() {"Alice", "Bob", "Carol"};

    public void Enter(string visitorName)
    {
        Console.WriteLine($"Guard: {visitorName} is requesting entry.");

        if(_authorisedVisitors.Contains(visitorName))
        {
            Console.WriteLine("Guard: ID verified. Access granted.");
            _building.Enter(visitorName);
        }
        else
        {
            Console.WriteLine($"Guard: {visitorName} is not on the list. Access denied.");
        }
    }
}