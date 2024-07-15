# Bool Const Type Arguments

**Const type arguments** (also called *const type args*) are types used to pass constant & static values to generics through type parameters. These values are available at compile-time and can be used in static contexts, such as static constructors, static fields, and static methods. This can provide enhanced type safety, compile-time polymorphism, performance improvements, and more.

&nbsp;

 You can use types in the `ConstTypeArgs.Strings` namespace for passing string values as const type arguments.

 Usage scenarios include:

 * Static configuration,
 * Eliminating unnecessary instance constructors,
 * "Passing" values to type initializers,
 * and more.

 &nbsp;

Here's a simple demonstration:

 ```csharp
 using ConstTypeArgs.Strings;

public class Foo<THello, TWorld>
    where THello : K_String
	where TWorld : K_String
{
    static Foo()
    {
        Console.WriteLine($"{THello.Value} {TWorld.Value}!");
    }
}

// Elsewhere, assuming the value of _hola is "hola"
// and _world is "world"
var foo = new Foo<_hola, _world>();  // Outputs "hola world!"
```

Here's how you could create a new string const type argument:

```csharp
public readonly struct _hola : K_String<_hola>
{ public static string Value => "hola"; }
```