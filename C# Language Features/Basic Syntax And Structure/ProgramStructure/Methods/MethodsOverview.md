# Methods in C#

In C#, methods are essential building blocks that define the behavior of objects and classes. Here’s a detailed overview, covering method types, structures, features and etc...

## 1. Basic Structure of a Method

A method typically consists of:

**Access Modifier**: Specifies the visibility (e.g., public, private, protected, internal).

**Return Type**: Specifies the data type returned by the method (e.g., void for no return, int, string).

**Method Name**: A unique identifier for the method.

**Parameters**: Optional; allow data to be passed into the method.

**Body**: The code that executes when the method is called.

## 2. Access Modifiers

**Public**: Accessible from any class or project.

**Private**: Only accessible within the defining class.

**Protected**: Accessible within the defining class and derived classes.

**Internal**: Accessible only within the same assembly or project.

**Protected Internal**: Accessible in the same assembly and derived classes.

## 3. Types of Methods

### a) Instance Methods

**1**. Associated with an instance of a class.

**2**. Can access both instance and static members.

**3**. Called using an object of the class.

### b) Static Methods

**1**. Belong to the class, not any particular object.

**2**. Can only directly access other static members. (Because it's stored somewhere in the heap memory called **High Frequency Heap**)

**3**. Called on the class itself.

### c) Abstract Methods

**1**. Declared in abstract classes.

**2**. Don't contain an implementation in the base (abstract) class.

**3**. Must be implemented by derived classes.

### d) Virtual Methods

**1**. Defined in a base class, allowing derived classes to override it.

**2**. Can have a base implementation.

### e) Override Methods

**1**. Used in derived classes to modify behavior of a base class's virtual or abstract method.

### f) Sealed Methods

**1**. Prevents further overriding of an override method in derived classes.

### g) Extension Methods

**1**. Static methods in a static class.

**2**. Allow adding functionality to existing types without modifying them.

**3**. The first parameter is prefixed with **this**, denoting the extended type.

### h) Generic Methods

**1**. Operate on multiple data types.

**2**. Declared with type parameters (e.g., **<T>**).

### i) Async Methods

**1**. Methods defined with the **async** keyword and **Task** or **Task<T>** return types.

**2**. Allow asynchronous execution, often using **await**.

### j) Local Functions

**1**. Methods defined within other methods, scoped locally.

**2**. Useful for helper logic within a single method.

### k) Lambda Expressions (Anonymous Methods)

**1**. Inline, anonymous methods often used with **delegates**, **events**, or **LINQ**.

**2**. Syntax: **parameter => expression**.

## 4. Method Overloading

**1**. Allows defining multiple methods with the same name but different parameters.

**2**. Enhances flexibility by allowing a method to handle various input types.

## 5. Method Parameters

**Value Parameters**: Default; pass values directly.

**Reference Parameters** **(ref)**: Passes reference, allowing method to modify the original variable.

**Out Parameters (out)**: Similar to ref, but only for output values.

**Optional Parameters**: Allows setting default values, making parameters optional.

**Named Parameters**: Specify parameter names when calling a method, regardless of order.

## 6. Return Types and Return Statements

**1**. Methods can return any data type, **void**, or **generic types**.

**2**. Return statements terminate a method’s execution and return a value if specified.

## Best Practices for Methods

**Single Responsibility**: Each method should serve one specific purpose.

**Descriptive Naming**: Use meaningful names that indicate the method's action.

**Parameter Count**: Limit parameters to reduce complexity.

**Avoid Side Effects**: Minimize unexpected changes to class state.

**Method Size**: Keep methods concise to enhance readability.