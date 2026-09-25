/* Wikipedia
"In computer programming, the interpreter patter is a design pattern that specifies how 
to evaluate sentences in a language. The basic idea is to have a class for each symbol 
(terminal or nonterminal) in a specialized computer language.
*/
// (5 plus 3) minus 2
Expression expression = new Subtract(
    new Add(new Number(5), new Number(3)),
    new Number(2)
);

Console.WriteLine($"Result: {expression.Interpret()}");

// (10 minus 4) plus (2 plus 2)
Expression another = new Add(
    new Subtract(new Number(10), new Number(4)),
    new Add(new Number(2), new Number(2))
);

Console.WriteLine($"Result: {another.Interpret()}");

/*
When to Use it
use Interpreter when you have a simple language or grammar to evaluate, and representing
it as a tree of expressions keeps it manageable.

It also works well when the grammar is relatively stable. For example, adding new rules
means adding new classes, not rewriting existing ones.

And it's useful when you would rather have many small, focused classes than one large
method trying to parse and evalute everything at once.
*/