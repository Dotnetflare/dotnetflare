# C# Data Types Conceptual Overview

## Introduction

In C#, **data types** define the kind of data a variable can hold. 
Understanding these types is essential for effective programming, 
as they influence **memory management**, **performance**, and **functionality**. 
Data types in C# can be broadly categorized into two main groups: **Value Types** and **Reference Types**.

## Value Types

### Characteristics

- **Memory Allocation**: Stored on the **stack**, supporting LIFO (Last In, First Out) access.
- **Storage**: Holds the actual data directly in allocated memory.
- **Lifetime**: Tied to the scope where they are defined; automatically reclaimed when the scope is exited.

### Integral Types

- **int**
  - **Size**: 32 bits (4 bytes)
  - **Range**: -2,147,483,648 to 2,147,483,647
  - **Example**:
    ```csharp
    int integerNumber = -42 * 42;
    ```

- **uint**
  - **Size**: 32 bits (4 bytes)
  - **Range**: 0 to 4,294,967,295
  - **Example**:
    ```csharp
    uint uintNumber = 43;
    ```

- **long**
  - **Size**: 64 bits (8 bytes)
  - **Range**: -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
  - **Example**:
    ```csharp
    long longNumber = -123456789L * 123456789L;
    ```

- **ulong**
  - **Size**: 64 bits (8 bytes)
  - **Range**: 0 to 18,446,744,073,709,551,615
  - **Example**:
    ```csharp
    ulong ulongNumber = 123456789L;
    ```

- **short**
  - **Size**: 16 bits (2 bytes)
  - **Range**: -32,768 to 32,767
  - **Example**:
    ```csharp
    short shortNumber = -2 * 320;
    ```

- **ushort**
  - **Size**: 16 bits (2 bytes)
  - **Range**: 0 to 65,535
  - **Example**:
    ```csharp
    ushort ushortNumber = 32000;
    ```

- **byte**
  - **Size**: 8 bits (1 byte)
  - **Range**: 0 to 255
  - **Example**:
    ```csharp
    byte byteNumber = 255;
    ```

- **sbyte**
  - **Size**: 8 bits (1 byte)
  - **Range**: -128 to 127
  - **Example**:
    ```csharp
    sbyte sbyteNumber = -100;
    ```

### Floating Point Types

- **float**
  - **Size**: 32 bits (4 bytes)
  - **Range**: Approximately -3.40282347E+38 to 3.40282347E+38
  - **Example**:
    ```csharp
    float floatNumber = 3.14f;
    ```

- **double**
  - **Size**: 64 bits (8 bytes)
  - **Range**: Approximately -1.7976931348623157E+308 to 1.7976931348623157E+308
  - **Example**:
    ```csharp
    double doubleNumber = 3.14159;
    ```

- **decimal**
  - **Size**: 128 bits (16 bytes)
  - **Range**: -79,228,162,514,264,337,593,543,950,335 to 79,228,162,514,264,337,593,543,950,335
  - **Example**:
    ```csharp
    decimal decimalNumber = 19.368M;
    ```

### Boolean Type

- **bool**
  - **Size**: 1 bit (usually stored as 1 byte)
  - **Values**: true or false
  - **Example**:
    ```csharp
    bool hasAccess = true;
    ```

### Character Type

- **char**
  - **Size**: 16 bits (2 bytes)
  - **Range**: '\u0000' (0) to '\uFFFF' (65,535)
  - **Example**:
    ```csharp
    char letter = 'A';
    ```

## Reference Types

### Characteristics

- **Memory Allocation**: Stored on the **heap**, suitable for dynamic memory allocation.
- **Storage**: Holds a reference (pointer) to the actual data.
- **Lifetime**: Managed by the garbage collector; objects remain in memory until there are no references to them.

### Common Reference Types

- **string**
  - **Example**:
    ```csharp
    string text = "Hello World!";
    ```

- **object**
  - **Example**:
    ```csharp
    object obj = null;
    ```

- **dynamic**
  - **Example**:
    ```csharp
    dynamic dynamicValue = null;
    ```