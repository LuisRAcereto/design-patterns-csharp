
/* Wikipedia:
"The decorator pattern is a design pattern that allows behaviour to be added to an individual object, dynamically,
 without affecting the behaviour of other instances of the same class." 
*/

// A plain espresso
ICoffee order = new Espresso();
Console.WriteLine($"{order.GetDescription()} = ${order.GetCost():F2}");

// Wrap it with milk
order = new Milk(order);
Console.WriteLine($"{order.GetDescription()} = ${order.GetCost():F2}");

// Wrap it with vanilla syrup on top
order = new VanillaSyrup(order);
Console.WriteLine($"{order.GetDescription()} = ${order.GetCost():F2}");

// Wrap it with whipped cream on the top of that
order = new WhippedCream(order);
Console.WriteLine($"{order.GetDescription()} = ${order.GetCost():F2}");

/*
When to Use it
Use the Decorator pattern when you want to add responsibilities to individual objects without affecting other objects of the same class.

It's also a good choice when subclassing would lead to an explosion of classes to cover every possible combination of behaviours.

And use it when you need to be able to stack behaviours in any order at runtime, independently of each other.
*/