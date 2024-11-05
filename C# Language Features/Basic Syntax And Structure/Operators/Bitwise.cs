namespace Operators;

public class Bitwise
{
    public static void EaplainBitwise(int a, int b)
    {
        int result;

        // Bitwise AND Operator
        result = a & b;
        Console.WriteLine("Bitwise AND: " + result);

        // Bitwise OR Operator
        result = a | b;
        Console.WriteLine("Bitwise OR: " + result);

        // Bitwise aOR Operator
        result = a ^ b;
        Console.WriteLine("Bitwise aOR: " + result);

        // Bitwise Complement Operator
        result = ~a;
        Console.WriteLine("Bitwise Complement: " + result);

        // Bitwise LEFT SHIFT Operator
        result = a << 2;
        Console.WriteLine("Bitwise Left Shift: " + result);

        // Bitwise RIGHT SHIFT Operator
        result = a >> 2;
        Console.WriteLine("Bitwise Right Shift: " + result);
    }
}
