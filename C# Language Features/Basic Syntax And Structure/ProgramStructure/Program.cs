using ProgramStructure.Constructors;

// 1. Define a namespace for the program.
// 2. Namespaces without the curly braces are called file-scoped namespaces,
// you can add (;) end of the namespace
namespace ProgramStructure
{
    // Define a class within the namespace
    internal class Program
    {
        /// <summary>
        /// Main method: the entry point of the application
        /// You can use the "top level statement", in which case you will not see this method
        /// </summary>
        /// <param name="args"></param>
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

            #region Constructors

            // Default Constructor
            Vehicle vehicle1 = new("Toyota");

            // Parameterized Constructor (Overloaded with two parameters)
            Vehicle vehicle2 = new("Honda", "Civic");

            // Parameterized Constructor (Overloaded with three parameters)
            Vehicle vehicle3 = new("Ford", "Mustang", 2020);

            // Constructor Chaining within the same class
            Vehicle vehicle4 = new("Chevrolet", 2021);

            // Copy Constructor
            Vehicle vehicle5 = new(vehicle3);

            // Using the private constructor via a static method
            var vehicle6 = Vehicle.CreateDefaultVehicle();

            // Constructor Chaining in Base Class
            Car car1 = new("BMW", "X5", 2022, "Petrol");

            #endregion

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
