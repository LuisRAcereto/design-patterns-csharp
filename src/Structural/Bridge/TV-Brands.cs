// Concrete implemantations - each brand handles things its own way.
public class SonyTV : ITV
{
    public void TurnOn()                => Console.WriteLine("Sony TV: Powering on. BRAVIA display ready");
    public void TurnOff()               => Console.WriteLine("Sony TV: Shutting down.");
    public void SetChannel(int ch)      => Console.WriteLine($"Sony TV: Switching to channel {ch}.");
    public void SetVolume(int vol)      => Console.WriteLine($"Sony TV: Volume set to {vol}.");
}

public class SamsungTV : ITV
{
    public void TurnOn()                => Console.WriteLine("Samsung TV: Powering on. Smart Hub loading.");
    public void TurnOff()               => Console.WriteLine("Samsung TV: Shutting down.");
    public void SetChannel(int ch)      => Console.WriteLine($"Samsung TV: Switching to channel {ch}.");
    public void SetVolume(int vol)      => Console.WriteLine($"Samsung TV: Volume set to {vol}.");
}