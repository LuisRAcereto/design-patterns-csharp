// The originator, creates and restores from mementos of its own state.
public class TextEditor
{
    public string Content { get; private set; } = string.Empty;

    public void Write (string text) => Content += text;

    public EditorMemento Save() => new(Content);

    public void Restore(EditorMemento memento) => Content = memento.Content;
}