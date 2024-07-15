# Type Const Type Arguments

**Const type arguments** (also called *const type args*) are types used to pass constant & static values to generics through type parameters. These values are available at compile-time and can be used in static contexts, such as static constructors, static fields, and static methods. This can provide enhanced type safety, compile-time polymorphism, performance improvements, and more.

&nbsp;

 You can use types in the `ConstTypeArgs.Types` namespace for passing Type values as const type arguments.

 Usage scenarios include:

 * Static configuration,
 * Eliminating unnecessary instance constructors,
 * "Passing" values to type initializers,
 * and more.

 &nbsp;

Here's a simple demonstration:

 ```csharp
 using ConstTypeArgs.Types;

public class Foo<TType>
{    
  static Foo()
  {
    if (TType.Value == typeof(string)
     || TType.Value == typeof(char)
     || TType.Value == typeof(char[])
     || TType.Value == typeof(ReadOnlyMemory<char>)
     || TType.Value == typeof(ReadOnlySpan<char>))\
    {
      Console.WriteLine($"{TType.Value} values usually represent text!");
    }
		
    if (TType.Value == typeof(byte)
     || TType.Value == typeof(sbyte)
     || TType.Value == typeof(short)
     || TType.Value == typeof(ushort)
     || TType.Value == typeof(int)
     || TType.Value == typeof(uint)
     || TType.Value == typeof(long)
     || TType.Value == typeof(ulong)
     || TType.Value == typeof(nint)
     || TType.Value == typeof(nuint))
    {
      Console.WriteLine($"{TType.Value} values usually represent numbers!");
    }
  }
}

// Elsewhere, assuming the value of StringType is typeof(string)
var foo = new Foo<StringType>();  // Outputs: StringType values usually represent text!

// Assuming that the value of IntType is typeof(int)
foo     = new Foo<IntType>();     // Outputs: TType values usually represent numbers!
```

Here's how you could create a new Type const type argument:

```csharp
public readonly struct StringType : K_Type<StringType>
{ public static Type Value => typeof(string); }
```
