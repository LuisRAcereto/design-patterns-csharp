// The receiver, the object that actually deos the work.
public class Light
{
    private readonly string _room;

    public Light(string room) => _room = room;

    public void On() => Console.WriteLine($"{_room} light: turned on.");
    public void Off() => Console.WriteLine($"{_room} light: turned off.");
}