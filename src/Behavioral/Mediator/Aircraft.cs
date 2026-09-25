// The collegue, only ever talks to the mediator, never to other aircraft directly
public class Aircraft
{
    public string Name { get; }

    private readonly IControlTower _tower;

    public Aircraft(string name, IControlTower tower)
    {
        Name = name;
        _tower = tower;
    }

    public void RequestLanding()
    {
        Console.WriteLine($"{Name}: Requesting permission to land.");
        _tower.RequestLanding(this);
    }
}