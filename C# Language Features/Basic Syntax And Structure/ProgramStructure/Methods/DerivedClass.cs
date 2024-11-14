namespace ProgramStructure.Methods;

public class DerivedClass : BaseClass
{
    public sealed override void VirtualMethod()
    {
        // Referring to the previous implementation of the method in the base class (Optional)
        base.VirtualMethod();

        // Custom implementation
        Console.WriteLine("\nFinal implementation method {BaseClass} -> {DerivedClass}");
    }
}
