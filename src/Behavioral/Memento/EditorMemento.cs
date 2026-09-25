// The memento, an immutable snapshot of the editor's state
public class EditorMemento
{
    public string Content { get; }

    public EditorMemento(string content) => Content = content;
}