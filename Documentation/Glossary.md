# Glossary

This page provides a glossary of terms used throughout the ConstTypeArgs documentation.

## Common Terms

The terms in this section are used throughout the ConstTypeArgs documentation and are essential to understanding the framework.

* **Const Type Argument:**  A type that uses generic parameters to "pass" static values to generics. Every const type argument directly or indirectly implements [`IConstTypeArg<T>`](https://github.com/zacharylayne/ConstTypeArgs/blob/master/Source/ConstTypeArgs.Core/IConstTypeArg.cs). The term const type argument can be interchangeable with the value they hold. If more clarity is needed, the terms *argument provider/arg provider* and *const type value* are used. ***VALUES SHOULD ALWAYS BE IMMUTABLE***. Sometimes referred to as *const type arg*.

* **Argument Provider:** A more specific term for *const type argument* that refers to concrete implementations of `IConstTypeArg<T>`. Also called *arg provider* or *provider*. 

* **Argument Value:**  A more specific term for *const type arguments* that refers to the value an argument provider defines. ***VALUES SHOULD ALWAYS BE IMMUTABLE***. Also called *arg value*.

* **Const Type Parameter:** A generic parameter that const type arguments "pass" values through. Every const type parameter is constrained to a *const type* *(i.e. any type that implements `IConstTypeArg<T>`)*. Also called *const type param*.

* **Const Type Holder:** A const type argument that wraps other const type arguments. All argument holders directly or indirectly implement [`K<T, TArg>`]() Sometimes referred to as *arg holder*. Argument holders can be used to create domain-specific const type arguments for minimums, maximums, defaults, and more. Also called *holder*. In specific use cases, this is referred to as *domain-specific type arguments* or *domain-specific type args*.

* **Argument Consumer:** A generic that with one or more const type parameters.

* **Const Type Discard:** A type that is used to signify the absence of a const type argument. These types can be used to provide union-like functionality and may implement many interfaces in order to increase their versatility.

## Other Terms

The terms in this section are used infrequently in ConstTypeArgs documentation.

* **Const Type:** Any type that inherit from the base interface `IConstTypeArg<T>`.

* **Const Type Interface:** An interface that const type arguments implement.

* **Const Type Enum:** An enum-like const type argument defining a set of const type arguments.

* **Open Argument Consumer:** A const type consumer that is an open generic. Also called *open arg consumer* or *open consumer*.

* **Closed Argument Consumer:** A const type consumer that is a closed generic. Also called *closed arg consumer* or *closed consumer*.

* **Const Type Union** - A const type argument that can represent multiple types.

## See Also

* [Overview](https://github.com/zacharylayne/ConstTypeArgs/blob/master/Documentation/README.md)
