
// var defining structure
var name = "Alex";
var num = 0;

// Real Examples:

byte age = 25;
sbyte temperature = -5;
short population = 30000;
ushort speedLimit = 65;
int distance = 1500;
uint bankBalance = 100000;
long starsInGalaxy = 100000000000L;
ulong distanceToSun = 92900000UL;
float pi = 3.14f;
double gpa = 3.75;
decimal price = 19.99M;
bool isRaining = true;
char initial = 'A';
string greeting = "Hello, World!";
object objType = "I am an object!";
dynamic message = "This is dynamic typing!";

Console.WriteLine($"Age: {age}");
Console.WriteLine($"Temperature: {temperature}°C");
Console.WriteLine($"Population: {population}");
Console.WriteLine($"Speed Limit: {speedLimit} mph");
Console.WriteLine($"Distance: {distance} meters");
Console.WriteLine($"Bank Balance: ${bankBalance}");
Console.WriteLine($"Estimated Stars in Galaxy: {starsInGalaxy}");
Console.WriteLine($"Distance to Sun: {distanceToSun} miles");
Console.WriteLine($"Value of Pi: {pi}");
Console.WriteLine($"GPA: {gpa}");
Console.WriteLine($"Price: ${price}");
Console.WriteLine($"Is it raining? {isRaining}");
Console.WriteLine($"Initial: {initial}");
Console.WriteLine(greeting);
Console.WriteLine(objType);
Console.WriteLine(message);

Console.ReadKey();