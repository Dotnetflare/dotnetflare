namespace ProgramStructure.Methods;

public class BaseClass
{
    // Lambda Expressions(Anonymous Methods)
    public Func<int, int> square = x => x * x;

    // Virtual Method
    public virtual void VirtualMethod()
    {
        #region LocalFunction

        void LocalFunction()
        {
            Console.WriteLine("\nLocalFunction in VirtualMethod called");
        }

        LocalFunction();

        #endregion

        Console.WriteLine("\nVirtualMethod in BaseClass");
    }

    // Static Method
    public static void StaticMethod()
    {
        Console.WriteLine("\nCalled StaticMethod from BaseClass");
    }

    #region Method Overloading

    public int Print(int number)
    {
        return number -= 1;
    }
    public void Print(string message)
    {
        Console.WriteLine($"\n{message}");
    }

    #endregion

    public int MethodParameterExample(int x, ref int y, out int z)
    {
        return z = x + y;
    }

    // Async Method
    public async Task FetchDataAsync()
    {
        await Task.Delay(1000);
    }

    // Generic Method
    public void GenericMethod<T>(T entity)
    {
        Console.WriteLine($"\n{entity}");
    }
}

public abstract class Shape
{
    // Abstract Method
    public abstract void Draw();
}

public class Circle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("\nDrawing a circle");
    }
}

public static class Extensions
{
    // Extension Method
    public static int WordCount(this string str)
    {
        return string.IsNullOrWhiteSpace(str)
        ? 0
        : str.Split((char[])null, StringSplitOptions.RemoveEmptyEntries).Length;
    }
}