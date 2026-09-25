/* Wikipedia
"The observer pattern is a software design pattern in which an object, named the
subjeect, maintains a list of its dependents, called observers, and notifies them
automatically of any state changes, usually by calling one of their methods.
*/
var channel = new YouTubeChannel("Code With Isaiah");

var alice = new Subscriber("Alice");
var bob = new Subscriber("Bob");

channel.Subscribe(alice);
channel.Subscribe(bob);

channel.UploadVideo("Design Patterns Explained");

channel.Unsubscribe(bob);
channel.UploadVideo("Understanding the Observer Pattern");

/* 
When to Use it
Use Observer when a change to one object should automatically update an unknown
number of others.

It's also useful when you want objects to stay loosely coupled: the subject only
knows about an observer interface, never concrete details.

And it's a good option when the number of dependents can grow or shrink at
runtime, such as a subscribing and unsubscribing.
*/