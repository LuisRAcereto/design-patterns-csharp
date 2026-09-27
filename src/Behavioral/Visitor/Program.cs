/* Wikipedia
"The visitor design pattern is a way of separating an algorithm form an object
strcuture on which it operates.
*/
var cart = new List<IItem>
{
    new Book("Design Patterns", 45.00m),
    new Electronic("Headphones", 120.00m)
};

var pricingVisitor = new PricingVisitor();

foreach (var item in cart)
{
    item.Accept(pricingVisitor);
}

Console.WriteLine($"Total: ${pricingVisitor.Total:F2}");

/*
When to Use it
Use Visitor when you need to perform operations across a group of unrelated classes,
without polluting each class with that logic.
It's also helpful when you want to add new operations often, but the object structure
itself rarely changes.
And it's a good choice when you would otherwise need type check or casting to figure
out what to do with each object in a collection.
*/