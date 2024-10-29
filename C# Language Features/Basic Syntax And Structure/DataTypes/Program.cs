/*In C#, data types define the type of data a variable can hold.
They can be broadly categorized into two types:
value types and reference types.*/

//There are different ways to define a variable

#region Integer types

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
 */

ulong ulongNumber = 123456789L;
/*
Size: 64 bits (8 bytes)
Minimum Value: 0
Maximum Value: 18,446,744,073,709,551,615 (2^64 - 1)
Default Value: 0
 */

short shortNumber = 32000;


#endregion


// Floating-point types
float floatNumber = 3.14f;
double doubleNumber = 3.14159;

// Boolean type
bool isCSharpFun = true;

// Character type
char letter = 'A';


Console.ReadKey();