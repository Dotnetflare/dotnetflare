﻿namespace Operators;

public class Logical
{
    public static void ExplainLogical(int a, int b)
    {
        if (a > 0 && b > 0)
        {
            Console.WriteLine("AND(&&) operator returns true when both the values are true. \n" +
                "If any of the value is false then it will return false.\n");
        }

        if (a > 0 || b > 0)
        {
            Console.WriteLine("OR(||) operator returns true if any of the condition/operands is true. \n" +
                "It will return false when both of the operands are false.\n");
        }

        if (a != 0 || b != 0)
        {
            Console.WriteLine("NOT(!) operator is used to reverse the logical conclusion of any condition. \n" +
                "If the condition is true then it will return false and if the condition is false then " +
                "it will return true.\n");
        }

        //Conditional Operator
        var result = a > 0 ? b : a;
        Console.WriteLine($"a > 0 ? b : a result: {result}\n");
    }
}
