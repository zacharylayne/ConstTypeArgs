# Byte Const Type Arguments

**Const type arguments** (also called *const type args*) are types used to pass constant & static values to generics through type parameters. These values are available at compile-time and can be used in static contexts, such as static constructors, static fields, and static methods. This can provide enhanced type safety, compile-time polymorphism, performance improvements, and more.

&nbsp;

 You can use types in the `ConstTypeArgs.Bytes` namespace for passing byte values as const type arguments.

 Usage scenarios include:

 * Static configuration,
 * Eliminating unnecessary instance constructors,
 * "Passing" values to type initializers,
 * and more.

 &nbsp;

 The following is a simple example to demonstrate how this works:

 ```csharp
 using ConstTypeArgs.Bytes;

public class Foo<TSize>
    where TSize : K_Byte
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

The following shows how a new byte const type argument could be defined.

```csharp
public readonly struct _77 : K_Byte<_77>
{ public static byte Value => 77; }
```

&nbsp;

You can also create new domain-specific byte const type arguments like so:

```csharp
public sealed class DefaultInitialCollectionSize : Byte<_32>;
```
