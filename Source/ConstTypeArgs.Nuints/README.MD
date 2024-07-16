# Nuint Const Type Arguments

**Const type arguments** (also called *const type args*) are types used to pass constant & static values to generics through type parameters. These values are available at compile-time and can be used in static contexts, such as static constructors, static fields, and static methods. This can provide enhanced type safety, compile-time polymorphism, performance improvements, and more.

&nbsp;

 You can use types in the `ConstTypeArgs.Bools` namespace for passing boolean values as const type arguments.

 Usage scenarios include:

 * Static configuration,
 * Eliminating unnecessary instance constructors,
 * "Passing" values to type initializers,
 * and more.

 &nbsp;

 The following is a simple Hello World example to demonstrate how this works:

 ```csharp
 using ConstTypeArgs.Bools;

public class Foo<TToConsole>
    where TToConsole: K_Bool
{
    static Foo()
    {        
        if (TToConsole.Value)
            Console.WriteLine("Hello, world!");
    }
}

// Elsewhere
var foo = new Foo<True>();  // Console outputs: Hello, world!
foo     = new Foo<False>(); // No output.
```
