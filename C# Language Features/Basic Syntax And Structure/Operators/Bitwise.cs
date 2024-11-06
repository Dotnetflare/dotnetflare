namespace Operators;

public class Bitwise
{
    public static void EaplainBitwise(int a, int b)
    {
        int result;

        result = a & b;
        Console.WriteLine("Bitwise AND: " + result);

        result = a | b;
        Console.WriteLine("Bitwise OR: " + result);

        result = a ^ b;
        Console.WriteLine("Bitwise aOR: " + result);

        result = ~a;
        Console.WriteLine("Bitwise Complement: " + result);

        result = a << 2;
        Console.WriteLine("Bitwise Left Shift: " + result);

        result = a >> 2;
        Console.WriteLine("Bitwise Right Shift: " + result);
    }
}
