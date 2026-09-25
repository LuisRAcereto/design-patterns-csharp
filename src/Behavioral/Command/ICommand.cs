// The command interfae, every action implements this
public interface ICommand
{
    void Execute();
    void Undo();
}