# Long Const Type Arguments

**Const type arguments** (also called *const type args*) are types used to pass constant & static values to generics through type parameters. These values are available at compile-time and can be used in static contexts, such as static constructors, static fields, and static methods. This can provide enhanced type safety, compile-time polymorphism, performance improvements, and more.

&nbsp;

 You can use types in the `ConstTypeArgs.Longs` namespace for passing long values as const type arguments.

 Usage scenarios include:

 * Static configuration,
 * Eliminating unnecessary instance constructors,
 * "Passing" values to type initializers,
 * and more.

 &nbsp;

 The following is a simple Hello World example to demonstrate how this works:
 
 ```csharp
 using ConstTypeArgs.Longs;

public class Foo<TSize>
    where TSize : K_Long
{
  public static readonly int[] FooArray = new int[TSize.Value];

  static Foo()
  {
    Console.WriteLine($"Integer array size is {FooArray.Length}");
  }
}

// Elsewhere
var foo = new Foo<_3>();  // Outputs "Integer array size is 3"
foo     = new Foo<_16>(); // Outputs "Integer array size is 16"
```

&nbsp;

The following shows how a new long const type argument could be defined.

```csharp
public readonly struct _32 : K_Long<_32>
{ public static long Value => 32; }
```

&nbsp;

You can also create new domain-specific long const type arguments like so:

```csharp
public sealed class DefaultInitialCollectionSize : Long<_32>;
```
