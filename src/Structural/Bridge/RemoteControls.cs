// Refined abstraction - a basic remote, does exaxtly what the TV does
public class BasicRemote : RemoteControl
{
    public BasicRemote(ITV tv) : base(tv) { }

    public override void TurnOn()                   => _tv.TurnOn();
    public override void TurnOff()                  => _tv.TurnOff();
    public override void SetChannel(int channel)    => _tv.SetChannel(channel);
    public override void SetVolume(int volume)      => _tv.SetVolume(volume);
}

// Refined abstraction - a smart remote, adds its own behavior on top
public class SmartRemote : RemoteControl
{
    public SmartRemote(ITV tv) : base(tv) { }

    public override void TurnOn()
    {
        Console.WriteLine("Smart Remote: Activating voice control.");
        _tv.TurnOn();
    }

    public override void TurnOff()
    {
        Console.WriteLine("Smart Remote: Saving watch history.");
        _tv.TurnOff();
    }

    public override void SetChannel(int channel)
    {
        Console.WriteLine("Smart Remote: Looking up channel guide.");
        _tv.SetChannel(channel);
    }

    public override void SetVolume(int volume)
    {
        Console.WriteLine("Saving the last know value, to reset it if turned off.");
        _tv.SetVolume(volume);
    }
}