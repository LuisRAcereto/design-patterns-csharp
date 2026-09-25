// The iterator, walks the collection one book at the time
using System.Collections;
public class BookshelfIterator : IEnumerator<string>
{
    private readonly List<string> _books;
    private int _position = -1;

    public BookshelfIterator(List<string> books) => _books = books;

    public string Current => _books[_position];

    object IEnumerator.Current => Current;

    public bool MoveNext()
    {
        _position++;
        return _position < _books.Count;
    }

    public void Reset() => _position = -1;

    public void Dispose() { }
}