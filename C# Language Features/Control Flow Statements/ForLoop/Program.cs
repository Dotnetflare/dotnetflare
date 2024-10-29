namespace ForLoopExample;
class Program
{
    /// <summary>
    /// Main entry point of the application, demonstrating the use of a `for` loop
    /// by calculating the sum of numbers from 1 to a specified maximum.
    /// </summary>
    static void Main(string[] args)
    {
        // Define the maximum number for summation.
        // This could come from user input or a data source in a real-world application.
        int maxNumber = 10;
        Console.WriteLine($"Calculating the sum of numbers from 1 to {maxNumber}...\n");

        // for loop structure:
        // The for loop is a control flow structure used to repeat a block of code a specific number of times.
        // It consists of three main parts:
        //   1. Initialization: Runs once before the loop starts. This sets up the loop variable (e.g., int i = 1).
        //   2. Condition: Evaluated before each iteration. The loop continues as long as this condition is true (e.g., i <= maxNumber).
        //   3. Iterator/Update: Runs after each loop iteration to update the loop variable (e.g., i++ to increment by 1).
        //
        // Syntax of a for loop:
        // for (initialization; condition; update)
        // {
        //     // Code to execute during each loop iteration
        // }

        // Variable to store the cumulative sum
        int sum = 0;

        // Begin for loop to calculate the sum from 1 to maxNumber.
        for (int i = 1; i <= maxNumber; i++)
        {
            // Inside the loop:
            // - i represents the current number being added to the sum.
            // - The loop will run as long as i is less than or equal to maxNumber.

            sum += i; // Add the current value of i to sum.

            // Print each step to demonstrate the calculation in real-time.
            Console.WriteLine($"Adding {i}, current sum: {sum}");
        }

        // Output the final sum after the loop completes.
        Console.WriteLine($"\nThe total sum from 1 to {maxNumber} is: {sum}");

        // Summary of the for loop in this example:
        // 1. The loop starts with i = 1 (initialization).
        // 2. It checks if i <= maxNumber before each loop (condition).
        // 3. After each iteration, i is incremented by 1 (i++), progressing towards maxNumber.
        // 4. The loop stops when i exceeds maxNumber, and the final sum is displayed.

        // Advantages of using a for loop:
        // - Provides a clear, concise syntax for repeating code with a known number of iterations.
        // - Ideal for situations where you know the number of times the loop should run in advance.


        // Best Practices for `for` Loops:

        // 1. Choose the Right Loop Type:
        //    - Use a `for` loop when the number of iterations is known or can be calculated.
        //    - Avoid using `for` loops when a different structure (like `while`) would improve readability.

        // 2. Avoid Modifying Loop Counter Inside the Loop Body:
        //    - Changing the loop variable (`i`) inside the loop body can lead to confusing and hard-to-debug code.
        //    - Instead, modify only within the loop’s initialization, condition, or increment sections.

        // 3. Limit Scope of Loop Variables:
        //    - Use loop variables that are limited to the loop’s scope (e.g., `for (int i = 0; i < n; i++)`).
        //    - This helps prevent accidental misuse outside the loop.

        // 4. Minimize Operations Inside the Loop Condition:
        //    - Avoid performing complex calculations in the loop condition as it will execute on every iteration.
        //    - Move constant expressions outside the loop for better performance.

    }
}