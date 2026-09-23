// The leaf - a single employee with no reports.
using System.Globalization;

public class Employee : IEmployee
{
    private readonly int _salary;

    public string Name { get; }

    public Employee(string name, int salary)
    {
        Name = name;
        _salary = salary;
    }

    public int GetSalary()                          => _salary;
    public void GetDetails(string indent = "")      => Console.WriteLine($"{indent}- {Name} (${_salary:N0})");
}

/*
When to Use it
Use Composite when you need to represent part-whole hierarchies, like trees where individual items and groups of items need to be used interchangeably.

It also works well when you want client code to treat single objects and collections of objects uniformly, without any special-casing.

And it's a good fit when the structure can be nested to any depth and that depth shouldn't affect how the caller interacts with it.
*/