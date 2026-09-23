// The abstraction - the remote holds a reference to whichever tv it controls
public abstract class RemoteControl
{
    protected ITV _tv;

    protected RemoteControl(ITV tv) { _tv = tv; }

    public abstract void TurnOn();
    public abstract void TurnOff();
    public abstract void SetChannel(int channel);
    public abstract void SetVolume(int volume);
}