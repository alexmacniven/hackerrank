# Generics

Generics allow strongly typed languages to generalize what's been held in a datastructure.

As an exmaple; suppose we have a utility class that will print all elemnts of an array.
Using basic design, we would have to implement logic for each individual array type.
That is, for example; `printIntArray`, `printStrArray` etc.
But the power of Generics allow **one** implementation that will print *any* type of array.

```csharp
static void PrintArray<T>(T[] t)
{
    foreach(T element in t)
    {
        Console.WriteLine(element);
    }
}
```

In the example above we specify the type of the array `t` at runtime.
Here's an exmaple of how the above is invoked;

```csharp
PrintArray<int32>(anIntArray);
PrintArray<string>(aStringArray);
```

## Constraints
Sometimes we need to add constraints to the type to ensure functionality is accessible.
Let's look into this a little bit, suppose we have a `Person` class and a `Worker` class extending it;

```csharp
public class Person
{
    public Person(String aName)
    {
        name = aName;
    }
}

public class Worker: Person { }
```

And we design a generic method to write the name attribute of *any* class extending `Person`.
That is, the method should be able to take both `Person` type and `Worker` type as an argument.

```csharp
static void WriteName<T>(T t) where T : Person
{
    Console.WriteLine(t.name);
}
``` 
Above we have specified `T` must extend the `Person` class. Given the rules of inheritence, any class extending `Person` will have a `name` attribute.

## Classes
Generics also extend to classes.
They become very useful when implementing structures such as linked lists, queues, stacks etc.

```csharp
public class GenericList<T>
{
   private List<T> data;

    public GenericList()
    {
        data = new List<T>();
    }

    public void Add(T t)
    {
        data.Add(t);
    }

    public T Pop()
    {
        try
        {
            return data[0];
        }
        catch (IndexOutOfRangeException)
        {
            throw;
        }
    }
}
```

The test class demonstrates the above can be used to store *any* type of data;

```csharp
class TestGenerics
{
    static void Main(string[] args)
    {
        GenericList<int> IntList = new GenericList<int>();
        IntList.Add(23);
        Console.WriteLine(IntList.Pop());

        GenericList<string> StrList = new GenericList<string>();
        StrList.Add("Hello");
        StrList.Add("World");
        Console.WriteLine(StrList.Pop());
        Console.ReadLine();
    }
}
```