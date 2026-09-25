public class YouTubeChannel
{
    private readonly string _name;
    private readonly List<ISubscriber> _subscribers = new();

    public YouTubeChannel(string name) => _name = name;

    public void Subscribe(ISubscriber subscriber) => _subscribers.Add(subscriber);
    public void Unsubscribe(ISubscriber subscriber) => _subscribers.Remove(subscriber);

    public void UploadVideo(string title)
    {
        Console.WriteLine($"{_name}: Uploaded '{title}'.");

        foreach(var subscriber in _subscribers)
        {
            subscriber.Notify(_name, title);
        }
    }
}