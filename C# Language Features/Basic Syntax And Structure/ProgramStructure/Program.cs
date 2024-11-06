// Define a namespace for the program
// Namespaces without the curly braces are called file-scoped namespaces
// You can add (;) end of the namespace
namespace ProgramStructure
{
    // Define a class within the namespace
    internal class Program
    {
        // Main method: the entry point of the application
        // You can use the "top level statement", in which case you will not see this method
        static void Main(string[] args)
        {
            // Statement
            var calculator_1 = new Calculator(); // What is written after "=" is called Assign Expression
            Calculator calculator_2 = new(); // Target Type
            Calculator calculator_3 = new Calculator(); // Traditional Way

            // Use methods from the Calculator class
            int sum = calculator_2.Add(5, 3);
            Console.WriteLine($"Addition Result: {sum}");

            int difference = calculator_3.Subtract(10, 4);
            Console.WriteLine($"Subtraction Result: {difference}");


            Console.ReadKey();
        }
    }

    // Define another class within the same namespace
    class Calculator
    {
        // Method to add two integers
        public int Add(int a, int b)
        {
            return a + b;
        }

        // Method to subtract two integers
        public int Subtract(int a, int b)
        {
            return a - b;
        }
    }
}
