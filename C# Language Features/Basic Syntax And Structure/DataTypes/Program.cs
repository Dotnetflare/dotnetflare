#region Value Types

#region Integral Types

int integerNumber = -42 * 42;

uint uintNumber = 43;

long longNumber = -123456789L * 123456789L;

ulong ulongNumber = 123456789L;

short shortNumber = -2 * 320;

ushort ushortNumber = 32000;

byte byteNumber = 255;

sbyte sbyteNumber = -100;

#endregion

#region Floating Point Types

float floatNumber = 3.14f;

double doubleNumber = 3.14159;

decimal decimalNumber = 19.368M;

#endregion

#region Boolean Type

bool hasAccess = true;
bool isDeleted = false;

#endregion

#region Character Type

char letter = 'A';

#endregion

#endregion

#region Reference Types

string text = "Hello World!";

object obj = null;

dynamic dynamic = null;

#endregion

var name = "Alex";
var num = 0;


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