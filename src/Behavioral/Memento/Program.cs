/* Wikipedia
"The memento pattern is a software design pattern that provides the ability to
restore an object to its previous state (undo via rollback)."
*/
var editor = new TextEditor();
var history = new History();

editor.Write("Hello");
history.Save(editor.Save());

editor.Write(", world");
history.Save(editor.Save());

editor.Write("!!!");
Console.WriteLine($"Current: {editor.Content}");

editor.Restore(history.Undo());
Console.WriteLine($"After undo (1): {editor.Content}");

editor.Restore(history.Undo());
Console.WriteLine($"After undo (2): {editor.Content}");


/*
When to Use it
Use Memento when you need undo/redo functionality and want to capture state without
exposign an object's internals.

It's also a good choice when taking a snapshot directly would break encapsulation
by exposing private fields.

And it's helpful when you want the object taht stores history to stay dumb:
like holding snapshots without knowing or caring what's inside them.
*/