namespace Operators;

public class Relational
{
    public static void ExplainRelational(int a, int b)
    {
        bool validate;

        validate = a > b;
        Console.WriteLine($"a > b: {validate}");

        validate = a < b;
        Console.WriteLine($"a < b: {validate}");

        validate = a == b;
        Console.WriteLine($"a == b: {validate}");

        validate = a >= b;
        Console.WriteLine($"a >= b: {validate}");

        validate = a <= b;
        Console.WriteLine($"a <= b: {validate}");

        validate = a != b;
        Console.WriteLine($"a != b: {validate}\n");
    }
}