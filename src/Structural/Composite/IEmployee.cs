// The component interface - every leaf and composite shares this contract
public interface IEmployee
{
    string Name { get; }
    int GetSalary();
    void GetDetails(string indent = "");
}