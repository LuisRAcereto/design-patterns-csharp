// See https://aka.ms/new-console-template for more information
// Violinist ask for the conductor
OrchestraCondutor violinist = OrchestraCondutor.GetInstance();

// Pianist ask for the conductor
OrchestraCondutor pianist = OrchestraCondutor.GetInstance();

// Are they talking to the same conductor?
Console.WriteLine(object.ReferenceEquals(violinist, pianist));  // True

violinist.SetTempo("Allegro");
pianist.Start();
