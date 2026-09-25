// Concrete commands, each wraps a receiver and an action
using System.Windows.Input;

public class LightOnCommand : ICommand
{
    private readonly Light _light;

    public LightOnCommand(Light light) => _light = light;

    public void Execute() => _light.On();
    public void Undo() => _light.Off();
}

public class LightOffCommand : ICommand
{
    private readonly Light _light;

    public LightOffCommand(Light light) => _light = light;

    public void Execute() => _light.Off();
    public void Undo() => _light.On();
    
}