# Bool Const Type Arguments

**Const type arguments** (also called *const type args*) are types used to pass constant & static values to generics through type parameters. These values are available at compile-time and can be used in static contexts, such as static constructors, static fields, and static methods. This can provide enhanced type safety, compile-time polymorphism, performance improvements, and more.

&nbsp;

 You can use types in the `ConstTypeArgs.Ints` namespace for passing `int` values as const type arguments.

 Usage scenarios include:

 * Static configuration,
 * Eliminating unnecessary instance constructors,
 * "Passing" values to type initializers,
 * and more.

 &nbsp;
 The following is a simple example to demonstrate how this works:

 ```csharp
 using ConstTypeArgs.Ints;

public class Foo<TSize>
    where TSize : K_Int
{
    public static readonly int[] FooArray = new int[TSize.Value];

    static Foo()
    {
        Console.WriteLine($"Array size is {FooArray.Length}");
    }
}

// Elsewhere
var foo = new Foo<_3>();  // Outputs "Array size is 3"
foo     = new Foo<_16>(); // Outputs "Array size is 16"
```

&nbsp;

The following shows how a new `int` const type argument could be defined.

```csharp
public readonly struct _77 : K_Int<_77>
{ public static int Value => 77; }
```

&nbsp;

You can also create new domain-specific `int` const type arguments like so:

```csharp
public sealed class DefaultInitialCollectionSize : Int<_32>;
```
