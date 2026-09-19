/*
"The Prototype pattern is used when the type of objects to create is determined by a prototypical instance, which is cloned to produce new objects."
*/

// Create one configured circle
Circle original = new Circle { Colour = "Red", Size = 50 };

// Clone it instead of building from Scratch
Shape clone1 = original.Clone();
Shape clone2 = original.Clone();

// Modify the clones independently
clone2.Colour = "Blue";

original.Describe();
clone1.Describe();
clone2.Describe();