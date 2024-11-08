namespace ProgramStructure.Classes;

// Keywrod: abstract
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
        return $"{Id}: {Title} by {Name}.";
    }
}