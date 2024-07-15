# Uint Const Type Arguments

**Const type arguments** (also called *const type args*) are types used to pass constant & static values to generics through type parameters. These values are available at compile-time and can be used in static contexts, such as static constructors, static fields, and static methods. This can provide enhanced type safety, compile-time polymorphism, performance improvements, and more.

&nbsp;

 You can use types in the `ConstTypeArgs.Uints` namespace for passing uint values as const type arguments.

 Usage scenarios include:

 * Static configuration,
 * Eliminating unnecessary instance constructors,
 * "Passing" values to type initializers,
 * and more.

 &nbsp;

 The following is a simple example to demonstrate how this works:

 ```csharp
using ConstTypeArgs.Uints;

public class Foo<TVal>
  where TVal : K_Uint
{
  static Foo()
  {        
    if (TVal.Value > 0)
      Console.WriteLine("Value is positive! ");
    if (TVal.Value > (uint)int.MaxValue)
      Console.Write($"{TVal.Value} > integer max value!");
  }
}

// Elsewhere, assuming that _2147483648 is equal to 2,147,483,648
var foo = new Foo<_2147483648>();
// Output: "Value is positive! 2147483648 > integer max value!");
```

Here's how you could define a uint const type argument:

```csharp
public readonly struct Pos_2 : K_Uint<Pos_2>
{ public static uint Value => 2; }
```
