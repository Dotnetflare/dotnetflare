namespace ProgramStructure.Classes;

// Keyword: sealed
public sealed class SealedClass : DerivedFromAbstractClass
{
    public byte Number { get; set; }

    public SealedClass(int id, string title, string name, byte number)
        : base(id, title, name)
    {
        Number = number;
    }

    public override string GetInfo()
    {
        return $"{Id}: {Title} {Name} {Number}";
    }
}
