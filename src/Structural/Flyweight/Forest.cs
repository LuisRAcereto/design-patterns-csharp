// The forest -plants tree using shared flyweights
public class Forest
{
    private readonly List<Tree>         _trees   = new();
    private readonly TreeTypeFactory    _factory = new();

    public void PlanTree(int x, int y, string name, string colour, string texture)
    {
        TreeType type = _factory.GetTreeType(name, colour, texture);
        _trees.Add(new Tree(x, y, type));
    }

    public void Render()
    {
        foreach(var tree in _trees)
            tree.Render();
    }

    public int TreeCount => _trees.Count;
    public int TreeTypeCount => _factory.TotalTypes;
}