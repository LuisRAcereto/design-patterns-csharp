// Subsystem 1: checks whether the item is available.
public class InventoryService
{
    public bool CheckStock(string item)
    {
        Console.WriteLine($"Inventory: Checking stock for {item}");
        return true;
    }
}