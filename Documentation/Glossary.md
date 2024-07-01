# Glossary

**Const Type Arguments:**  Type arguments that are used to "pass" values to a generic and are accessible from within a static context. Values are meant to be literals or constants and ***SHOULD ALWAYS BE IMMUTABLE***.

**Const Types:** Types that inherit from a base interface, `IConst<TValue>`, which has a static abstract property `Value`. Concrete const types are known as *argument providers*.

**Argument Provider:** A concrete *const type* implementation that defines a static or constant value and can be used as type arguments for a generic. The values they provide ***SHOULD ALWAYS BE IMMUTABLE***.

**Const Type Parameters:** These are  type parameters in a generic type or method which are used to pass values (rather than just types) to the generic.

**Consumer Types:** Generics whose type parameter list contains one or more const type parameters. They are the structures that utilize the values const type arguments provide.

**Argument Consumers:** These are constructed generics which use one or more *const type arguments*. They consume the values provided by the argument providers, which they can access from within a static context.