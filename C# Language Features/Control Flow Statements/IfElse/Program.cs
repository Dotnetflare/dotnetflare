namespace IfElseExample;

class Program
{
    /// <summary>
    /// The main entry point of the application, which evaluates a student's score
    /// and assigns a grade based on predefined criteria using if-else statements.
    /// </summary>
    static void Main(string[] args)
    {
        // Initialize a sample score for evaluation.
        // In a real application, this score could be user input or retrieved from a database.
        int score = 85;
        Console.WriteLine("Student Score: " + score);

        // if-else structure explanation:
        // The if-else control structure allows us to execute code conditionally.
        // Each 'if' checks a specific condition (a true/false statement).
        // - If the condition evaluates to true, the associated block of code runs.
        // - If false, it moves to the next 'else if' or 'else' block.
        // This allows us to handle multiple scenarios in sequence, providing different outputs depending on the conditions.

        // Basic syntax of if-else:
        // if (condition)
        // {
        //     // Code to run if condition is true
        // }
        // else if (anotherCondition)
        // {
        //     // Code to run if previous condition is false, but this one is true
        // }
        // else
        // {
        //     // Code to run if all previous conditions are false
        // }

        // Example of if-else in action:

        if (score >= 90)
        {
            // This block executes if the score is 90 or above.
            // 'if' keyword starts the condition, and the expression inside the parentheses (score >= 90)
            // is the condition. Here, we're checking if 'score' is greater than or equal to 90.
            // - If true: The statements inside this block run, assigning a grade of 'A'.
            // - If false: It moves to the next 'else if' block.
            Console.WriteLine("Grade: A");
            Console.WriteLine("Remark: Excellent performance.");
        }
        else if (score >= 80)
        {
            // This block only runs if the previous 'if' condition is false (score < 90),
            // and this condition (score >= 80) is true.
            // 'else if' adds another condition to check after the initial 'if' fails.
            // This block is only reached if the score is between 80 and 89.
            Console.WriteLine("Grade: B");
            Console.WriteLine("Remark: Good job! Keep pushing for an 'A'.");
        }
        else if (score >= 70)
        {
            // Additional 'else if' blocks can be added to handle more specific cases.
            // This block only runs if both previous conditions (score >= 90 and score >= 80) are false,
            // and if this condition (score >= 70) is true. In this case, it assigns a grade of 'C'.
            Console.WriteLine("Grade: C");
            Console.WriteLine("Remark: Fair effort, but there's room for improvement.");
        }
        else if (score >= 60)
        {
            // This block checks if all previous conditions are false and the score is between 60 and 69.
            // The 'else if' is useful for checking a specific range and avoids redundant conditions.
            Console.WriteLine("Grade: D");
            Console.WriteLine("Remark: You passed, but aim for a higher score next time.");
        }
        else
        {
            // The 'else' statement catches any cases not covered by the previous conditions.
            // - 'else' does not have a condition; it runs if none of the previous 'if' or 'else if' statements are true.
            // This is a "catch-all" block for scores below 60, assigning a grade of 'F'.
            Console.WriteLine("Grade: F");
            Console.WriteLine("Remark: Unfortunately, this is a failing grade. Consider reviewing the material.");
        }

        // The if-else structure concludes here.
        // Once a condition is met and its block runs, the entire structure is exited.
        // For instance, if score is 85, only the 'else if (score >= 80)' block runs, and none of the others are checked.

        // Final message for user interaction.
        Console.WriteLine("\nGrade evaluation complete. Remember to keep improving and aim higher!");

        // Summary of if-else control flow in this example:
        // 1. The program checks each 'if' or 'else if' condition in order.
        // 2. As soon as it finds a true condition, it executes that block and skips the rest.
        // 3. If none of the conditions are true, it defaults to the 'else' block.
        // This allows efficient branching where only one path is taken depending on the first true condition.


        // Best Practices for `if-else` Statements:

        // 1. Minimize Nested `if` Statements:
        //    - Deeply nested `if` statements can make code hard to read and maintain.
        //    - Use guard clauses to exit early, especially if certain conditions make further checks unnecessary.
        //    Example:
        //if (!isValid) return; // Guard clause instead of additional nesting.

        // 2. Use `else if` for Mutually Exclusive Conditions:
        //    - To avoid multiple `else` levels, use `else if` for conditions that are mutually exclusive.
        //    - This improves readability and avoids unnecessary condition checks.

        // 3. Avoid Redundant Conditions:
        //    - If conditions overlap, ensure that only the necessary checks are used.
        //    - Redundant checks can lead to inefficient code and may cause logical errors.

        // 4. Be Cautious with Floating Point Comparisons:
        //    - When comparing floating-point numbers, avoid direct equality checks due to precision issues.
        //    - Instead, check if the difference is within a small tolerance, e.g., `Math.Abs(a - b) < tolerance`.

        // 5. Use Ternary Operators for Simple Assignments:
        //    - For simple conditional assignments, consider using the ternary operator to keep the code concise.
        //    Example:
        //int ageCategory = age > 18 ? "Adult" : "Minor";
    }
}