namespace Operators;

public class Assignment
{
    public static void ExplainAssignment(int a, int b)
    {
        //a = a + b;
        a += b;
        Console.WriteLine($"a += b: {a}");

        //a = a - b;
        a -= b;
        Console.WriteLine($"a -= b: {a}");

        if (b is 0)
            throw new DivideByZeroException();

        //a = a / b;
        a /= b;
        Console.WriteLine($"a /= b: {a}");

        //a = a * b;
        a *= b;
        Console.WriteLine($"a *= b: {a}");

        //a = a%b;
        a %= b;
        Console.WriteLine($"a %= b: {a}");

        a = b;
        Console.WriteLine($"a = b: {a}\n");
    }
}
