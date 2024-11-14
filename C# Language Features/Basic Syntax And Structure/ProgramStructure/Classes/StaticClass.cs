namespace ProgramStructure.Classes;

// Keyword: static
public static class StaticClass
{
    public static void DisplayStaticItems(List<string> items)
    {
        foreach (var item in items)
        {
            Console.WriteLine(item);
        }
    }
}
