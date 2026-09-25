/* Wikipedia
"The command pattern is a behavioral design pattern in which an object is used to
encapsulate all information needed to perform an action or trigger an event at a
later time."
*/
var livingRoomLight = new Light("Living Room");
var remote          = new RemoteControl();

remote.SetCommand(new LightOnCommand(livingRoomLight));
remote.PressButton();

remote.SetCommand(new LightOffCommand(livingRoomLight));
remote.PressButton();

Console.WriteLine();
Console.WriteLine("Undoing last action...");
remote.PressUndo();


/*
When to Use it
Use the Command pattern when you want to parameterize objects with an action to perform, rather than hard-coding it.

Reach for it when you need to queue, log, or support undo for requests.

And consider it when you want to decouple the object that invokes an action from the object that knows how to perform it.
*/