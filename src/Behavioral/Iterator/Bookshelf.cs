// The aggregate, exposes an iterator without revealing how books are stored
using System.Collections;
public class Bookshelf : IEnumerable<string>
{
    private readonly List<string> _books = new();

    public void Add(string title) => _books.Add(title);

    public IEnumerator<string> GetEnumerator() => new BookshelfIterator(_books);

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}