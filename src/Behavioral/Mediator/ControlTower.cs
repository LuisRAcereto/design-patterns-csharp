// The concrete mediator, coordinates all the aircrafts instead of letting them talk to each other
public class ControlTower : IControlTower
{
    private readonly List<Aircraft> _aircraft = new();
    private bool _runwayFree = true;

    public void Register(Aircraft aircraft) => _aircraft.Add(aircraft);

    public void RequestLanding(Aircraft requester)
    {
        if (_runwayFree)
        {
            _runwayFree = false;
            Console.WriteLine($"Tower: Runway clear. {requester.Name}, you are cleared to land.");
        }
        else
        {
            Console.WriteLine($"Tower: Runway occupied. {requester.Name}, please hold your position.");
        }
    }
}