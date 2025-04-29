# Glossary

This page provides a glossary of terms used throughout the ConstTypeArgs documentation.

## Common Terms

The terms in this section are used throughout the ConstTypeArgs documentation and are essential to understanding the framework.

* **Const Type Argument:**  A type that uses generic parameters to "pass" static values to generics. Every const type argument directly or indirectly implements [`IConstTypeArg<T>`](https://github.com/zacharylayne/ConstTypeArgs/blob/master/Source/ConstTypeArgs.Core/IConstTypeArg.cs). The term const type argument can be interchangeable with the value they hold. If more clarity is needed, the terms *argument provider/arg provider* and *const type value* are used. ***VALUES SHOULD ALWAYS BE IMMUTABLE***. Also referred to as *const type arg*.

* **Const Type Value:**  A more specific term for *const type arguments* which refers to a const type argument's value. ***VALUES SHOULD ALWAYS BE IMMUTABLE***.
 
* **Argument Provider:** Concrete const types that provide a *const type value*. Also called *arg provider*.

* **Const Type:** Any type that implements `IConstTypeArg<T>`, including concrete implementations, interfaces, and abstract classes.

* **Const Type Parameter:** A generic parameter that const type arguments "pass" values through. Every const type parameter is constrained to a *const type* *(i.e. any type that implements `IConstTypeArg<T>`)*. Also called *const type param*.

* **Argument Consumer:** A generic type or method with one or more const type parameters. Also called *arg consumer*.

* **Argument Holder:** A const type argument that wraps other const type arguments. Also referred to as *arg holder*. All argument holders directly or indirectly implement [`K<T, TArg>`](https://github.com/zacharylayne/ConstTypeArgs/blob/master/Source/ConstTypeArgs.Core/K.cs). Argument holders can be used to create domain-specific const type arguments for minimums, maximums, defaults, and more.

* **Argument Discard:** A const type argument that is used to signify the absence. Also called *arg discard*. These can be used in a very similar manner to C# 7.0's discard feature. In ConstTypeArgs, these types are usually named `__` and can implement multiple const type interfaces providing either `default` or `null` values to increase flexibility.

## See Also

* [README](https://github.com/zacharylayne/ConstTypeArgs/blob/master/README.md)
