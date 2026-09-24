# Behavioral Design Patterns

Behavioral patterns are all about **how ogbjects communicate and share responsibility.** They focus on the assignment of responsibilities betweeen objects, and how objects cooperate to get a job done.

**As per Wikipedia**
>In software engineering, behavioral design patterns are design patterns that identify common communication patterns among objects. By doing so, these patters increase flexiblity in carrying out this communications.

There are 11 behavioral design patterns:
1. **Chain of Responsibility:** Passes a reqeust along a chain of handlers, letting each one decide to handle it or pass it on.
2. **Command:** Encapsulates a request as an object, letting you parameterize clients, queue actions, and support undo.
3. **Interpreter:** Given a language, defines a representation for its grammar along with an interpreter that evalutes sentences in it.
4. **Iterator:** Provides a way to access the elements of a collection sequentially without exposing how it's built underneath.
5. **Mediator:** Defines an object that encapsulates how a set of objects interact, so they don't refer to each other directly.
6. **Memento:** Captures an object's internal state so it can be restored later, without breaking encapsulation.
7. **Observer:** Defines a one-to-many depedency so that when one object chages state, everything depending on it is notified automatically.
8. **State:** Lets an object change its behavrioius when its internal state changes, as if it had changed its class.
9. **Strategy:** Defines a family of interchangeable algorithms and lets the client pick which one to use at runtime.
10. **Template Method:** DEfines the skeleton of an algorithm in a method, leaving some steps for subclasses to fill in.
11. **Visitor:** Lets you define a new operation without changing the classes of the elements it operates on.