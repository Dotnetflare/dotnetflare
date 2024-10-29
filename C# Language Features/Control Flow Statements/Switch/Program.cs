namespace SwitchExample;

class Program
{
    /// <summary>
    /// The main entry point of the application, which evaluates a student's grade
    /// and provides feedback based on predefined criteria using a switch-case statement.
    /// </summary>
    static void Main(string[] args)
    {
        // Initialize a sample grade for evaluation.
        // In a real-world scenario, this might come from user input or a data source.
        char grade = 'B';
        Console.WriteLine("Student Grade: " + grade);

        // Switch-case structure explanation:
        // The switch statement is a control flow tool for evaluating a single expression
        // against multiple potential cases. Each case represents a specific match condition.
        // - If a case matches the expression, the code within that case block is executed.
        // - The switch provides an efficient way to branch to different sections of code based on the value.
        // - A default case can be included to handle any value not specifically covered by the cases.

        // Basic syntax of switch-case:
        // switch (expression)
        // {
        //     case constant1:
        //         // Code to run if expression == constant1
        //         break;
        //     case constant2:
        //         // Code to run if expression == constant2
        //         break;
        //     default:
        //         // Code to run if no case matches the expression
        //         break;
        // }

        // Example of switch-case in action:

        switch (grade)
        {
            case 'A':
                // The 'case' keyword checks if the variable 'grade' matches the character 'A'.
                // If true, this block executes, and the feedback message below is displayed.
                Console.WriteLine("Excellent performance!");
                Console.WriteLine("Keep up the outstanding work!");
                break; // 'break' exits the switch statement, preventing further cases from running.

            case 'B':
                // This case checks if 'grade' equals 'B'.
                // If so, it provides feedback specific to a 'B' grade.
                Console.WriteLine("Good job!");
                Console.WriteLine("You're doing well but keep pushing for an 'A'.");
                break; // 'break' is necessary to prevent falling through to the next case.

            case 'C':
                // This case runs if 'grade' equals 'C'.
                // It displays feedback appropriate for a 'C' grade.
                Console.WriteLine("Fair effort.");
                Console.WriteLine("Consider reviewing the material to improve.");
                break;

            case 'D':
                // Runs if 'grade' equals 'D'.
                // Provides specific feedback to motivate improvement.
                Console.WriteLine("You passed, but there's room for improvement.");
                Console.WriteLine("Consider seeking extra help or additional study.");
                break;

            case 'F':
                // This case handles the 'F' grade.
                // Feedback here is encouraging but emphasizes the need for significant improvement.
                Console.WriteLine("Unfortunately, this is a failing grade.");
                Console.WriteLine("Don't give up! Review the material and ask for help if needed.");
                break;

            default:
                // The 'default' case handles any value of 'grade' that isn't covered above.
                // Useful for cases where unexpected input could occur.
                // Here, it warns of an invalid grade input.
                Console.WriteLine("Invalid grade entered.");
                Console.WriteLine("Please enter a valid grade (A, B, C, D, or F).");
                break;
        }

        // Switch expression:
        // In C# 8+, we can use a switch expression to directly return a result based on 
        // the evaluated value. This can make code shorter, more readable, and expressive.
        // 
        // Syntax:
        // var result = expression switch
        // {
        //     pattern1 => result1,
        //     pattern2 => result2,
        //     _ => defaultResult
        // };
        //
        // Here, 'grade' is matched against different character patterns ('A', 'B', etc.),
        // and each pattern returns a corresponding string message.

        // Using switch expression to evaluate the grade and provide feedback.
        string feedback = grade switch
        {
            'A' => "Excellent performance!\nKeep up the outstanding work!",
            'B' => "Good job!\nYou're doing well but keep pushing for an 'A'.",
            'C' => "Fair effort.\nConsider reviewing the material to improve.",
            'D' => "You passed, but there's room for improvement.\nConsider seeking extra help or additional study.",
            'F' => "Unfortunately, this is a failing grade.\nDon't give up! Review the material and ask for help if needed.",
            _ => "Invalid grade entered.\nPlease enter a valid grade (A, B, C, D, or F)." // '_' is the default pattern in switch expressions.
        };

        // Explanation of the switch expression used here:
        // - The 'grade switch' expression simplifies the multiple 'case' blocks into a single expression.
        // - Each case is represented as 'pattern => result', and multiple cases are evaluated quickly.
        // - The '_' symbol is the default pattern, covering any values not explicitly matched (like invalid inputs).
        // - This approach reduces boilerplate code by eliminating the need for 'break' statements.

        // Output the feedback result
        Console.WriteLine(feedback);
        Console.WriteLine("\nGrade evaluation complete. Remember, each grade is a step on your learning journey!");

        // Summary of switch-case control flow in this example:
        // 1. The program evaluates 'grade' against each case (A, B, C, D, F).
        // 2. If a match is found, the code for that case executes, and the program exits the switch.
        // 3. If no match is found, the default case runs, providing an error message.
        // 4. This control structure is useful for cleaner code when checking a single variable against known values.
    }
}