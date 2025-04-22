# Process Runners - Const Type Arg Static Dependencies

**Const type arguments** (also called *const type args*) are types used to pass values to generics through type parameters. These values can be used in static contexts, such as static constructors, static fields, and static methods. This can provide enhanced type safety, compile-time polymorphism, performance improvements, and more.

 You can use types in the `ConstTypeArgs.ProcessRunners` namespace to define steps in a process runner. These steps can be used to create a pipeline of operations that can be executed in a specific order.

 Usage scenarios include:

* Defining a sequence of operations,
* Creating a workflow,
* Implementing a state machine,
* and more.

## What is a process runner?

A *process runner* is a type of <abbr title="A generic with with one or more type parameters constrained to or derived from IConstTypeArg&lt;T&gt;">arg consumer</abbr> that defines an ordered sequence of steps *(i.e. a process)*. Const type args called *operations* are used to define the steps that the process runner will execute in order. These operations can be as simple as a single method call, or as complex as a series of operations that depend on the results of previous steps.

## Example

 The following is a simple example to demonstrate how this works:

 ```csharp
using ConstTypeArgs.ProcessRunners;

...

```

Here's how you could define a an operation const type argument:

```csharp
...
```
