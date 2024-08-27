ConstTypeArgs Framework
===

The ConstTypeArgs framework provides everything needed to work with *const type arguments*. Const type arguments, or *const type args*, are types that use generic parameters to conceptually *"pass"* const-like values to generics. These values are available directly through the generic parameters, allowing them to be used in static contexts *(i.e. static constructors, static fields, static methods, static anonymous functions, etc.)*, to initialize fields, inside property & event accessors, and in parameterless constructors & instance methods, as well other scenarios.

<br/>

The framework is written in C# 11 and targets .NET 8.0. Be aware that the framework is still in development and many features are still being added.

<br/>

## Benefits

There are many benefits to using const type arguments, including:

* **Static Polymorphism:** Static polymorphism allows runtime type-based dispatch at runtime using const type arguments. By leveraging static properties, the framework enables dispatch mechanisms that improve performance in certain scenarios without relying on traditional runtime polymorphism. This allows for flexible behavior across different types without the overhead of virtual methods or dynamic dispatch.

* **Increased Type Safety:** Const type arguments provide strong type guarantees at the type level, ensuring that only valid values, defined by const type arguments, are used in your code. This prevents errors related to mismatched types and enforces constraints on acceptable values for a given type, increasing overall safety and robustness.

* **Improved Readability & Expressiveness:** The use of const type arguments enhances code readability and expressiveness by allowing developers to associate meaningful values with generic types. This makes the intent of the code clearer and reduces ambiguity, which can be especially useful in larger systems with many configurations and options.

* **Enhancing Debugging:** Const type arguments allow developers to inspect and debug types that have predefined static values at runtime. By associating meaningful values with generic parameters, debugging becomes more intuitive because the associated values are traceable and clearly defined within the type system.

* **C++-like [template specialization](https://en.cppreference.com/w/cpp/language/template_specialization):** Although not compile-time, const type arguments allow specialization of generics based on static values, akin to C++ templates. This specialization enables multiple implementations of the same generic type, each optimized for a specific set of const type arguments, reducing code duplication and improving maintainability.

* **Flexible Validation:** Const type arguments allow developers to enforce specific constraints on values at the type level. By constraining generic parameters to const type arguments, developers can ensure that only predefined, valid values are used in various scenarios, improving validation and preventing errors related to invalid configurations.

* **Simplified Unit Tests:** Const type arguments simplify unit testing by allowing predefined, strongly-typed values to be passed into generic types. This reduces boilerplate setup and ensures that tests focus on the logic rather than the preparation or validation of inputs. It also allows for easier testing of different configurations by changing the const type argument.

* **Enhanced Implementations of State Machine, Entity Component System (ECS), and Other Design Pattern:** Design patterns such as state machines, Entity Component Systems (ECS), and others are enhanced by const type arguments. By associating predefined values with types, const type arguments enable more efficient and expressive implementation of these patterns, ensuring that the state or behavior of objects is predictable and type-safe.

* **Reusability:** Const type arguments improve code reusability by enabling developers to define flexible, generic types that can be reused across different contexts. By simply swapping const type arguments, developers can adapt the same generic type for various scenarios, reducing duplication and improving maintainability.

For more information, go to [Benefits](https://github.com/zacharylayne/ConstTypeArgs/blob/master/Documentation/benefits/benefits-overview.md) in the framework documentation.

<br/>

## Use Case Scenarios

Const type arguments can be used in a variety of scenarios to provide enhanced type safety, static polymorphism, increased expressiveness, and more. Some ways const type arguments can be used include:

* **Type-Safe Configuration:** Const type arguments allow developers to enforce type-safe configuration options in their systems. For example, the type system can validate predefined buffer sizes, timeout durations, or thread pool limits, ensuring that only valid values are used.

  * **Buffer Initialization:** Const type arguments make it easier to define buffers with specific sizes, ensuring that memory allocations are efficient and predefined. The sizes are associated with types, meaning they are known upfront and enforce consistent usage throughout the code.

* **Implementation Selection:** Const type arguments allow for different implementations of a generic type to be selected based on the associated static values. This makes it easy to create specialized versions of a class or algorithm for different contexts, such as small, medium, or large buffer sizes.

* **Domain-Specific Values:** In domains such as finance, engineering, or scientific computing, const type arguments can be used to represent specific domain values such as currency, units of measurement, or physical constants. These values are tied to the types, ensuring consistency and safety in their usage.

* **Parameterized Callbacks:** Const type arguments allow developers to create callbacks with predefined values, ensuring that callbacks are parameterized with valid, predefined values. This simplifies the use of callbacks and prevents unexpected or invalid values from being passed to them.

* **Custom Event Handlers:** Use const type arguments to enforce type-safe custom event handlers that respond to specific events. By associating predefined values with event handlers, you ensure that the correct handler is used for a specific event type, reducing runtime errors and improving event-driven systems.

* **Units of Measure:** Const type arguments can be used to define units of measure such as length, time, or temperature, with const type arguments providing delegates to help convert between units. This ensures that conversions are type-safe and consistent across the codebase.

* **Type-Safe State Machines:** Const type arguments can be used to define state machines where state transitions are validated by the type system. This prevents invalid transitions and ensures that state changes are predictable and type-safe, reducing the risk of unexpected behavior in state-based systems.

* **Type-Safe RegEx Patterns:** Const type arguments can hold regular expression patterns, ensuring that these patterns are validated and consistent throughout the codebase. This reduces runtime errors caused by invalid regex patterns and provides a type-safe way of working with text-based validation.

* **Union-Like Types:** Const type arguments can simulate union-like types by allowing a generic type to accept multiple const type arguments. This provides flexibility while ensuring that the correct type is used in each scenario, improving safety and expressiveness.

For more information on use cases, go to [Use Cases](https://github.com/zacharylayne/ConstTypeArgs/blob/master/Documentation/use-cases/use-cases-overview.md) in the framework documentation.

<br/>
f
## Defining & Using Const Type Arguments

**NOTE:** The term *const type argument* is used for simplicity, to tie together related terminology, & to imply intent. Const type arguments are not true constants, but rather types that provide a constant-like, immutable value to generics and are not available at compile-time.

Defining a const type argument is as simple as:

```csharp
using ConstTypeArgs;

public readonly struct _32 : IConstTypeArg<int>
{ public static int Value => 32; }
```

And using it is as simple as:

```csharp
public class Buffer<T, TSize>
    where TSize : IConstTypeArg<int>
{
    public T[] Data = new T[TSize.Value];
}

var smallBuffer = new Buffer<int, _32>();
// smallBuffer.Data.Length == 32

var bigBuffer = new Buffer<int, _1024>();
// bigBuffer.Data.Length == 1024
```

<br/>

## Terminology

These are some of the common terms used throughout the ConstTypeArgs documentation:

* **Const Type Argument** - A type that uses generic parameters to "pass" values to generics. Every const type argument directly or indirectly implements [`IConstTypeArg<T>`](https://github.com/zacharylayne/ConstTypeArgs/blob/master/Source/ConstTypeArgs.Core/IConstTypeArg.cs). The term const type argument can be interchangeable with the value they hold. If more clarity is needed, the terms *argument provider/arg provider* and *const type value* are used. Sometimes referred to as *const type arg*.

* **Const Type Parameter:** - A generic parameter that const type arguments "pass" values through. Every const type parameter is constrained to a *const type* *(i.e. any type that implements `IConstTypeArg<T>`)*. Sometimes referred to as *const type param*.

* **Argument Holder** - A const type argument that wraps other const type arguments. All argument holders directly or indirectly implement [`K<T, TArg>`]() Sometimes referred to as *arg holder*.

Go to the framework documentation [Glossary](https://github.com/zacharylayne/ConstTypeArgs/blob/master/Documentation/glossary.md) for more details and terminology.

## Naming Conventions

The ConstTypeFramework modifies standard naming conventions in order to provide a more expressive and readable codebase, outlined in the following table:

| Convention | |
|:-------------------|-|
| `K_` Prefix | The names of argument interfaces *(i.e. interfaces deriving from `IConstTypeArg<T>`)* use this prefix. This is meant to indicate that rather than define a contract, they are the means to "pass" values via generic type parameters. The prefix refers to how `K` is used in mathematic formulas to denote an unknown constant value. |
| `_` Prefix | Many argument providers *(i.e. concrete types that implement `IConstTypeArg<T>`)* in ConstTypeArg libraries have the prefix `_` followed by a representation of their value *(e.g. _1024, _A, _Blue)*. This helps alphabetize and group similar types together. |
| [`__`](#__) Types | Argument types *(i.e. types deriving from or implementing `IConstTypeArg<T>`)* that implement [`__`](/Core/__.cs) are used as "discards" to indicate they lack a value. These types are simply named `__` and usually explicitly implement multiple arg type interfaces and provide either `default` or `null` values. These can be used with argument consumers providing union-like behavior. |

## Further Documentation

Further documentation can be found in the [Documentation](https://github.com/zacharylayne/ConstTypeArgs/tree/master/Documentation) directory.
