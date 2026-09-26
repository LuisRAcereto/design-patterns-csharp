/* Wikipedia
"In object-oriented programming, the template method is one of the behavioral design
patterns identified by Gamma et al. in the book Design Patterns. The template method 
is a method in a superclass, usually an abstract superclass, and deifnes the skeleton
of an operation in terms of a number of high-level steps."
*/
Beverage tea = new Tea();
Beverage coffee = new Coffee();

tea.Prepare();
Console.WriteLine();
coffee.Prepare();

/*
When to Use it
Use Template Mthod when several classes share the same overall algorithm, but differ
in a few specifc steps.
It's a good choice when you want to enforce a fixed sequence of steps, while still
letting subclasses customize parts of it.
And it's helpful when you want to avoid duplicating the parts of an algorithm that
never change across every subclass.
*/