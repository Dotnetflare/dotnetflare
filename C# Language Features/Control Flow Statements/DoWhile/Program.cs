namespace DoWhileLoopExample;
class Program
{
    /// <summary>
    /// Main entry point of the application, demonstrating the use of a `do-while` loop.
    /// The program repeatedly prompts the user to enter a positive number, validating input.
    /// </summary>
    static void Main(string[] args)
    {
        int number;

        // do-while loop structure:
        // The do-while loop executes a block of code once before checking the condition.
        // After the first execution, it checks the condition to decide if the loop should continue.
        //
        // Syntax:
        // do
        // {
        //     // Code to execute at least once
        // }
        // while (condition);

        // Begin do-while loop to ensure the code block runs at least once.
        do
        {
            Console.Write("Please enter a positive number: ");

            // Attempt to parse the input as an integer.
            // If parsing fails, it will set number to -1 to ensure re-prompting in the loop.
            bool isValidInput = int.TryParse(Console.ReadLine(), out number);

            // Validation:
            // - isValidInput checks if the input is a valid integer.
            // - number > 0 ensures that the input is positive.
            // If either condition fails, the loop will run again to re-prompt.
            if (!isValidInput || number <= 0)
            {
                Console.WriteLine("Invalid input. Make sure to enter a positive number.\n");
            }

        } while (number <= 0); // Condition to keep looping if number is not positive.

        // Once the user enters a valid positive number, the loop exits.
        Console.WriteLine($"\nThank you! You've entered a positive number: {number}");

        // Explanation of the do-while loop in this example:
        // 1. The code inside the do block runs at least once, regardless of the condition.
        // 2. After each execution, the while condition (number <= 0) is checked.
        // 3. If the condition is true, the loop continues, re-prompting the user for input.
        // 4. If the condition is false (i.e., a positive number is entered), the loop exits.

        // Key Characteristics of a do-while loop:
        // - Ensures that the code inside the loop runs at least once, even if the condition is initially false.
        // - Typically used when we need one guaranteed execution (like prompting for user input).
        // - The condition is evaluated only after the code block has executed.


        // Best Practices for `do-while` Loops:

        // 1. Use When at Least One Execution is Required:
        //    - `do-while` is best suited for scenarios where the loop body needs to run at least once, such as user input validation.

        // 2. Avoid Using When Condition May Be Initially False:
        //    - Only use `do-while` when it's acceptable for the loop body to run even if the condition could initially be false.

        // 3. Ensure Exit Condition is Reachable:
        //    - Make sure the loop body modifies a variable or state so that the `while` condition can eventually be false.
        //    - This helps avoid infinite loops and ensures the loop exits as expected.

        // 4. Keep the Loop Body Short and Focused:
        //    - Since `do-while` loops can be harder to understand at a glance, aim to keep the body concise and clear.

    }
}