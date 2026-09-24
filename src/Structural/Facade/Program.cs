/* Wikipedia
"The facade pattern (also spelled façade) is a software-design pattern commonly used in 
object-oriented programming. Analogous to a facade in architecture, a facade is an object 
that serves as a front-facing interface masking more complex underlying or structural code."
*/
OrderFacade store = new OrderFacade();

store.PlaceOrder(
    item:           "Wireles headphones",
    cardNumber:     "41111111111111234",
    amount:         79.99,
    address:        "42 Mapple Stree, London",
    email:          "customer@email.com"
);

/*
When to Use it
Use Facade when you want to provide a simple interface to a complex subsystem so callers aren't burdened by its internals.

It also works well when you want to layer your system so that high-level code talks to facades, not directly to low-level subsystems.

And it's a good choice when you want a single entry point that coordinates a sequence of steps across multiple services.
*/