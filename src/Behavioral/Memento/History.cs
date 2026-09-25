// The caretaker, stores memetos without ever looking inside them
public class History
{
    private readonly Stack<EditorMemento> _snapshots = new();

    public void Save(EditorMemento memento) => _snapshots.Push(memento);

    public EditorMemento Undo() => _snapshots.Pop();
}