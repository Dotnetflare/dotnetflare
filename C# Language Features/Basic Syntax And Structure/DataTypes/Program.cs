/*In C#, data types define the type of data a variable can hold.
They can be broadly categorized into two types:
value types and reference types.*/


#region Value Types

/*
1. Memory Allocation:

Stack: Value types are typically stored on the stack, 
which is a region of memory that supports LIFO (Last In, First Out) access. 
Each time a value type is created, memory is allocated on the stack for that variable.

2.Storage:

Value types store their data directly. 
For example, if you declare an int variable, 
the actual integer value is stored in the allocated stack space.

3.Lifetime:

The lifetime of a value type is tied to the scope in which it was defined. 
Once the scope is exited, the memory used for the value type is automatically reclaimed.

Example => For a variable int x = 10;, the stack will have an allocated space that directly holds the value 10.

Stack:
| 10  |  For int x = 10;

 */

#region Integral Types

int integerNumber = -42 * 42;
/*
Size: 32 bits (4 bytes)
Range: -2,147,483,648 to 2,147,483,647
Default Value: 0
Description: A signed integer type, commonly used for general-purpose integer values.
 */

uint uintNumber = 43;
/*
Size: 32 bits (4 bytes)
Range: 0 to 4,294,967,295
Default Value: 0
Description: An unsigned integer type, allowing for larger positive values compared to int.
 */

long longNumber = -123456789L * 123456789L;
/*
Size: 64 bits (8 bytes)
Minimum Value: -9,223,372,036,854,775,808
Maximum Value: 9,223,372,036,854,775,807 (2^63 - 1)
Default Value: 0
Description: long is a signed 64-bit integer. It is used when a larger range of integer values is needed, 
particularly for calculations involving large numbers.
 */

ulong ulongNumber = 123456789L;
/*
Size: 64 bits (8 bytes)
Minimum Value: 0
Maximum Value: 18,446,744,073,709,551,615 (2^64 - 1)
Default Value: 0
Description: ulong is an unsigned 64-bit integer, providing a very large range for non-negative values.
 */

short shortNumber = -2 * 320;
/*
Size: 16 bits (2 bytes)
Minimum Value: -32,768
Maximum Value: 32,767 (2^15 - 1)
Default Value: 0
Description: short is a signed 16-bit integer. 
It can be used when you need a smaller range than int but still require negative values.
 */

ushort ushortNumber = 32000;
/*
Size: 16 bits (2 bytes)
Minimum Value: 0
Maximum Value: 65,535 (2^16 - 1)
Default Value: 0
Description: ushort is an unsigned 16-bit integer. 
It allows for a greater range of positive values than short while not permitting negative values.
 */

byte byteNumber = 255;
/*
Size: 8 bits (1 byte)
Minimum Value: 0
Maximum Value: 255 (2^8 - 1)
Default Value: 0
Description: byte is an unsigned 8-bit integer, 
commonly used for representing small positive numbers.
 */

sbyte sbyteNumber = -100;
/*
Size: 8 bits (1 byte)
Minimum Value: -128
Maximum Value: 127 (2^7 - 1)
Default Value: 0
Description: sbyte is a signed 8-bit integer, 
allowing for both negative and positive values.
 */

#endregion

#region Floating Point Types

float floatNumber = 3.14f;
/*
Size: 32 bits (4 bytes)
Minimum Value: Approximately -3.40282347E+38
Maximum Value: Approximately 3.40282347E+38
Default Value: 0.0f
Description: float is a single-precision 32-bit floating point, 
used for approximate numeric values with fractional parts.
 */

double doubleNumber = 3.14159;
/*
Size: 64 bits (8 bytes)
Minimum Value: Approximately -1.7976931348623157E+308
Maximum Value: Approximately 1.7976931348623157E+308
Default Value: 0.0
Description: double is a double-precision 64-bit floating point, 
used for more precise numeric values.
 */

decimal decimalNumber = 19.368M;
/*
Size: 128 bits (16 bytes)
Minimum Value: -79,228,162,514,264,337,593,543,950,335
Maximum Value: 79,228,162,514,264,337,593,543,950,335
Default Value: 0.0M
Description: decimal is a 128-bit precise decimal value, used for financial and monetary calculations.
 */
#endregion

#region Boolean Type

bool hasAccess = true;
bool isDeleted = false;
/*
Size: 1 bit (but usually stored as 1 byte)
Values: true or false
Default Value: false
Description: bool represents a boolean value, used for true/false conditions.
 */

#endregion

#region Character Type

char letter = 'A';
/*
Size: 16 bits (2 bytes)
Minimum Value: '\u0000' (0)
Maximum Value: '\uFFFF' (65,535)
Default Value: '\0'
Description: char represents a single 16-bit Unicode character.
 */

#endregion

#endregion

#region Reference Types

/*
1.Memory Allocation:

Heap: Reference types are stored in the heap, 
which is a larger pool of memory used for dynamic allocation. 
When you create an object, memory for that object is allocated on the heap.

2.Storage:

Reference types store a reference (or pointer) to the actual data rather than the data itself. 
For instance, when you create a string, 
the variable holds a reference to the memory location where the actual string data is stored on the heap.

3.Lifetime:

The lifetime of a reference type is managed by the garbage collector (GC). 
Objects in the heap remain in memory until there are no more references pointing to them, 
at which point the GC can reclaim that memory.

Example => 

For a variable string str = "Hello";, 
the variable str holds a reference to a memory location in the heap where the string "Hello" is stored.

Stack:              Heap:
| 0x1234 |  -->  | "Hello" |
                   |         |
                   |         |

 */

string text = "Hello World!";
/*
Size: Varies
Default Value: null
Description: string represents a sequence of characters and is immutable.
 */

object obj = null;
/*
Size: Varies
Default Value: null
Description: object is the base type for all data types in C#, allowing for any type to be stored.
 */

dynamic dynamic = null;
/*
Size: Varies
Default Value: null
Description: dynamic allows for dynamic typing, where the type is resolved at runtime.
 */

#endregion

/*
This is not a data type per se but allows for implicit typing. 
The actual type is determined at compile time based on the assigned value. 
 */
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