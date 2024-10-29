namespace WhileLoopExample;

class Program
{
    /// <summary>
    /// Main entry point of the application, demonstrating the use of a `while` loop
    /// by implementing a countdown from a specified start number down to zero.
    /// </summary>
    static void Main(string[] args)
    {
        // Define the starting number for the countdown.
        int startNumber = 10;
        Console.WriteLine($"Starting countdown from {startNumber}...\n");

        // while loop structure:
        // The while loop repeatedly executes a block of code as long as a specified condition remains true.
        // It is particularly useful when the number of iterations is not known in advance, and we want to 
        // keep running until a specific condition is met.
        //
        // Syntax:
        // while (condition)
        // {
        //     // Code to execute as long as condition is true
        // }

        // In this case, the condition is startNumber >= 0, which will allow the countdown to continue until 
        // startNumber is less than zero.

        // Begin while loop for countdown.
        while (startNumber >= 0)
        {
            // Print the current number in the countdown.
            Console.WriteLine($"Countdown: {startNumber}");

            // Decrement startNumber by 1 to move towards ending the loop.
            startNumber--;

            // Important Note:
            // - The decrement operation (startNumber--) is critical because it moves startNumber closer 
            //   to the condition that ends the loop (startNumber < 0).
            // - Without this, the loop would continue infinitely since startNumber would always be >= 0.
        }

        // Once the loop exits, print a final message to indicate the end of the countdown.
        Console.WriteLine("\nCountdown complete!");

        // Explanation of the while loop in this example:
        // 1. Before each iteration, the condition (startNumber >= 0) is checked.
        // 2. If the condition is true, the loop executes the code block.
        // 3. After each iteration, startNumber is decreased by 1 (startNumber--).
        // 4. The loop stops when startNumber is less than 0, meaning the countdown is finished.

        // Key Advantages of a while loop:
        // - Useful when the number of iterations is not predetermined.
        // - Continues as long as the condition is true, making it ideal for scenarios where the end condition
        //   is determined dynamically within the loop.


        // Best Practices for `while` Loops:

        // 1. Use `while` for Unknown or Dynamic Iteration Counts:
        //    - Use a `while` loop when the number of iterations is not known in advance and depends on conditions within the loop.
        //    - Avoid using it if a set iteration count can be determined, as a `for` loop may be more appropriate.

        // 2. Always Ensure the Loop Condition Can Become False:
        //    - To avoid infinite loops, ensure that the condition can eventually be met by modifying a variable or state inside the loop.

        // 3. Avoid Complex Conditions:
        //    - Complex conditions can make `while` loops hard to read. Break down complicated logic into helper functions if needed.

        // 4. Minimize Operations Inside the Condition:
        //    - Avoid performing unnecessary operations within the `while` condition to prevent excessive processing.

    }
}