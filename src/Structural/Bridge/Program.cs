/* Wikipedia definition of the pattern
"The bridge pattern is a design pattern used in software engineering that is meant to decouple an abstraction from its implementation
so that the two can vary independently."
*/

// Basic remote paired with a Sony TV
Console.WriteLine("--- Basic Remote + Sony TV ----");
RemoteControl basicSony = new BasicRemote(new SonyTV());
basicSony.TurnOn();
basicSony.SetChannel(5);
basicSony.TurnOff();

// Smart remote paired with a Samsung TV
Console.WriteLine("\n--- Smart Remote + Samsung TV ---");
SmartRemote smartSamsung = new SmartRemote(new SamsungTV());
smartSamsung.TurnOn();
smartSamsung.SetChannel(10);
smartSamsung.SetVolume(20);
smartSamsung.TurnOff();

// Swap freely - smart remote now with Sony, no code changes needed.
Console.WriteLine("\n--- Smart Remote + Sony TV ---");
SmartRemote smartSony = new SmartRemote(new SonyTV());
smartSony.TurnOn();
smartSony.SetChannel(3);
smartSony.TurnOff();


/* 
When to Use it
Use the Bridge pattern when you want to avoid a permanent binding between an abstraction and its implementation, so either can be swapped at runtime.

You can also use it when both the abstraction and the implementation should be independently extensible through subclassing.

And it's a good fit when changes to the implementation should have no impact on the client code. The client shouldn't need to be recompiled.
*/