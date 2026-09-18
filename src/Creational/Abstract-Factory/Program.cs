/*
"The abstract factory pattern provides a way to create families of related objects without imposing their concrete classes, 
by encapsulating a group of individual factories that have a common theme without specifying their concrete classes."

Source: Wikipedia - Abstract factory pattern
*/

// Customer orders a Modern collection.
IFurnitureFactory factory = new ModernFurnitureFactory();
ISofa sofa = factory.CreateSofa();
IChair chair = factory.CreateChair();
sofa.Describe();
chair.Describe();

// Customer orders a Victorian collection
IFurnitureFactory factory2 = new VictorianFurnitureFactory();
ISofa sofa2 = factory2.CreateSofa();
IChair chair2 = factory2.CreateChair();
sofa2.Describe();
chair2.Describe();