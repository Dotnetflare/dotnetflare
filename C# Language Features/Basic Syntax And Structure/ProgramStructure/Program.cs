using ProgramStructure.Constructors;
using ProgramStructure.Methods;

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
            var sum = calculator_2.Add(5, 3);
            Console.WriteLine($"Addition Result: {sum}");

            var difference = calculator_3.Subtract(10, 4);
            Console.WriteLine($"Subtraction Result: {difference}");

            Console.WriteLine("\n------Constructors------");

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

            Console.WriteLine("\n------Methods------");

            #region Methods

            // Instantiate BaseClass
            BaseClass baseClass = new();

            // Call lambda expression
            Console.WriteLine("\nSquare of 5: " + baseClass.square(5));

            // Call virtual method
            baseClass.VirtualMethod();

            // Call static method
            BaseClass.StaticMethod();

            // Call method overloading
            var number = 10;
            var result = baseClass.Print(number);
            Console.WriteLine("\nResult after Print overload with int: " + result);
            baseClass.Print("\nOverloaded Print with string");

            // Call method with ref and out parameters
            int x = 5, y = 10, z;
            var sum_result = baseClass.MethodParameterExample(x, ref y, out z);
            Console.WriteLine($"\nMethodParameterExample result: sum = {sum_result}, z = {z}");


            // Call generic method
            baseClass.GenericMethod("Hello");
            baseClass.GenericMethod(123);

            // Use an extension method
            var sentence = "Hello, this is a sample sentence.";
            Console.WriteLine($"\nWord count: {sentence.WordCount()}");

            // Use abstract class - implement Shape in a derived class
            Shape shape = new Circle(); // Circle is a hypothetical class that inherits Shape
            shape.Draw();

            // Instantiate DerivedClass
            DerivedClass derivedClass = new();

            // Call overridden VirtualMethod
            derivedClass.VirtualMethod();

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
