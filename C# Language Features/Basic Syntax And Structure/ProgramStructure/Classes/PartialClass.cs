namespace ProgramStructure.Classes;

// Keyword: partial
public partial class PartialClass
{
    private List<string> items = [];

    public void AddItem(string item)
    {
        items.Add(item);
    }
}

public partial class PartialClass
{
    public void DisplayItems()
    {
        Console.WriteLine("\nItems in PartialClass:");
        foreach (var item in items)
        {
            Console.WriteLine(item);
        }
    }
}