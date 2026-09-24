// The flyweight factory - creates and caches tree types so they are never duplicated

public class TreeTypeFactory
{
    private readonly Dictionary<string, TreeType> _cache = new();

    public TreeType GetTreeType(string name, string colour, string texture)
    {
        string key = $"{name}_{colour}_{texture}";

        if (!_cache.ContainsKey(key))
        {
            Console.WriteLine($"Factory: Creating new Treetype for '{name}'.");
            _cache[key] = new TreeType(name, colour, texture);
        }

        return _cache[key];
    }

    public int TotalTypes => _cache.Count;
}