# Delegate Const Type Arguments

**Const type arguments** (also called *const type args*) are types used to "pass" static values to generics through type parameters. These values can be used in static contexts, such as static constructors, static fields, and static methods. This can provide enhanced type safety, static polymorphism, performance improvements, and more.

&nbsp;

 You can use types in the `ConstTypeArgs.Delegates` namespaces for passing delegates as const type arguments.

 Usage scenarios include:

 * Static configuration,
 * Eliminating unnecessary instance constructors,
 * "Passing" values to type initializers,
 * and more.
