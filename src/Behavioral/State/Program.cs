/* Wikipedia
"The state patter is a behavioral software design pattern that allows an object to 
alter its behavior when its internal state changes. This pattern is close to the
concept of finite-state machines.
*/
var order = new Order();

order.Next();
order.Next();
order.Next();
order.Next();

/* 
When to Use it
Use State when an object's behavior depends on its state, and it must
change that behavior at run time as the state changes.
It's also helpful when you have large conditional blocks that branch on the 
object's current state or type.
And choose it when transitions between states shouuld be explicit and self-
contained, rather than scattered across one big method.
*/