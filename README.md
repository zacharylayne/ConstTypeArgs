# ConstTypeArgs Framework

The **ConstTypeArgs** framework contains libraries, samples, and documentation to support working with *const type arguments*.

Const type arguments, or const type args, provide type-level constant values that can be *"passed" to generic types & methods via type parameters. These values can be accessed within static contexts (such as type initializers/static constructors and static methods, fields, & properties), instance methods without the need to be passed, local functions, and lambdas *(without causing closures)*. Const type args offer unique benefits and adaptability across a wide variety of use cases, including type specialization, static polymorphism, increased type safety, flexible validation, compiler optimizations, and more.

Inside the framework you'll find:

* Support for a wide variety of BCL data types such as `bool`, `byte`, `char`, `decimal`, `double`, `float`, `Half`, `int`, `uint`, `Int128`, `UInt128`, `short`, `ushort`, `nint`, `nuint`, `Type`, `string`, and delegates such as `Func`, `Action`, `Predicate`, & others. Support includes pre-defined const type args covering common values & operations and additional types that make it easier to define, extend, and constrain const type args.
* Foundational types that make it easy to define & constrain const type args and extend support to new data types.
* Special types that hold *(wrap)* other const type args or act as *discards* for type parameters.
* Specially-designed support for `System.Threading.Interlocked` operations, `System.Console`-related enums, and more.
* Samples demonstrating const type args in action, including simple implementations for units of measure and type-configurable buffers.
* Ample XML code comments and user guide material.

#### Table of contents

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

<br/>

> [!NOTE]
> Please be aware that the ConstTypeArgs framework is in active development. New features and improvements are being added, so stay tuned for updates!

<br/>

## Benefits

Const type args bring a number of inherent and derived benefits, including:

* **Type specialization** - Const type args allow you to define generic types whose implementations vary depending on the specific const type argument provided. Each const type arg encapsulates a distinct, static value or configuration, enabling specialized behaviors tailored explicitly to that value. This results in clearer and more maintainable code, as type behaviors become predictable and explicitly tied to their associated const type argument. By providing precise, specialized implementations rather than general-purpose logic, your code can be more efficient and optimized for each specific scenario. This mimics C++'s [template specialization](https://en.cppreference.com/w/cpp/language/template_specialization).

* **Static polymorphism** - Const type args facilitate static polymorphism by allowing generic types to resolve method implementations at compile-time rather than runtime. Unlike traditional inheritance-based polymorphism (dynamic polymorphism), const type args eliminate the overhead of virtual method dispatch and method-table lookups, ensuring that the correct implementation is determined and bound directly during compilation. This leads to significantly improved performance, especially critical in scenarios sensitive to runtime overhead, as the compiler can optimize calls and remove unnecessary indirections entirely.

* **Increased type safety** - Const type args provide strong type guarantees and can be used to enforce highly specific constraints *(e.g. positivity, upper/lower bounds, etc.)*. This reduces risks of invalid configurations, type mismatches, and runtime errors.

* **Flexible validation** - Const type args can be validated during type initialization, via static analysis, using reflection, or even simutaneously during module initialization. This flexibility allows users to choose the validation strategy that best fits their need

* **Type-level configuration** - Const type args enable configuration values to be directly embedded as part of a type itself, const type args remove the need to pass arguments to constructors and repeat validation checks. Configurations can easily be swapped, reducing boilerplate and improving code clarity.

* **Improved unit testing** - Const type args can allow unit tests to be written against different configurations of const type args without needing to rewrite core logic. This allows testing of a broader range of scenarios *(e.g. defaults, small/medium/large tiers, edge cases, etc.)* with minimal overhead, while keeping core logic clean and focused on primary responsibilities.

* **Easier benchmarking** - Const type args can be used to configure different performance profiles, algorithms, and data structures for benchmarking. This allows for more accurate and meaningful comparisons between different implementations without needing to rewrite core logic.

* **Domain-specific types** - Const type args can be used to encode domain values *(e.g. minimums, maximums, defaults)* into domain-specific types. This provides greater expressiveness and increases code clarity for specialized domains such as engineering and gaming.

* **Design pattern enhancements** - Const type args can provide design patterns like *state machines*, *command*, and *entity component systems (ECS)* increased clarity and type safety through predefined, strongly-typed const type args, making code safer and easier to maintain.

<br/>

## Use case scenarios

Const type args are versatile and powerful, enabling a wide variety of use cases:

* **Implementation selection** - Configure specialized implementations of generic types optimized for different performance profiles, algorithms, and data structures.

* **Domain-specific constants** - Embed domain-specific values (e.g., currency symbols, units of measure, tax rates) directly into the type system to guarantee consistency and clarity throughout your codebase.

* **Parameterized callbacks and events** - Provide strongly typed, predefined values and delegates for event handlers or callbacks, minimizing runtime errors and unexpected inputs.

* **Units of measure** - Encode units such as length, time, temperature, velocity, or mass directly into your type definitions, significantly reducing runtime conversion mistakes and improving readability. Take a look at the [**Units of Measure**](https://github.com/zacharylayne/ConstTypeArgs/tree/master/Samples/Samples.UnitsOfMeasure) for a simple units of measure implementation using const type args.

* **Type-safe configuration** - Enforce constraints on values such as buffer sizes, timeouts, or thread limits by ensuring only valid const type arguments can be used, preventing runtime misconfigurations.

* **State machines and Regex patterns** - Represent valid state transitions, events, or regex patterns as const type arguments, ensuring patterns and states are both validated at initialization and easily discoverable.

* **Union-like types** - Mimic union type behavior by allowing generic types to accept multiple const type arguments, enhancing flexibility and type safety simultaneously.

* And more!

Check out the available [samples](https://github.com/zacharylayne/ConstTypeArgs/tree/master/Samples) to see const type args in action.

<br/>

## Create and use const type args

Follow these steps:

1. Define a class or struct that implements `IConstTypeArg<T>` or derived type (such as [`K_String`](https://github.com/zacharylayne/ConstTypeArgs/blob/master/Source/ConstTypeArgs.Strings/Base.cs)) with a static readonly property named `Value` that returns the data you want to "pass" to generics. This is the const type argument.
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

<br/>

**Using const type args**

The code below shows a ***very, very simple*** demonstration of how using const type args for *type-level configuration* works. Here, `Buffer<T, TSize>` uses values passed through `TSize` to specify allocation size for an underlying array. This could easily be extended for configuring resize strategy, growth limits, and other behaviors.

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

<br/>

## Framework components

The ConstTypeArgs framework is composed of a number of libraries such as:

* [ConstTypeArgs.Core](https://github.com/zacharylayne/ConstTypeArgs/tree/master/Source/ConstTypeArgs.Core) containing fundamental types such as the `IConstTypeArg<T>` interface, [`K<T, TArg>`](https://github.com/zacharylayne/ConstTypeArgs/blob/master/Source/ConstTypeArgs.Core/K.cs) to define const type arguments that wrap other const type arguments, and [__](https://github.com/zacharylayne/ConstTypeArgs/blob/master/Source/ConstTypeArgs.Core/__.cs) that are used to signify the abscense of values. The core library also contains a number of derived interfaces such as [`K_Struct`](https://github.com/zacharylayne/ConstTypeArgs/blob/master/Source/ConstTypeArgs.Core/Core/K_Struct.cs), [`K_Number`](https://github.com/zacharylayne/ConstTypeArgs/blob/master/Source/ConstTypeArgs.Core/Core/K_Number.cs), [`K_Enum`](https://github.com/zacharylayne/ConstTypeArgs/blob/master/Source/ConstTypeArgs.Core/Core/K_Enum.cs), [`K_Array`](https://github.com/zacharylayne/ConstTypeArgs/blob/master/Source/ConstTypeArgs.Core/Core/K_Array.cs) and [`K_Delegate`](https://github.com/zacharylayne/ConstTypeArgs/blob/master/Source/ConstTypeArgs.Core/Core/K_Delegate.cs) that can be used to constrain const type arguments.

* Libraries covering all primitive types such as [ConstTypeArgs.Bool](https://github.com/zacharylayne/ConstTypeArgs/tree/master/Source/ConstTypeArgs.Bools), [ConstTypeArgs.Chars](https://github.com/zacharylayne/ConstTypeArgs/tree/master/Source/ConstTypeArgs.Chars), [ConstTypeArgs.Decimals](https://github.com/zacharylayne/ConstTypeArgs/tree/master/Source/ConstTypeArgs.Decimals), [ConstTypeArgs.Ints](https://github.com/zacharylayne/ConstTypeArgs/tree/master/Source/ConstTypeArgs.Ints), [ConstTypeArgs.Nints](https://github.com/zacharylayne/ConstTypeArgs/tree/master/Source/ConstTypeArgs.Nints), and [ConstTypeArgs.Ulongs](https://github.com/zacharylayne/ConstTypeArgs/tree/master/Source/ConstTypeArgs.Ulongs), as well as [ConstTypeArgs.Strings](https://github.com/zacharylayne/ConstTypeArgs/tree/master/Source/ConstTypeArgs.Strings), [ConstTypeArgs.Types](https://github.com/zacharylayne/ConstTypeArgs/tree/master/Source/ConstTypeArgs.Types), [ConstTypeArgs.Halfs](https://github.com/zacharylayne/ConstTypeArgs/tree/master/Source/ConstTypeArgs.Halfs), [ConstTypeArgs.Int128s](https://github.com/zacharylayne/ConstTypeArgs/tree/master/Source/ConstTypeArgs.Int128s), and [ConstTypeArgs.UInt128s](https://github.com/zacharylayne/ConstTypeArgs/tree/master/Source/ConstTypeArgs.UInt128s).

* [ConstTypeArgs.Delegates](https://github.com/zacharylayne/ConstTypeArgs/tree/master/Source/ConstTypeArgs.Delegates), containing delegates ([`RefFunc`](https://github.com/zacharylayne/ConstTypeArgs/blob/master/Source/ConstTypeArgs.Delegates/Funcs/RefFunction.cs), [`SpanProcedure`](https://github.com/zacharylayne/ConstTypeArgs/blob/master/Source/ConstTypeArgs.Delegates/Actions/SpanProcedure.cs), and more), interfaces, and basic const type args for logic operations and other simple delegates.

* [ConstTypeArgs.Delegates.Interlocked](https://github.com/zacharylayne/ConstTypeArgs/tree/master/Source/ConstTypeArgs.Delegates.Interlocked) which provides const type args that cover the majority of operations in [`System.Threading.Interlocked`](https://learn.microsoft.com/dotnet/api/system.threading.interlocked) such as [`Add`](https://github.com/zacharylayne/ConstTypeArgs/blob/master/Source/ConstTypeArgs.Delegates.Interlocked/Add/Add.cs), [`Exchange`](https://github.com/zacharylayne/ConstTypeArgs/blob/master/Source/ConstTypeArgs.Delegates.Interlocked/Exchange/Exchange.cs), [`CompareExchange`](https://github.com/zacharylayne/ConstTypeArgs/blob/master/Source/ConstTypeArgs.Delegates.Interlocked/CompareExchange/CompareExchange.cs), and more.

* [ConstTypeArgs.Console](https://github.com/zacharylayne/ConstTypeArgs/tree/master/Source/ConstTypeArgs.Console) that covers .NET console-related types, such as for [`ConsoleColor`](https://learn.microsoft.com/dotnet/api/system.consolecolor), [`ConsoleKey`](https://learn.microsoft.com/dotnet/api/system.consolekey), [`ConsoleModifiers`](https://learn.microsoft.com/dotnet/api/system.consolemodifiers), etc.

<br/>

## Terminology

* **Const type argument** - A type that is used to "pass" values to generics via generic parameters. All const type arguments implement [`IConstTypeArg<T>`](https://github.com/zacharylayne/ConstTypeArgs/blob/master/Source/ConstTypeArgs.Core/IConstTypeArg.cs).

* **Const type parameter** - A generic parameter constrained to a type implementing `IConstTypeArg<T>`.

* **Argument holder** - A const type argument that wraps or composes other const type arguments. Argument holders implement [`K<T, TArg>`](https://github.com/zacharylayne/ConstTypeArgs/blob/master/Source/ConstTypeArgs.Core/K.cs).

For more definitions, see the [Glossary](https://github.com/zacharylayne/ConstTypeArgs/blob/master/Documentation/glossary.md).

<br/>

## Naming conventions

| Convention          | Description                                                                                                                                                |
|---------------------|------------------------------------------------------------------------------------------------------------------------------------------------------------|
| **`K_` Prefix**     | Used for **interfaces** deriving from `IConstTypeArg<T>`, indicating they represent a “constant” similar to notation in mathematic formulas to denote an unknown constant value. |
| **`_` Prefix**      | Used for **concrete types** (e.g., `_32`, `_A`, `_Blue`) that implement `IConstTypeArg<T>`. This groups similar constants and clarifies each value’s role. |
| **`__`** Types      | These are **discards** (e.g., `__`) that may implement multiple const type arg interfaces, effectively providing union-like behavior with default/`null` values.        |

<br/>

## Documentation

Find more information under [Documentation](https://github.com/zacharylayne/ConstTypeArgs/tree/master/Documentation), including:

- [**Glossary**](https://github.com/zacharylayne/ConstTypeArgs/blob/master/Documentation/glossary.md)

<br/>

## Samples

[**Buffer**](https://github.com/zacharylayne/ConstTypeArgs/tree/master/Samples/Samples.Buffer) - Uses const type args for static polymorphism, creating compiled types representing buffers of different sizes &amp; resize functionality.

[**Units of Measure**](https://github.com/zacharylayne/ConstTypeArgs/tree/master/Samples/Samples.UnitsOfMeasure) - A simple implementation of units of measure using const type args.

<br/>

## Questions or comments?

Feel free to submit an issue or add to the discussion! Feedback, suggestions, & collaboration are more than welcome if you're interested in contributing to the project. Thanks for checking it out!
