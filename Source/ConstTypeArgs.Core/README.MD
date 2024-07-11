# Const Type Arguments

**Const type arguments** (also called *const type args*) are types used to pass constant & static values to generics through type parameters. These values are available at compile-time and can be used in static contexts, such as static constructors, static fields, and static methods. This can provide enhanced type safety, compile-time polymorphism, performance improvements, and more.

Defining a const type argument is as simple as:

```csharp
using ConstTypeArgs;

public readonly struct Pos_32 : IConstTypeArg<int>
{ public static int Value => 32; }
```

And to use it:

```csharp
public class Array<T, TSize>
    where TSize : IConstTypeArg<int>
{
    public T[] Data = new T[TSize.Value];
}

var array = new Array<int, Pos_32>();
// array.Data.Length == 32
```
