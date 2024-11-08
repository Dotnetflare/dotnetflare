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
        Console.WriteLine("PartialClass_2 Display Items");
    }
}