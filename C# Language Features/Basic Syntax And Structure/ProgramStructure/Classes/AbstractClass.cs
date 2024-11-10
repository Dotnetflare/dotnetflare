namespace ProgramStructure.Classes;

// Keywrod: abstract

// 1.Access Modifire -> 2.Class Type (Optional) -> 3."class" Keyword -> 4.Class Name -> 5.{}
public abstract class AbstractClass
{
    public int Id { get; set; }
    public string Title { get; set; }

    protected AbstractClass(int id, string title)
    {
        Id = id;
        Title = title;
    }

    // Abstract method to be implemented by derived classes
    public abstract string GetInfo();
}

public class DerivedFromAbstractClass : AbstractClass
{
    public string Name { get; set; }

    public DerivedFromAbstractClass(int id, string title, string name)
        : base(id, title)
    {
        Name = name;
    }

    // Override method to provide specific info
    public override string GetInfo()
    {
        return $"\n{Id}: {Title} by {Name}.";
    }
}