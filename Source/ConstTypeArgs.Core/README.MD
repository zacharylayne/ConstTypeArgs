# ConstTypeArgs.Core

The ConstTypeArgs.Core framework provides the basic types needed to create *const type arguments*, which are types used to pass values to generics via their type parameters. These values can be used in static contexts, such as for static constructors, field initialization, and more.

# The ConstTypeArgs Framework

The ConstTypeArgs framework allows you to work with **const type arguments** (also called *const type args*), which use type parameters to "pass" constant-like values to generics. These values are can be used in static contexts, such as static constructors, static fields, and static methods. This can mimic C++ [template specialization](https://en.cppreference.com/w/cpp/language/template_specialization), provide enhanced type safety, static polymorphism, increased expressiveness, and more.

## Benefits

There are many benefits to using const type arguments, just some of which are listed below:

* **Type Safety**
* **Static Polymorphism**
* **Flexible Validation**
* **Domain Specific Types**
* **Improved Readability & Expressiveness**
* **Flexible & Reusable Components**
* **Enhanced Debugging**
* **Improved Unit Testing**

These are just some of the benefits the ConstTypeArgs framework can provide.

## Use Case Scenarios

Const type arguments can be used in a variety of scenarios to provide enhanced type safety, static polymorphism, increased expressiveness, and more. Some ways const type arguments can be used include:

* **Buffer Size Specification**
* **Type Configuration** 
* **Implementation Selection**
* **Union-Like Types**
* **Units of Measure**
* **Type-Safe State Machines**
* **Event Handlers as Types**
* **RegEx Patterns as Types**
* **Enum-Like Types**
* **Design Pattern Enhancement**
* **ECS (Entity-Component-System) Integration**
* **Type Mapping**

These are just some of the use cases where const type arguments can be used to provide enhanced type safety, static polymorphism, increased expressiveness, and more.

## Defining & Using Const Type Arguments

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

## Glossary

These are some of the common terms used throughout the ConstTypeArgs documentation:

* **Const Type Argument** - A type that uses type parameters to "pass" values to generics.  This term is interchangeable with the value they hold unless ambiguity arises, in which case *argument provider* and *argument value* are used.
* **Const Type Parameter:** - A type parameter that const type arguments "pass" values through.
* **Argument Holder** - A const type argument that wraps other const type arguments. These are useful for reusing domain-specific values.

Go to [Glossary](https://github.com/zacharylayne/ConstTypeArgs/blob/master/Documentation/Glossary.md) for more details and terminology.

## Types

At the ConstTypeArgs framework's very core is the interface `IConstTypeArg<T>`. This type only contains a single member: the static abstract property `Value`. This type isn't special by itself, however it is the foundational type which the framework is built upon.

> [!NOTE]
> `IConstTypeArg<T>` implements the marker interface `IConstTypeArg` which in some cases can benefit type test.
>
> `IConstTypeArg<T, TSelf>` is a related type and inherits from `IConstTypeArg<T>`. This type allows const type argument instantiation in the rare cases this is needed.

This is used to create a set of core interfaces, such as [`K`](https://github.com/zacharylayne/ConstTypeArgs/blob/master/Source/ConstTypeArgs.Core/K.cs), [`K_Array<T>`](https://github.com/zacharylayne/ConstTypeArgs/blob/master/Source/ConstTypeArgs.Core/Core/K_Array.cs), [`K_Class<T>`](https://github.com/zacharylayne/ConstTypeArgs/blob/master/Source/ConstTypeArgs.Core/Core/K_Class.cs), [`K_Integer`](https://github.com/zacharylayne/ConstTypeArgs/blob/master/Source/ConstTypeArgs.Core/Core/K_Integer.cs), [`K_Delegate<T>`](https://github.com/zacharylayne/ConstTypeArgs/blob/master/Source/ConstTypeArgs.Core/Core/K_Delegate.cs), [`K_Unmanaged_<T>`](https://github.com/zacharylayne/ConstTypeArgs/blob/master/Source/ConstTypeArgs.Core/Core/K_Unmanaged.cs), and others that are used as constraints and are further built upon in other ConstTypeArgs libraries.

For more information, go to [Types](https://github.com/zacharylayne/ConstTypeArgs/blob/master/Documentation/dev-guide/Types.md).

### Naming Conventions

The ConstTypeFramework modifies standard naming conventions in order to provide a more expressive and readable codebase, outlined in the following table:

| Convention | |
|:-------------------|-|
| `K_` Prefix | The names of argument interfaces *(i.e. interfaces deriving from `IConstTypeArg<T>`)* use this prefix. This is meant to indicate that rather than define a contract, they are the means to "pass" values via generic type parameters. The prefix refers to how `K` is used in mathematic formulas to denote an unknown constant value. |
| `_` Prefix | Many argument providers *(i.e. concrete types that implement `IConstTypeArg<T>`)* in ConstTypeArg libraries have the prefix `_` followed by a representation of their value *(e.g. _1024, _A, _Blue)*. This helps alphabetize and group similar types together. |
| [`__`](#__) Types | Argument types *(i.e. types deriving from or implementing `IConstTypeArg<T>`)* that implement [`__`](/Core/__.cs) are used as "discards" to indicate they lack a value. These types are simply named `__` and usually explicitly implement multiple arg type interfaces and provide either `default` or `null` values. These can be used with argument consumers providing union-like behavior. |

# Installation

To install the ConstTypeArgs.Core library, run the following command in the Package Manager Console:

```
dotnet add package ConstTypeArgs.Core
```

# License
The ConstTypeArgs.Core library is licensed under the MIT License. See the [LICENSE](LICENSE.txt) file for more details.
