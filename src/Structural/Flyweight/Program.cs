/*
"A flyweight is an object that minimizes memory usage by sharing as much data as 
possible with other similar objects. It is a way to use objects in large numbers 
when a simple repeated representation would use an unacceptable amount of memory."
*/
Forest forest = new Forest();

// Plant 6 trees = only 2 unique types
forest.PlanTree(1, 5, "Oak", "Dark Green", "Rough bark");
forest.PlanTree(3, 12, "Oak", "Dark Green", "Rough bark");
forest.PlanTree(7, 2, "Oak", "Dark Green", "Rough bark");
forest.PlanTree(10, 8, "Pine", "Light Green", "Smooth bark");
forest.PlanTree(15, 3, "Pine", "Light Green", "Smooth bark");
forest.PlanTree(20, 14, "Pine", "Light Green", "Smooth bark");

forest.Render();

Console.WriteLine($"\nTrees planted:                    {forest.TreeCount}");
Console.WriteLine($"Unique tree types in memory:        {forest.TreeTypeCount}");

/*
When to Use it
Use Flyweight when your application needs to create a very large number of similar objects that would otherwise consume too much memory.

It's also useful when most of the object's state can be made shared across instances, with only a small part being unique per instance.

And it's a good choice when the unique part of the state can be passed in externally rather than stored inside every object.
*/