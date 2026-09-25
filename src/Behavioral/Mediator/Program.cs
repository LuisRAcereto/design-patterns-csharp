/* Wikipedia
"In software engineering, the mediator patttern defines an object that encapsulates
how a set of objects interact. This pattern is considered to be a behavioral pattern
due to the way it can alter the program's running behavior."
*/
var tower = new ControlTower();

var flight101 = new Aircraft("Flight 101", tower);
var flight202 = new Aircraft("Flight 202", tower);

tower.Register(flight101);
tower.Register(flight202);

flight101.RequestLanding();
flight202.RequestLanding();

/* 
When to Use it
Use Mediator when a group of objects communicate in complex, tangled ways, and 
you want to centralize that communication.

It's also helpful when you want to reuse objects independently, without them
being locked together by direct refereces to each other.

And reach for it when the way obgjects interact changes often, and you'd rather
change it in one place than in every object involved.
*/