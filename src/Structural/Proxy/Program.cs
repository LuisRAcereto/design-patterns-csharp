/* Wikipedia
"A proxy, in its most general form, is a class functioning as an interface to something
 else. The proxy could interface to anything: a network connection, a large object in memory, 
 a file, or some other resource that is expensive or impossible to duplicate."
*/
IBuilding entrance = new SecurityGuard();

entrance.Enter("Alice");
Console.WriteLine();
entrance.Enter("David");
Console.WriteLine();
entrance.Enter("Bob");

/*
Use Proxy when you need access control, like only letting certain callers through to the real object.

It's a good fit when you want to add behaviour such as logging, caching, or validation without changing the real object.

And you can use it when the real object is expensive to create and you want to delay or guard that creation until it's truly needed.
*/