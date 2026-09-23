using System.Data.Common;

public class Department : IEmployee
{
    private readonly List<IEmployee> _members = new();

    public string Name { get; }
    public Department(string name) { Name = name; }

    public void Add(IEmployee employee)     => _members.Add(employee);
    public void Remove(IEmployee employee)  => _members.Remove(employee);

    public int GetSalary() => _members.Sum(m => m.GetSalary());

    public void GetDetails(string indent = "" )
    {
        Console.WriteLine($"{indent}|{Name} Total: ${GetSalary():N0}");
        foreach (var member in _members)
            member.GetDetails(indent + " ");
    }
}