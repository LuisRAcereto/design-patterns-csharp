// The observer interface, every subscriber implements this
public interface ISubscriber
{
    void Notify(string channelName, string VideoTitle);
}