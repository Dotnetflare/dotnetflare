# C# Operators Overview

## Introduction

In C#, **operators** are symbols used to perform various operations on values. They’re essential in programming, supporting a broad range of tasks, from basic math to complex logic. Operators in C# are classified based on their purpose and the number of values they work with, making them invaluable for writing expressive, efficient code.

## Categories of Operators

### 1. Arithmetic Operators

**Characteristics**
- Handle basic mathematical calculations.
- Work with numeric values.

**Common Arithmetic Operators**
- **Addition (+)**: Adds two values.
- **Subtraction (-)**: Subtracts one value from another.
- **Multiplication (*)**: Multiplies two values.
- **Division (/)**: Divides one value by another.
- **Modulus (%)**: Returns the remainder after dividing one integer by another.

### 2. Relational Operators

**Characteristics**
- Compare two values.
- Return `true` or `false` based on the comparison.

**Common Relational Operators**
- **Equal to (==)**: Checks if two values are the same.
- **Not equal to (!=)**: Checks if two values are different.
- **Greater than (>)**: Checks if the first value is greater.
- **Less than (<)**: Checks if the first value is smaller.
- **Greater than or equal to (>=)**: Checks if the first value is greater or equal.
- **Less than or equal to (<=)**: Checks if the first value is smaller or equal.

### 3. Logical Operators

**Characteristics**
- Operate on boolean values.
- Used for combining conditions.

**Common Logical Operators**
- **AND (&&)**: Returns `true` if both conditions are true.
- **OR (||)**: Returns `true` if at least one condition is true.
- **NOT (!)**: Reverses the truth value of its operand.

### 4. Bitwise Operators

**Characteristics**
- Perform operations at the binary level.
- Useful in low-level programming tasks.

**Common Bitwise Operators**
- **Bitwise AND (&)**: Compares each bit of two numbers; the result bit is 1 only if both bits are 1.
- **Bitwise OR (|)**: Compares each bit; the result bit is 1 if either bit is 1.
- **Bitwise XOR (^)**: Compares each bit; the result is 1 if the bits differ.
- **Bitwise NOT (~)**: Inverts each bit (1 becomes 0 and vice versa).
- **Left Shift (<<)**: Shifts bits of the first operand left by the number of places specified by the second operand.
- **Right Shift (>>)**: Shifts bits of the first operand right by the number of places specified by the second operand. For signed integers, this is an arithmetic shift (fills with the sign bit), and for unsigned integers, it’s a logical shift (fills with 0s).

### 5. Assignment Operators

**Characteristics**
- Used to assign values to variables.

**Common Assignment Operators**
- **Assignment (=)**: Assigns the right-side value to the left-side variable.
- **Add and Assign (+=)**: Adds the right value to the left and updates the left.
- **Subtract and Assign (-=)**: Subtracts the right value from the left and updates the left.
- **Multiply and Assign (*=)**: Multiplies the left value by the right and updates the left.
- **Divide and Assign (/=)**: Divides the left by the right and updates the left.
- **Modulus Assignment (%=)**: Assigns the remainder of the left divided by the right to the left operand.

### 6. Conditional Operator

**Characteristics**
- Also known as the ternary operator, it evaluates a condition and selects one of two values based on the result.

**Syntax**
```csharp
condition ? value_if_true : value_if_false;
```

### 7. Unary Operators

**Characteristics**
- Operate on a single value.

**Common Unary Operators**
- **Increment (++)**: Increases an integer by one.
- **Decrement (--)**: Decreases an integer by one.

## Operator Precedence

Operator precedence determines the order of operations in an expression. Operators with higher precedence are evaluated first. For example, in `x = 7 + 3 * 2`, multiplication takes priority, resulting in `x = 13`.

## Conclusion

Operators in C# are fundamental building blocks that enable developers to perform a variety of operations, from basic math to complex logical checks. Mastering these categories helps in writing efficient, readable code.