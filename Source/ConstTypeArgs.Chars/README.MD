# Bool Const Type Arguments

**Const type arguments** (also called *const type args*) are types used to pass constant & static values to generics through type parameters. These values are available at compile-time and can be used in static contexts, such as static constructors, static fields, and static methods. This can provide enhanced type safety, compile-time polymorphism, performance improvements, and more.

&nbsp;

 You can use types in the `ConstTypeArgs.Chars` namespace for passing ASCII character values as const type arguments.

 &nbsp;

 The following is a simple Hello World example to demonstrate how this works:

 ```csharp
 using ConstTypeArgs.Chars;

public static class Foo<TChar>
    where TChar: K_Char
{
    private static readonly char Separator = TChar.Value;

    public static void Output(string[] items)
    {
        foreach (var item in items)
            Console.Write($"{item}{Separator}");
    }
}

// Elsewhere
var helloWorld = new string[] { "Hello", "World!" };

Foo<Comma>.Output(helloWorld);       // Output: Hello,World!
Foo<Slash>.Output(helloWorld);       // Output: Hello/World!
Foo<Semicolon>.Output(helloWorld);   // Output: Hello;World!
Foo<VerticalBar>.Output(helloWorld); // Output: Hello|World!
```

&nbsp;

You can create new domain-specific char const type arguments like so:

```csharp
public sealed class ListSeparator  : Char<Comma>;
public sealed class TableSeparator : Char<VerticalBar>;
```
