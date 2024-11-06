namespace Operators;

public class Relational
{
    public static void ExplainRelational(int a, int b)
    {
        bool validate;

        //Greater than operator: (denoted by “>”): Validates greater than the relation between operands.
        validate = a > b;
        Console.WriteLine($"a > b: {validate}");

        //Less than operator: (denoted by “<“): Validates less than the relation between operands.
        validate = a < b;
        Console.WriteLine($"a < b: {validate}");

        //Equals To operator: (denoted by “==”): Validates the equality of two operands.
        validate = a == b;
        Console.WriteLine($"a == b: {validate}");

        //Greater than or equals to (denoted by “>=”):
        //Validates greater than or equals to the relation between the two operands.
        validate = a >= b;
        Console.WriteLine($"a >= b: {validate}");

        //Less than or equals to (denoted by “<=”):
        //Validates less than or equals to the relations between the two operands.
        validate = a <= b;
        Console.WriteLine($"a <= b: {validate}");

        //Not equal: (denoted by “!=”): Validates not an equal relationship between the two operands.
        validate = a != b;
        Console.WriteLine($"a != b: {validate}\n");
    }
}