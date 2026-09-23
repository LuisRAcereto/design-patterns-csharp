// The implementation interface - what any Tv MUST BE ABLE TO DO
public interface ITV
{
    void TurnOn();
    void TurnOff();
    void SetChannel(int channel);
    void SetVolume(int volume);
}