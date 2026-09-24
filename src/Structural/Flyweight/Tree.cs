// The context - holds unique extrinsic state (position) and a reference to a shared flyweight
public class Tree
{
    private readonly int            _x;
    private readonly int            _y;
    private readonly TreeType       _type;

    public Tree(int x, int y, TreeType type)
    {
        _x      = x;
        _y      = y;
        _type   = type;
    }

    public void Render() => _type.Render(_x, _y);
}