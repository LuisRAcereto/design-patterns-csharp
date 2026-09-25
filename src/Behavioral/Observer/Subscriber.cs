// The concrete observer
public class Subscriber : ISubscriber
{
    private readonly string _name;

    public Subscriber(string name) => _name = name;

    public void Notify(string channelName, string videoTitle)
    {
        Console.WriteLine($"{_name}: {channelName} just uploaded '{videoTitle}'!");
    }
}