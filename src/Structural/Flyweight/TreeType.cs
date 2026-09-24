// The flyweight - holds shared intrisic state (same for all three of this type)
public class TreeType
{
    public string Name { get; }
    public string Colour { get; }
    public string Texture { get; }

    public TreeType(string name, string colour, string texture)
    {
        Name    = name;
        Colour  = colour;
        Texture = texture;
    }

    public void Render(int x, int y)
    {
        Console.WriteLine($"Rendering {Name} tree ({Colour}, {Texture}) at ({x}, {y}).");
    }
}