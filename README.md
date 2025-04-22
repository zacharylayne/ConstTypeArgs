# ConstTypeArgs Framework

The **ConstTypeArgs** framework contains libraries, samples, and documentation to support working with *const type arguments*.

Const type arguments, or const type args, are data types meant to  *"pass"* values through type parameters to generic types &amp; methods. These values can be accessed from within static contexts, such as type initializers (static constructors), methods, fields, properties, local functions, and lambdas without causing closures. This gives a powerful way to customize types in a compile-time-like manner, mimicking the behavior of [C++ template specialization](https://en.cppreference.com/w/cpp/language/template_specialization), and offers unique benefits & flexibility across a wide variety of use cases.

Provided with the framework are:

 * Const type args covering `bool`, `byte`, `char`, `decimal`, `double`, `float`, `Half`, `int`, `uint`, `Int128`, `UInt128`, `short`, `ushort`, `nint`, `nuint`, `Type`, `string`, and for `Func`, `Action`, `Predicate`, & other delegates.

 * Core types that make it easy to define & constrain const type args and extend support to new data types.

 * Special types that *hold* other const type args or act as *discards* for type parameters.

 * Libraries for `System.Threading.Interlocked` operations, `System.Console`-related types, and more.

 * Samples demonstrating const type args in action, including simple implementations for units of measure and static polymorphic buffers.

#### Table of Contents

* [**Benefits**](https://github.com/zacharylayne/ConstTypeArgs/tree/master#benefits)
* [**Use case scenarios**](https://github.com/zacharylayne/ConstTypeArgs/tree/master#use-case-scenarios)
* [**Create and use const type args**](https://github.com/zacharylayne/ConstTypeArgs/tree/master#create-and-use-const-type-args)
  * [**A very simple example**](https://github.com/zacharylayne/ConstTypeArgs/tree/master#a-very-simple-example)
* [**Framework components**](https://github.com/zacharylayne/ConstTypeArgs/tree/master#framework-components)
* [**Terminology**](https://github.com/zacharylayne/ConstTypeArgs/tree/master#terminology)
* [**Naming conventions**](https://github.com/zacharylayne/ConstTypeArgs/tree/master#naming-conventions)
* [**Documentation**](https://github.com/zacharylayne/ConstTypeArgs/tree/master#documentation)

[**Release history**](https://github.com/zacharylayne/ConstTypeArgs/blob/master/CHANGELOG.md)

[**Contributing**](https://github.com/zacharylayne/ConstTypeArgs/blob/master/CONTRIBUTING.md)

[**License**](https://github.com/zacharylayne/ConstTypeArgs/blob/master/LICENSE.txt)

<br>

> [!NOTE]
> Please be aware that the ConstTypeArgs framework is in active development. New features and improvements are being added, so stay tuned for updates!

</br>

## Benefits

Const type args bring a number of inherent and derived benefits, including:

* **Static polymorphism type specialization** - Const type arguments allow you to provide specialized implementations to generic consumers, enabling polymorphic behavior without incurring virtual dispatch or runtime overhead typical of inheritance-based polymorphism. This technique mimics compile-time specialization (such as [template specialization](https://en.cppreference.com/w/cpp/language/template_specialization) in C++), eliminating method-table lookups & virtual calls. This can result in significant performance improvements, especially in performance-critical scenarios, as the compiler can more effectively optimize away unnecessary indirection and method call.

* **Increased type safety** - Const type args provide strong type guarantees and can be used to enforce highly specific constraints *(e.g. positivity, upper/lower bounds, etc.)*. This reduces risks of invalid configurations, type mismatches, and runtime errors.

* **Flexible validation** - Const type args can be validated during type initialization, via static analysis, using reflection, or even simutaneously during module initialization. This flexibility allows users to choose the validation strategy that best fits their need

* **Type-level configuration** - By enabling configuration values to be directly embedded as part of a type itself, const type args remove the need to pass parameters at runtime and repeated validation checks. Configurations can easily be swapped, reducing boilerplate and improving code clarity.

* **Improved unit testing** - Unit tests can be written against different configurations of const type args without needing to rewrite core logic. This allows testing of a broader range of scenarios *(e.g. defaults, small/medium/large tiers, edge cases, etc.)* with minimal overhead, while keeping core logic clean and focused on primary responsibilities.

* **Easier benchmarking** - Const type args can be used to configure different performance profiles, algorithms, and data structures for benchmarking. This allows for more accurate and meaningful comparisons between different implementations without needing to rewrite core logic.

* **Domain-specific types** - Const type args can be used to encode domain values *(e.g. minimums, maximums, defaults)* into domain-specific types. This provides greater expressiveness and increases code clarity for specialized domains such as engineering and gaming.

* **Design pattern enhancements** - Design patterns like *state machines*, *command*, and *entity component systems (ECS)* gain increased clarity and type safety through predefined, strongly-typed const type args, making code safer and easier to maintain.

<br>

## Use case scenarios

Const type args are versatile and powerful, enabling a wide variety of use cases:

* **Type-Safe Configuration** - Enforce constraints on values such as buffer sizes, timeouts, or thread limits by ensuring only valid const type arguments can be used, preventing runtime misconfigurations.

* **Implementation Selection** - Configure specialized implementations of generic types optimized for different performance profiles, algorithms, and data structures.

* **Domain-Specific Constants** - Embed domain-specific values (e.g., currency symbols, units of measure, tax rates) directly into the type system to guarantee consistency and clarity throughout your codebase.

* **Parameterized Callbacks and Events** - Provide strongly typed, predefined values and delegates for event handlers or callbacks, minimizing runtime errors and unexpected inputs.

* **Units of Measure** - Encode units such as length, time, temperature, velocity, or mass directly into your type definitions, significantly reducing runtime conversion mistakes and improving readability. Take a look at the [**Units of Measure**](https://github.com/zacharylayne/ConstTypeArgs/tree/master/Samples/Samples.UnitsOfMeasure) for a simple units of measure implementation using const type args.

* **State Machines and Regex Patterns** - Represent valid state transitions, events, or regex patterns as const type arguments, ensuring patterns and states are both validated at initialization and easily discoverable.

* **Union-Like Types** - Mimic union type behavior by allowing generic types to accept multiple const type arguments, enhancing flexibility and type safety simultaneously.

* And more!

Check out the available [samples](https://github.com/zacharylayne/ConstTypeArgs/tree/master/Samples) to see const type args in action.

<br>

## Create and use const type args

Follow these steps:

1. Define a class or struct that implements `IConstTypeArg<T>` or derived type (such as [`K_String`](https://github.com/zacharylayne/ConstTypeArgs/blob/master/Source/ConstTypeArgs.Strings/Base.cs)) with a static `Value` readonly property that returns the data you want to "pass" to generics. This is the const type argument.
2. Create a generic type or method with a generic parameter with constraints compatible with the const type argument you defined and access the value through the static `Value` property.
3. Use the const type argument as the type parameter.

That's it!

### A very simple example

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

The code below shows a ***very simple*** demonstration of how const type args can be used for *type-level configuration*. Here, `Buffer<T, TSize>` uses values passed through `TSize` to specify allocation size for an underlying array. This could easily be extended for configuring resize strategy, growth limits, and other behaviors.

```csharp
public class Buffer<T, TSize>
    where TSize : IConstTypeArg<int>
{
    public T[] Data = new T[TSize.Value];
}

// Instantiating buffers with different const type args.
var smallBuffer = new Buffer<int, _32>();    // length == 32
var bigBuffer   = new Buffer<int, _1024>();  // length == 1024
```

<br>

## Framework components

The ConstTypeArgs framework is composed of a number of libraries such as:

* [ConstTypeArgs.Core](https://github.com/zacharylayne/ConstTypeArgs/tree/master/Source/ConstTypeArgs.Core) containing fundamental types such as the `IConstTypeArg<T>` interface, [`K<T, TArg>`](https://github.com/zacharylayne/ConstTypeArgs/blob/master/Source/ConstTypeArgs.Core/K.cs) to define const type arguments that wrap other const type arguments, and [__](https://github.com/zacharylayne/ConstTypeArgs/blob/master/Source/ConstTypeArgs.Core/__.cs) that are used to signify the abscense of values. The core library also contains a number of derived interfaces such as [`K_Struct`](https://github.com/zacharylayne/ConstTypeArgs/blob/master/Source/ConstTypeArgs.Core/Core/K_Struct.cs), [`K_Number`](https://github.com/zacharylayne/ConstTypeArgs/blob/master/Source/ConstTypeArgs.Core/Core/K_Number.cs), [`K_Enum`](https://github.com/zacharylayne/ConstTypeArgs/blob/master/Source/ConstTypeArgs.Core/Core/K_Enum.cs), [`K_Array`](https://github.com/zacharylayne/ConstTypeArgs/blob/master/Source/ConstTypeArgs.Core/Core/K_Array.cs) and [`K_Delegate`](https://github.com/zacharylayne/ConstTypeArgs/blob/master/Source/ConstTypeArgs.Core/Core/K_Delegate.cs) that can be used to constrain const type arguments.

* Libraries covering all primitive types such as [ConstTypeArgs.Bool](https://github.com/zacharylayne/ConstTypeArgs/tree/master/Source/ConstTypeArgs.Bools), [ConstTypeArgs.Chars](https://github.com/zacharylayne/ConstTypeArgs/tree/master/Source/ConstTypeArgs.Chars), [ConstTypeArgs.Decimals](https://github.com/zacharylayne/ConstTypeArgs/tree/master/Source/ConstTypeArgs.Decimals), [ConstTypeArgs.Ints](https://github.com/zacharylayne/ConstTypeArgs/tree/master/Source/ConstTypeArgs.Ints), [ConstTypeArgs.Nints](https://github.com/zacharylayne/ConstTypeArgs/tree/master/Source/ConstTypeArgs.Nints), and [ConstTypeArgs.Ulongs](https://github.com/zacharylayne/ConstTypeArgs/tree/master/Source/ConstTypeArgs.Ulongs), as well as [ConstTypeArgs.Strings](https://github.com/zacharylayne/ConstTypeArgs/tree/master/Source/ConstTypeArgs.Strings), [ConstTypeArgs.Types](https://github.com/zacharylayne/ConstTypeArgs/tree/master/Source/ConstTypeArgs.Types), [ConstTypeArgs.Halfs](https://github.com/zacharylayne/ConstTypeArgs/tree/master/Source/ConstTypeArgs.Halfs), [ConstTypeArgs.Int128s](https://github.com/zacharylayne/ConstTypeArgs/tree/master/Source/ConstTypeArgs.Int128s), and [ConstTypeArgs.UInt128s](https://github.com/zacharylayne/ConstTypeArgs/tree/master/Source/ConstTypeArgs.UInt128s).

* [ConstTypeArgs.Delegates](https://github.com/zacharylayne/ConstTypeArgs/tree/master/Source/ConstTypeArgs.Delegates), containing delegates ([`RefFunc`](https://github.com/zacharylayne/ConstTypeArgs/blob/master/Source/ConstTypeArgs.Delegates/Funcs/RefFunction.cs), [`SpanProcedure`](https://github.com/zacharylayne/ConstTypeArgs/blob/master/Source/ConstTypeArgs.Delegates/Actions/SpanProcedure.cs), and more), interfaces, and basic const type args for logic operations and other simple delegates.

* [ConstTypeArgs.Delegates.Interlocked](https://github.com/zacharylayne/ConstTypeArgs/tree/master/Source/ConstTypeArgs.Delegates.Interlocked) which provides const type args that cover the majority of operations in [`System.Threading.Interlocked`](https://learn.microsoft.com/dotnet/api/system.threading.interlocked) such as [`Add`](https://github.com/zacharylayne/ConstTypeArgs/blob/master/Source/ConstTypeArgs.Delegates.Interlocked/Add/Add.cs), [`Exchange`](https://github.com/zacharylayne/ConstTypeArgs/blob/master/Source/ConstTypeArgs.Delegates.Interlocked/Exchange/Exchange.cs), [`CompareExchange`](https://github.com/zacharylayne/ConstTypeArgs/blob/master/Source/ConstTypeArgs.Delegates.Interlocked/CompareExchange/CompareExchange.cs), and more.

* [ConstTypeArgs.Console](https://github.com/zacharylayne/ConstTypeArgs/tree/master/Source/ConstTypeArgs.Console) that covers .NET console-related types, such as for [`ConsoleColor`](https://learn.microsoft.com/dotnet/api/system.consolecolor), [`ConsoleKey`](https://learn.microsoft.com/dotnet/api/system.consolekey), [`ConsoleModifiers`](https://learn.microsoft.com/dotnet/api/system.consolemodifiers), etc.

<br>

## Terminology

* **Const type argument** - A type that is used to "pass" values to generics via generic parameters. All const type arguments implement [`IConstTypeArg<T>`](https://github.com/zacharylayne/ConstTypeArgs/blob/master/Source/ConstTypeArgs.Core/IConstTypeArg.cs).

* **Const type parameter** - A generic parameter constrained to a type implementing `IConstTypeArg<T>`.

* **Argument holder** - A const type argument that wraps or composes other const type arguments. Argument holders implement [`K<T, TArg>`](https://github.com/zacharylayne/ConstTypeArgs/blob/master/Source/ConstTypeArgs.Core/K.cs).

For more definitions, see the [Glossary](https://github.com/zacharylayne/ConstTypeArgs/blob/master/Documentation/glossary.md).

<br>

## Naming conventions

| Convention          | Description                                                                                                                                                |
|---------------------|------------------------------------------------------------------------------------------------------------------------------------------------------------|
| **`K_` Prefix**     | Used for **interfaces** deriving from `IConstTypeArg<T>`, indicating they represent a “constant” similar to notation in mathematic formulas to denote an unknown constant value. |
| **`_` Prefix**      | Used for **concrete types** (e.g., `_32`, `_A`, `_Blue`) that implement `IConstTypeArg<T>`. This groups similar constants and clarifies each value’s role. |
| **`__`** Types      | These are **discards** (e.g., `__`) that may implement multiple const type arg interfaces, effectively providing union-like behavior with default/`null` values.        |


<br>

## Documentation

Find more information under [Documentation](https://github.com/zacharylayne/ConstTypeArgs/tree/master/Documentation), including:

- [**Glossary**](https://github.com/zacharylayne/ConstTypeArgs/blob/master/Documentation/glossary.md)

<br>

## Samples

[**Buffer**](https://github.com/zacharylayne/ConstTypeArgs/tree/master/Samples/Samples.Buffer) - Uses const type args for static polymorphism, creating compiled types representing buffers of different sizes &amp; resize functionality.

[**Units of Measure**](https://github.com/zacharylayne/ConstTypeArgs/tree/master/Samples/Samples.UnitsOfMeasure) - A simple implementation of units of measure using const type args.

<br>

## Questions or comments?

Feel free to submit an issue or add to the discussion! Feedback, suggestions, & collaboration are more than welcome if you're interested in contributing to the project. Thanks for checking it out!
