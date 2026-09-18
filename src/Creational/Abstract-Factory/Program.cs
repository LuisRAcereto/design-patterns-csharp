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