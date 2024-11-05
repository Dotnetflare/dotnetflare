# C# Operators Overview

## Introduction

In C#, **operators** are special symbols that denote operations to be performed on operands. They are fundamental to programming, enabling a wide range of functionalities, from arithmetic calculations to logical comparisons. C# operators can be categorized based on their functionality and the number of operands they require, which is crucial for effective coding and expression evaluation.

## Categories of Operators

### 1. Arithmetic Operators

**Characteristics**
- Used for basic mathematical operations.
- Operate on numeric operands.

**Common Arithmetic Operators**
- **Addition (+)**: Perform the addition of operands.
- **Subtraction (-)**: Performs subtraction of operands.
- **Multiplication (*)**: Performs multiplication on operands.
- **Division (/)**: Performs division of operands.
- **Modulus (%)**: Returns reminder after the division of integer.

### 2. Relational Operators

**Characteristics**
- Used to compare two values.
- Return a boolean result (true or false).

**Common Relational Operators**
- **Equal to (==)**: Validates the equality of two operands.
- **Not equal to (!=)**: Validates not an equal relationship between the two operands.
- **Greater than (>)**: Validates greater than the relation between operands.
- **Less than (<)**: Validates less than the relation between operands.
- **Greater than or equal to (>=)**: Validates greater than or equals to the relation between the two operands.
- **Less than or equal to (<=)**: Validates less than or equals to the relations between the two operands.

### 3. Logical Operators

**Characteristics**
- Operate on boolean values.
- Used to combine multiple conditions.

**Common Logical Operators**
- **AND (&&)**: Returns true if both operands are true.
- **OR (||)**: Returns true if at least one operand is true.
- **NOT (!)**: Reverses the logical state of its operand.

### 4. Bitwise Operators

**Characteristics**
- Operate at the bit level.
- Useful for low-level programming and performance optimization.

**Common Bitwise Operators**
- **Bitwise AND (&)**: Takes two numbers as operands and does AND on every bit of two numbers. The result of AND is 1 only if both bits are 1.
- **Bitwise OR (|)**:  Takes two numbers as operands and does OR on every bit of two numbers. The result of OR is 1 any of the two bits is 1.
- **Bitwise XOR (^)**: Takes two numbers as operands and does XOR on every bit of two numbers. The result of XOR is 1 if the two bits are different.
- **Bitwise NOT (~)**: Takes one number as operand and invert each bits that is 1 to 0 and 0 to 1.
- **Left Shift (<<)**: Takes two numbers, left shifts the bits of the first operand, the second operand decides the number of places to shift.
- **Right Shift (>>)**: Takes two numbers, right shifts the bits of the first operand, the second operand decides the number of places to shift.

### 5. Assignment Operators

**Characteristics**
- Used to assign values to variables.

**Common Assignment Operators**
- **Simple Assignment (=)**: It is one of the simplest assignment operators. It assigns the value of one operand to another. i.e. the value of the right side operand to the left side operand.
- **Add and Assign (+=)**: As the name suggests it is a combination of plus “+” and equal to “=”. It is written as “+=” and it adds the operand at the right side to the left operand and stores the final value in the left operand.
- **Subtract and Assign (-=)**: Similar to the add equals, it subtracts the value of the right operand from the left operand and then assigns the value to the left operand.
- **Multiply and Assign (*=)**: It multiplies the value of the right operand with the left operand and then stores the result in the left operand.
- **Divide and Assign (/=)**: It divides the value of the right operand with the left operand and then stores the result in the left operand.
- **Modulus Equals to the Assignment Operator (%=)**: It finds the modulus of the left and right operand and stores the value in the left operand.

### 6. Conditional Operator

**Characteristics**
- Also known as the ternary operator, it evaluates a condition and returns one of two values based on whether the condition is true or false.

**Syntax**
```csharp
condition ? value_if_true : value_if_false;
```

### 7. Unary Operators

**Characteristics**
- Operate on a single operand.

**Common Unary Operators**
- **Increment (++)**: Increases an integer value by one.
- **Decrement (--)**: Decreases an integer value by one.

## Operator Precedence

Operator precedence determines the order in which operators are evaluated in an expression. Higher precedence operators are evaluated before lower precedence ones. For example, in the expression "x = 7 + 3 * 2", multiplication is performed first, resulting in "x = 13".

## Conclusion

C# operators are essential tools that facilitate various operations within programs, enabling developers to perform calculations, make comparisons, manipulate data, and control program flow efficiently. Understanding these operators and their categories is vital for writing effective C# code.
