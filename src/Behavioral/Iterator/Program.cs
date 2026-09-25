/* Wikipedia
"In object-oriented programming, the iterator pattern is a design pattern in which
an iterator is used to traverse a contaienr and access the container's elements.
*/
var bookshelf = new Bookshelf();
bookshelf.Add("Clean Code");
bookshelf.Add("The Pragmatic Programmer");
bookshelf.Add("Design Patterns");

foreach (var book in bookshelf)
{
    Console.WriteLine($"On the shelf: {book}");
}

/*
When to Use it
Use Iterator when you want to traverse a collection without exposing its internal structure.

It's also a good choice when you need to support multiple simultaneous traversals over 
the same collection.

And try it when you want your custom collection to work with the language's built-in
iteration syntax, like foreach.
*/