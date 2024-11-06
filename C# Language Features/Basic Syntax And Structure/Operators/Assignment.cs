namespace Operators;

public class Assignment
{
    public static void ExplainAssignment(int a, int b)
    {
        //It adds the operand at the right side to the left operand
        //and stores the final value in the left operand.

        //a = a + b;
        a += b;
        Console.WriteLine($"a += b: {a}");

        //it subtracts the value of the right operand from the left operand
        //and then assigns the value to the left operand.

        //a = a - b;
        a -= b;
        Console.WriteLine($"a -= b: {a}");

        if (b is 0)
            throw new DivideByZeroException();

        //It divides the value of the right operand with the left operand
        //and then stores the result in the left operand.

        //a = a / b;
        a /= b;
        Console.WriteLine($"a /= b: {a}");

        //It multiplies the value of the right operand with the left operand
        //and then stores the result in the left operand.

        //a = a * b;
        a *= b;
        Console.WriteLine($"a *= b: {a}");

        //It finds the modulus of the left and right operand and stores the value in the left operand.

        //a = a%b;
        a %= b;
        Console.WriteLine($"a %= b: {a}");

        //Equals to (“=”): It is one of the simplest assignment operators.
        //It assigns the value of one operand to another.
        //i.e. the value of the right side operand to the left side operand.
        a = b;
        Console.WriteLine($"a = b: {a}\n");
    }
}
