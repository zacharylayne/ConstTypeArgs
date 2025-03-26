# Const Type Args Framework

The **Const Type Args** framework provides libraries, samples, and documentation to support working with *const type arguments*.

Const type arguments, or const type args, are used to *"pass"* values to as generic type parameters, accessed from within static contexts such as static constructors, methods, fields, properties, local functions, lambdas (without closure), and more. This lets you customize types in a compile-time–like fashion, effectively mimicking [C++ template specialization](https://en.cppreference.com/w/cpp/language/template_specialization).

> [!NOTE]
> Please be aware that the Const Type Args framework is in active development. New features and improvements are being added, so stay tuned for updates!

#### Table of Contents

* [**Benefits**](https://github.com/zacharylayne/ConstTypeArgs/tree/master#benefits)
* [**Use case scenarios**](https://github.com/zacharylayne/ConstTypeArgs/tree/master#use-case-scenarios)
* [**How to use const type args**](https://github.com/zacharylayne/ConstTypeArgs/tree/master#how-to-use-const-type-args)
  * [**A simple example**](https://github.com/zacharylayne/ConstTypeArgs/tree/master#a-simple-example)
* [**Framework components**](https://github.com/zacharylayne/ConstTypeArgs/tree/master#framework-components)
* [**Terminology**](https://github.com/zacharylayne/ConstTypeArgs/tree/master#terminology)
* [**Naming conventions**](https://github.com/zacharylayne/ConstTypeArgs/tree/master#naming-conventions)
* [**Documentation**](https://github.com/zacharylayne/ConstTypeArgs/tree/master#documentation)

[**Release history**](https://github.com/zacharylayne/ConstTypeArgs/blob/master/CHANGELOG.md)

[**Contributing**](https://github.com/zacharylayne/ConstTypeArgs/blob/master/CONTRIBUTING.md)

[**License**](https://github.com/zacharylayne/ConstTypeArgs/blob/master/LICENSE.txt)

<br>

## Benefits

Const type args provide a number of inherent and derived benefits, including:

* **[Static polymorphism](https://github.com/zacharylayne/ConstTypeArgs/blob/master/Documentation/benefits/static-polymorphism.md) &amp; type specialization** - Const type arguments allow you to provide specialized implementations to generic consumers, enabling polymorphic behavior without incurring virtual dispatch or runtime overhead typical of inheritance-based polymorphism. This technique mimics compile-time specialization (such as [template specialization](https://en.cppreference.com/w/cpp/language/template_specialization) in C++), eliminating method-table lookups and virtual calls. This results in significant performance improvements, especially in performance-critical scenarios, as the compiler can more effectively optimize away unnecessary indirections and method calls.

* **Increased type safety** - Const type args enforce strict constraints, ensuring only valid values are provided to generic consumers. This reduces risks of invalid configurations, type mismatch, and runtime errors through techniques like type initialization validation, highly specific generic constraints, and static analysis.

* **Simplified Configuration** - Eliminate repetitive runtime parameters and unnecessary validation by embedding configuration directly into the type system. This improves readability, reduces boilerplate, and replaces ambiguous *"magic numbers"* with clearly defined types.

* **Reduced test boilerplate** - Test various configurations by swapping const type arguments, reducing mock setups and repetitive test code. This keeps tests concise, readable, and maintainable.

* **Improved reusablitity** - Define const type args once and reuse them across multiple scenarios, significantly minimizing code duplication. Expand existing generic functionality by simply introducing new const type arguments, rather than creating additional classes.

* **Design pattern enhancements** - Patterns like *State machines*, *command*, and *Entity Component Systems (ECS)* gain increased clarity and type safety through predefined, strongly-typed const type args, making code safer and easier to maintain.

<br>

## Use case scenarios

Const type args are versatile and powerful, enabling a wide variety of use cases:

* **Type-Safe Configuration** – Enforce constraints on values such as buffer sizes, timeouts, or thread limits by ensuring only valid const type arguments can be used, preventing runtime misconfigurations.

* **Implementation Selection** – Configure specialized implementations of generic types optimized for different performance profiles, algorithms, and data structures.

* **Domain-Specific Constants** – Embed domain-specific values (e.g., currency symbols, units of measure, tax rates) directly into the type system to guarantee consistency and clarity throughout your codebase.

* **Parameterized Callbacks and Events** – Provide strongly typed, predefined values and delegates for event handlers or callbacks, minimizing runtime errors and unexpected inputs.

* **Units of Measure** – Encode units such as length, time, temperature, velocity, or mass directly into your type definitions, significantly reducing runtime conversion mistakes and improving readability. Take a look at the [**Units of Measure**](https://github.com/zacharylayne/ConstTypeArgs/tree/master/Samples/Samples.UnitsOfMeasure) for a simple units of measure implementation using const type args.

* **State Machines and Regex Patterns** – Represent valid state transitions, events, or regex patterns as const type arguments, ensuring patterns and states are both validated at initialization and easily discoverable.

* **Union-Like Types** – Mimic union type behavior by allowing generic types to accept multiple const type arguments, enhancing flexibility and type safety simultaneously.

* and more!

Check out the available [samples](https://github.com/zacharylayne/ConstTypeArgs/tree/master/Samples) to see const type args in action.

<br>

## How to use const type args

To use const type args is simple:

* Define a concrete implementation (typically a readonly struct) for [`IConstTypeArg<T>`](https://github.com/zacharylayne/ConstTypeArgs/blob/master/Source/ConstTypeArgs.Core/IConstTypeArg.cs) or derived interface (such as [K_Int](https://github.com/zacharylayne/ConstTypeArgs/blob/master/Source/ConstTypeArgs.Ints/Base.cs)) with a `Value` property that returns the value you want to "pass" to generics.

* Create a generic type or method with a generic parameter constrained to `IConstTypeArg<T>` or a derived type that matches the const type argument you defined.

That's it!

<br>

### A simple example

**Defining const type args**

The example below shows two const type arguments that provide the values `32` and `1024`.

```csharp
using ConstTypeArgs;

public readonly struct _32 : IConstTypeArg<int>
{
    public static int Value => 32;
}

public readonly struct _1024 : IConstTypeArg<int>
{
    public static int Value => 1024;
}
```

<br>

**Using const type args**

The code below provides a ***very simple*** example of how const type args can be used to configure a generic type. In this case, they are used to configure a buffer's size but could be used to control resize strategy, limit growth, or other behaviors.

```csharp
public class Buffer<T, TSize>
    where TSize : IConstTypeArg<int>
{
    public T[] Data = new T[TSize.Value];
}

// Instantiating buffers with different "constant" sizes:
var smallBuffer = new Buffer<int, _32>();    // length == 32
var bigBuffer   = new Buffer<int, _1024>();  // length == 1024
```

<br>

## Framework components

The Const Type Args framework is composed of a number of libraries such as:

* [ConstTypeArgs.Core](https://github.com/zacharylayne/ConstTypeArgs/tree/master/Source/ConstTypeArgs.Core) - The core library containing the `IConstTypeArg<T>` interface, [`K<T, TArg>`](https://github.com/zacharylayne/ConstTypeArgs/blob/master/Source/ConstTypeArgs.Core/K.cs) to define const type arguments that wrap other const type arguments, and [__](https://github.com/zacharylayne/ConstTypeArgs/blob/master/Source/ConstTypeArgs.Core/__.cs) that are used to signify the abscense of values. The core library also contains a number of derived interfaces such as [`K_Struct`](https://github.com/zacharylayne/ConstTypeArgs/blob/master/Source/ConstTypeArgs.Core/Core/K_Struct.cs), [`K_Number`](https://github.com/zacharylayne/ConstTypeArgs/blob/master/Source/ConstTypeArgs.Core/Core/K_Number.cs), [`K_Enum`](https://github.com/zacharylayne/ConstTypeArgs/blob/master/Source/ConstTypeArgs.Core/Core/K_Enum.cs), [`K_Array`](https://github.com/zacharylayne/ConstTypeArgs/blob/master/Source/ConstTypeArgs.Core/Core/K_Array.cs) and [`K_Delegate`](https://github.com/zacharylayne/ConstTypeArgs/blob/master/Source/ConstTypeArgs.Core/Core/K_Delegate.cs) that can be used to constrain const type arguments.

* Libraries covering all primitive types such as [ConstTypeArgs.Bool](https://github.com/zacharylayne/ConstTypeArgs/tree/master/Source/ConstTypeArgs.Bools), [ConstTypeArgs.Chars](https://github.com/zacharylayne/ConstTypeArgs/tree/master/Source/ConstTypeArgs.Chars), [ConstTypeArgs.Decimals](https://github.com/zacharylayne/ConstTypeArgs/tree/master/Source/ConstTypeArgs.Decimals), [ConstTypeArgs.Ints](https://github.com/zacharylayne/ConstTypeArgs/tree/master/Source/ConstTypeArgs.Ints), [ConstTypeArgs.Nints](https://github.com/zacharylayne/ConstTypeArgs/tree/master/Source/ConstTypeArgs.Nints), and [ConstTypeArgs.Ulongs](https://github.com/zacharylayne/ConstTypeArgs/tree/master/Source/ConstTypeArgs.Ulongs), as well as [ConstTypeArgs.Strings](https://github.com/zacharylayne/ConstTypeArgs/tree/master/Source/ConstTypeArgs.Strings), [ConstTypeArgs.Types](https://github.com/zacharylayne/ConstTypeArgs/tree/master/Source/ConstTypeArgs.Types), [ConstTypeArgs.Halfs](https://github.com/zacharylayne/ConstTypeArgs/tree/master/Source/ConstTypeArgs.Halfs), [ConstTypeArgs.Int128s](https://github.com/zacharylayne/ConstTypeArgs/tree/master/Source/ConstTypeArgs.Int128s), and [ConstTypeArgs.UInt128s](https://github.com/zacharylayne/ConstTypeArgs/tree/master/Source/ConstTypeArgs.UInt128s).

* [ConstTypeArgs.Ints](https://github.com/zacharylayne/ConstTypeArgs/tree/master/Source/ConstTypeArgs.Ints), containing delegates ([`RefFunc`](https://github.com/zacharylayne/ConstTypeArgs/blob/master/Source/ConstTypeArgs.Delegates/Funcs/RefFunction.cs), [`SpanProcedure`](https://github.com/zacharylayne/ConstTypeArgs/blob/master/Source/ConstTypeArgs.Delegates/Actions/SpanProcedure.cs), and more), interfaces, and basic const type args for logic operations and more.

* [ConstTypeArgs.Delegates.Interlocked](https://github.com/zacharylayne/ConstTypeArgs/tree/master/Source/ConstTypeArgs.Delegates.Interlocked) - Provides const type args that cover the majority of operations in [`System.Threading.Interlocked`](https://learn.microsoft.com/dotnet/api/system.threading.interlocked) such as [`Add`](https://github.com/zacharylayne/ConstTypeArgs/blob/master/Source/ConstTypeArgs.Delegates.Interlocked/Add/Add.cs), [`Exchange`](https://github.com/zacharylayne/ConstTypeArgs/blob/master/Source/ConstTypeArgs.Delegates.Interlocked/Exchange/Exchange.cs), [`CompareExchange`](https://github.com/zacharylayne/ConstTypeArgs/blob/master/Source/ConstTypeArgs.Delegates.Interlocked/CompareExchange/CompareExchange.cs), and more.

* [ConstTypeArgs.Console](https://github.com/zacharylayne/ConstTypeArgs/tree/master/Source/ConstTypeArgs.Console) - Provides const type args covering .NET console-related types, such as for [`ConsoleColor`](https://learn.microsoft.com/dotnet/api/system.consolecolor), [`ConsoleKey`](https://learn.microsoft.com/dotnet/api/system.consolekey), [`ConsoleModifiers`](https://learn.microsoft.com/dotnet/api/system.consolemodifiers), and more.

## Terminology

* **Const type argument** - A type that is used to "pass" values to generics via generic parameters. All const type arguments implement [`IConstTypeArg<T>`](https://github.com/zacharylayne/ConstTypeArgs/blob/master/Source/ConstTypeArgs.Core/IConstTypeArg.cs).

* **Const type parameter** - A generic parameter constrained to a type implementing `IConstTypeArg<T>`.

* **Argument holder** - A const type argument that wraps or composes other const type arguments. Argument holders implement [`K<T, TArg>`](https://github.com/zacharylayne/ConstTypeArgs/blob/master/Source/ConstTypeArgs.Core/K.cs).

For more definitions, see the [Glossary](https://github.com/zacharylayne/ConstTypeArgs/blob/master/Documentation/glossary.md).

<br>

## Naming conventions

| Convention          | Description                                                                                                                                                |
|---------------------|------------------------------------------------------------------------------------------------------------------------------------------------------------|
| **`K_` Prefix**     | Used for **interfaces** deriving from `IConstTypeArg<T>`, indicating they represent a “constant” in mathematical form.                                     |
| **`_` Prefix**      | Used for **concrete types** (e.g., `_32`, `_A`, `_Blue`) that implement `IConstTypeArg<T>`. This groups similar constants and clarifies each value’s role. |
| **`__`** Types      | These are **discards** (e.g., `__`) that may implement multiple const type arg interfaces, effectively providing union-like behavior with default/`null` values.        |


<br>

## Documentation

Find more information under [Documentation](https://github.com/zacharylayne/ConstTypeArgs/tree/master/Documentation), including:

- [**Benefits**](https://github.com/zacharylayne/ConstTypeArgs/blob/master/Documentation/benefits/benefits-overview.md)
- [**Use Cases**](https://github.com/zacharylayne/ConstTypeArgs/blob/master/Documentation/use-cases/use-cases-overview.md)
- [**Glossary**](https://github.com/zacharylayne/ConstTypeArgs/blob/master/Documentation/glossary.md)

<br>

## Samples

[**Buffer**](https://github.com/zacharylayne/ConstTypeArgs/tree/master/Samples/Samples.Buffer) - Uses const type args for static polymorphism, creating compiled types representing buffers of different sizes &amp; resize functionality.

[**Units of Measure**](https://github.com/zacharylayne/ConstTypeArgs/tree/master/Samples/Samples.UnitsOfMeasure) - A simple implementation of units of measure using const type args.

<br>

## Questions or comments?

Feel free to submit an issue or add to the discussion! Feedback, suggestions, & collaboration are more than welcome if you're interested in contributing to the project. Thanks for checking it out!
