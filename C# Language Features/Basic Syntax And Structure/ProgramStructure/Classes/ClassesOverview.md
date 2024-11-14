# Classes in C#

Classes are essential components in **object-oriented programming** languages. They serve as blueprints for creating objects, which are specific data structures that contain both data (referred to as attributes or properties) and code (known as functions or methods) that interact with that data. Objects are instances of these classes, and each class establishes the shared structure and behavior of its objects. Below are some important points about classes in C#.

**1** - Classes are **reference types** that hold the object created dynamically in a heap.

**2** - **System.Object** is the base type for all the classes.

**3** - If we do not declare the access modifier for a class, then by default it is **internal**.

**4** - If we do not declare the access modifier for the methods and variables in a class, then by default it is **private**.

**5** - Directly inside the namespaces, declarations of private classes are **not allowed**

## Types of Classes in C#

### 1. Abstract Class

An abstract class is a class that provides the definition for its subclasses. An abstract class can **not be instantiated**. An abstract class is used to provide a base for child classes to extend and implement abstract methods and override or use the implemented methods in the abstract class.

**1** - An object can not be created from the abstract class.

**2** - We use abstract keyword to declare an abstract class.

**3** - To use the abstract class, it must be inherited by a subclass.

**4** - An Abstract class contains both abstract and non-abstract methods.

**5** - The methods inside the abstract class can either have an or no implementation.

**6** - We can inherit two abstract classes; in this case, implementation of the base class method is optional.

**7** - An Abstract class has only one subclass.

**8** - Methods inside the abstract class cannot be private.

**9** - If there is at least one method abstract in a class, then the class must be abstract.

### 2. Partial Class
A partial class is used to divide properties, methods, and events into multiple partial classes that are joined in a single class at compile time. A partial class is useful when the class definition is too large or you are working on a complex model or feature and you want to divide the responsibility of implementation into more than one developer. 

**1** - All the parts of the partial class must be prefixed with the partial keyword.

**2** - If you sealed a specific part of a partial class, the entire class is sealed, the same as for an abstract class.

**3** - Inheritance cannot be applied to partial classes.

**4** - The classes written in two class files are combined at run time.

### 3. Sealed Class
A sealed class is a class that can not be inherited. In C#, sealed classes are used to prevent inheritance from other classes. This helps to prevent security issues. For example, the methods in a sealed class cannot be manipulated from other classes.

**1** - A Sealed class is created using the sealed keyword.

**2** - Access modifiers are not applied to a sealed class.

**3** - To access the sealed members, we must create an object of the class. 

### 4. Static Class
Static classes are the classes that can not be instantiated. You can directly call static class members using their names.

**1** - It was created using the static keyword.

**2** - Only static members are allowed; in other words, everything inside the class must be static.

**3** - We cannot create an object of the static class.

**4** - Static classes are sealed and therefore cannot be inherited. They are also not available for use in the same way as a regular class.

**5** - It allows only a static constructor to be declared.

**6** - The static class methods can be called using the class name without creating the instance.

**7** - Static classes consume fewer resources.

### Summary Table

| Class Type | Purpose                                                                                           | Can Be Inherited? | Can Be Instantiated? |
|:----------:|:-------------------------------------------------------------------------------------------------:|:-----------------:|:--------------------:|
| Abstract   | Provides a base class with some unimplemented methods; used for defining a common structure.      | Yes               | No                   |
| Regular    | Used for creating objects with specific properties and behaviors.                                 | Yes               | Yes                  |
| Sealed     | Prevents other classes from inheriting it; used for finalized implementations.                    | No                | Yes                  |
| Static     | Contains only static members; used for utility or helper methods, not for instance-specific data. | No                | No                   |
| Partial    | Allows a single class to be split across multiple files for better organization.                  | Yes               | Yes                  |
