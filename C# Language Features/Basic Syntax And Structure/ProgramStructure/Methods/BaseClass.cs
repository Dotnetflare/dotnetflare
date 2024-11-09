namespace ProgramStructure.Methods;

public class BaseClass
{
    // Lambda Expressions(Anonymous Methods)
    Func<int, int> square = x => x * x;

    // Virtual Method
    public virtual void VirtualMethod()
    {
        #region LocalFunction

        void LocalFunction()
        {
            Console.WriteLine("LocalFunction in BaseClass called");
        }

        LocalFunction();

        #endregion

        Console.WriteLine("VirtualMethod in BaseClass");
    }

    // Static Method
    public static void StaticMethod()
    {
        Console.WriteLine("Called StaticMethod from BaseClass");
    }

    #region Method Overloading

    public int Print(int number)
    {
        return number -= 1;
    }
    public void Print(string message)
    {
        Console.WriteLine(message);
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
    public void GenericMethod<T>(T entity) where T : class
    {

    }
}

public abstract class Shape
{
    // Abstract Method
    public abstract void Draw();
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