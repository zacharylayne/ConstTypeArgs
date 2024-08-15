# Glossary

This page provides a glossary of terms used throughout the ConstTypeArgs documentation.

## Common Terms

The terms in this section are used throughout the ConstTypeArgs documentation and are essential to understanding the framework.

* **Const Type Argument** -  Also called *const type arg*. A type that uses generic parameters to "pass" values to generics. These types implement [`IConstTypeArg<T>`](https://github.com/zacharylayne/ConstTypeArgs/blob/master/Source/ConstTypeArgs.Core/IConstTypeArg.cs). Values are meant to be literals or constants and ***SHOULD ALWAYS BE IMMUTABLE***. They can be [used](https://github.com/zacharylayne/ConstTypeArgs/blob/master/Documentation/Use%20Cases.md) to "pass" data to static constructors, for field & property initialization, type configuration, algorithm specialization, and more.
  
  This term is interchangeable with the value they hold unless ambiguity arises, in which case *argument provider* and *argument value* are used.

* **Argument Provider:** Also called *arg provider* or *provider*. A more specific term for *const type argument* that refers to concrete implementations of `IConstTypeArg<T>`. 

* **Argument Value:**  Also called *arg value*. A more specific term for *const type arguments* that refers to the value an argument provider defines. Values are meant to be literals or constants and ***SHOULD ALWAYS BE IMMUTABLE***.

* **Const Type Parameter:** - Also called *const type param*. A generic parameter that is used for const type arguments "pass" values through.

* **Const Type Holder:** Also called *arg holder* or *holder*. Argument providers that wrap other argument providers. Argument holders can be used to create domain-specific const type arguments for minimums, maximums, defaults, and more. In specific use cases, this is referred to as *domain-specific type arguments* or *domain-specific type args*.

* **Argument Consumer** - Also called *arg consumer* or *consumer*. A generic that with one or more const type parameters. Usually these are generic types or methods, but can also include delegates.

* **Const Type Discard:** Also called *discard arg* or *discard*. A type that is used to signify the absence of a const type argument. These types can be used to provide union-like functionality and may implement a large number of interfaces in order to increase their versatility.

## Other Terms

The terms in this section are used infrequently in ConstTypeArgs documentation.

* **Const Type:** All types that inherit from the base interface `IConstTypeArg<T>`. Concrete argument types are known as *argument providers*.

* **Const Type Interface** - An interface that const type arguments implement.

* **Const Type Enum** - An enum-like const type argument defining a set of const type arguments.

* **Const Type Union** - A const type argument that can represent multiple types.

## See Also

* [Overview](https://github.com/zacharylayne/ConstTypeArgs/blob/master/Documentation/README.md)
