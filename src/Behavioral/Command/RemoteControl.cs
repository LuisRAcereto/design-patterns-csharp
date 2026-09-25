// The invoker, it holds a command and triggers it without knowing what it does
public class RemoteControl
{
    private ICommand? _command;

    public void SetCommand(ICommand command) => _command = command;

    public void PressButton() => _command?.Execute();
    public void PressUndo() => _command?.Undo();
}