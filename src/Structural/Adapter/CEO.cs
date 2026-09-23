// The CEO, only knows how to talk to an IEnglishSpeaker
using System.IO.Compression;

public class CEO
{
    private readonly IEnglishSpeaker _speaker;

    public CEO(IEnglishSpeaker speaker)
    {
        _speaker = speaker;
    }

    public void Address(string message)
    {
        Console.WriteLine($"CEO (English): {message}");
        _speaker.Speak(message);
    }
}