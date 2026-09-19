/*
"The Builder pattern separates the construction of a complex object from its representation so that the same construction 
process can create different representations."
*/
Tailor tailor = new Tailor();

Suit businessSuit = tailor.MakeSuit(new BusinessSuitBuilder());
businessSuit.Describe();

Suit weddingSuit = tailor.MakeSuit(new WeddingSuitBuilder());
weddingSuit.Describe();