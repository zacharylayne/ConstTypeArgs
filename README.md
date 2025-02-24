# Const Type Args Framework

The **Const Type Args** framework provides libraries, samples, and documentation to support working with *const type arguments*. Const type arguments, or **const type args**, are used to effectively "pass" compile-time-like values to generic types & methods via generic parameters and accessible in static contexts such as type initialization, and static methods, fields, &amp; properties.

## Benefits

Const type args provide a number of inherent and derived benefits, including:

* **Static polymorphism** - Similar to [template specialization](https://en.cppreference.com/w/cpp/language/template_specialization) in C++, const type arguments can provide implementations to <abbr title="Generic types with one or more generic parameters constrained to const type args.">arg consumer types</abbr>, enabling compile-time specialization and avoiding virtual dispatch and other runtime overhead polymorphism typically incurs. 

* **Increased type safety** - Various techniques can ensure const type args only supply <abbr title="Generic types and methods with one or more generic parameters constrained to const type args.">arg consumers</abbr> with valid values. This reduces the risks of invalid configurations, mismatched types, and other runtime issues. Some techniques include validation during type initialization, using highly specific generic constratins, and even static analysis tools.

* **Type configuration** - Const type args can be used to configure types of arg consumers which can avoid needlessly passing configuration values, redundant validation, and improve readability &amp; expressivness by replacing "magic numbers" with descriptive type names.

* **Reduced test boilerplate** - Testing different const type arg configurations is as simple as replacing generic type &amp; method arguments, helping reduce mock setup and repetitive test code.

* **Additonal reusablitity** - Const type args can be defined once and used in multiple const type arg configurations, reducing code duplication. Similarly, arg consumers can be extended with new const type arg types instead of new classes.

* **Design pattern enhancements** - Patterns like *State Machines* and *Entity Component Systems (ECS)* can benefit from strongly typed, predefined values that make transitions and components type-safe.

## Use case scenarios

Const type args can be used in a variety of different scenarios, soem of which include:


* **Type-safe configuration** - Enforce constraints on buffer sizes, timeouts, or thread limits by ensuring only valid const type arguments can be used.

* **Implementation selection** - Configure specialized versions of a generic type (e.g., `SmallBuffer`, `MediumBuffer`, `LargeBuffer`) for different performance profiles.

* **Domain-specific values** - Integrate domain constants (e.g., currency, units of measurement) into the type system to guarantee consistency across your codebase.

* **Parameterized callbacks & events** - Provide predefined values or delegates as part of event handlers or callbacks, preventing unexpected inputs at runtime.

* **Units of measure** - Encode measurement units (length, time, temperature) directly into the type system, reducing runtime conversion errors.

* **State Machines & RegEx Patterns** - Model valid state transitions or store regex patterns in const type arguments, ensuring they’re validated and discoverable throughout the application.

* **Union-Like Types** - Emulate union behaviors by allowing a generic type to accept multiple const type arguments, making your code both flexible and safe.

* and more!

Check out the available [samples](https://github.com/zacharylayne/ConstTypeArgs/tree/master/Samples) for in-depth examples of const type args in action.

## How to use const type args

Using const type args is simple. First, define a type implementing `IConstTypeArg<T>` and have the `Value` property return the value you want to "pass" with a generic argument. Then, for any generic type or method, use the const type arg you defined as a generic argument constrained to a type of `IConstTypeArg<T>` *(i.e., a const type parameter)*.

### A simple example

**Defining const type args**

```csharp
using ConstTypeArgs;

public readonly struct _32 : IConstTypeArg<int>
{
    public static int Value => 32;
}

// Assume similar definitions for _1024, True, False.

```


**Usage Example**:
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

---

## Terminology

* **Const type argument** - A type (implementing `IConstTypeArg<T>`) that provides a static `Value` and is passed as a generic argument. Sometimes called *const type arg* or *argument provider*.

* **Const type parameter** - A generic parameter constrained to a type implementing `IConstTypeArg<T>`. Sometimes called *const type param*.

* **Argument holder** - A const type argument that wraps or composes other const type arguments, typically implementing `K<T, TArg>`.

For more definitions, see the [Glossary](https://github.com/zacharylayne/ConstTypeArgs/blob/master/Documentation/glossary.md).

---

## Naming Conventions

| Convention          | Description                                                                                                                                                |
|---------------------|------------------------------------------------------------------------------------------------------------------------------------------------------------|
| **`K_` Prefix**     | Used for **interfaces** deriving from `IConstTypeArg<T>`, indicating they represent a “constant” in mathematical form.                                     |
| **`_` Prefix**      | Used for **concrete types** (e.g., `_32`, `_A`, `_Blue`) that implement `IConstTypeArg<T>`. This groups similar constants and clarifies each value’s role. |
| **`__`** Types      | These are **discards** (e.g., `__`) that may implement multiple const type arg interfaces, effectively providing union-like behavior with default/`null` values.        |

---

## Further Documentation

Explore more in the [Documentation folder](https://github.com/zacharylayne/ConstTypeArgs/tree/master/Documentation), including:

- **Benefits**
- **Use Cases**
- **Glossary**

---
