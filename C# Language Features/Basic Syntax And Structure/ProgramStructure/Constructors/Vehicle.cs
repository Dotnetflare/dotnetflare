namespace ProgramStructure.Constructors;

public class Vehicle
{
    public string Owner { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }

    // Private constructor - restricts instantiation
    private Vehicle()
    {
        Console.WriteLine("Private Constructor called.");
    }

    // Default Constructor
    public Vehicle(string owner)
    {
        Owner = owner;
        Console.WriteLine($"Default Constructor called. Owner: {Owner}");
    }

    // Parameterized Constructor (Constructor Overloading - 1)
    public Vehicle(string owner, string model)
    {
        Owner = owner;
        Model = model;
        Console.WriteLine($"Constructor Overload (Owner, Model) called. Owner: {Owner}, Model: {Model}");
    }

    // Parameterized Constructor (Constructor Overloading - 2)
    public Vehicle(string owner, string model, int year)
    {
        Owner = owner;
        Model = model;
        Year = year;
        Console.WriteLine($"Parameterized Constructor called. Owner: {Owner}, Model: {Model}, Year: {Year}");
    }

    // Constructor Chaining within the same class
    public Vehicle(string owner, int year) : this(owner, "Unknown Model", year)
    {
        Console.WriteLine("Constructor Chaining within the same class called.");
    }

    // Copy Constructor
    public Vehicle(Vehicle otherVehicle)
    {
        Owner = otherVehicle.Owner;
        Model = otherVehicle.Model;
        Year = otherVehicle.Year;
        Console.WriteLine("Copy Constructor called.");
    }

    // Static method to instantiate using the private constructor
    public static Vehicle CreateDefaultVehicle()
    {
        return new Vehicle();
    }
}

// Inherited class demonstrating Constructor Chaining in Base Class
public class Car : Vehicle
{
    public string FuelType { get; set; }

    // Constructor chaining in inheritance
    public Car(string owner, string model, int year, string fuelType) : base(owner, model, year)
    {
        FuelType = fuelType;
        Console.WriteLine($"Car Constructor called. FuelType: {FuelType}");
    }
}
