namespace Operators;

public class Arithmetic
{
    public static void ExplainArithmetic(int a, int b)
    {
        int result;

        result = a + b;
        Console.WriteLine($"a + b = {result}");

        result = a - b;
        Console.WriteLine($"a - b = {result}");

        result = a * b;
        Console.WriteLine($"a * b = {result}");

        if (b is 0) 
            throw new DivideByZeroException();

        result = a / b;
        Console.WriteLine($"a / b = {result}");

        result = a % b;
        Console.WriteLine($"a % b = {result}");

        result = a++;
        Console.WriteLine($"increment a = {result}");

        result = b--;
        Console.WriteLine($"decrement b = {result}");
    }
}
