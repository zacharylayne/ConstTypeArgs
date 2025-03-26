# Buffer Sample

This sample demonstrates how to use the **Const Type Args** framework to configure and specialize generic types using <abbr title="Types that 'pass' values to generics through generic type parameteres">const type args</abbr>. In this example, buffers are defined with compile–time–like constant values that determine their size and behavior, allowing for static polymorphism similar to [C++ template specialization](https://en.cppreference.com/w/cpp/language/template_specialization).

**Key features include:**

- **Type-Safe Buffer Sizing:**  
  The `SimpleBuffer<SIZE>` class uses a const type argument *(e.g. `_5`, `_32`)* to set the buffer size, ensuring that the buffer's length is determined through compile-time types.

- **Enhanced Buffer Functionality:**  
  The `BufferEx<SizeArg, IsResizableArg, MaxSizeArg>` class extends `SimpleBuffer` by adding configuration for resizability and maximum size. This extra layer lets you control behavior statically; if a buffer is defined as not resizable, attempts to resize it will be rejected.

- **Static Configuration & Optimization:**  
  With const type arguments, each closed generic *(like `SimpleBuffer<_5>` &amp; `SimpleBuffer<_32>`)* is a distinct type. This means that configuration values are embedded in the type itself, enabling potential compiler and JIT optimizations and reducing runtime overhead.

<br>

**Example Usage:**

```csharp
using ConstTypeArgs.Bools;
using ConstTypeArgs.Ints;
using Samples.Buffer;

using static Samples.SampleConsoleHelper;

// Create a buffer with a fixed size (_5).
var smallBuffer = new SimpleBuffer<_5>();
smallBuffer.Fill(1);
smallBuffer.Print();

// Create a buffer with a larger fixed size (_32).
var largerBuffer = new SimpleBuffer<_32>();
largerBuffer.Fill(2);
largerBuffer.Print();

// Create a resizable buffer with an initial size (_16), resizable flag (True),
// and a maximum size (_64).
var resizableBuffer = new BufferEx<_16, True, _64>();
resizableBuffer.Fill(3);
resizableBuffer.Print();

// Resize the resizable buffer and update its contents.
resizableBuffer.Resize(32);
resizableBuffer.Fill(4);
resizableBuffer.Print();

// Additional resizing attempts demonstrating validation.
resizableBuffer.Resize(64);
resizableBuffer.Fill(5);
resizableBuffer.Print();

// Cannot resize beyond maximum: _64
resizableBuffer.Resize(128);
resizableBuffer.Fill(6);
resizableBuffer.Print();

WaitForKeyPress();
```

<br>

This sample shows how const type arguments let you configure generic types in a clean, type-safe way while enabling static polymorphism. Each buffer instance is tailored by the constant-like values the const type arguments provide.

<br>

## Other samples

[**Units of Measure**](https://github.com/zacharylayne/ConstTypeArgs/tree/master/Samples/Samples.UnitsOfMeasure) - A simple implementation of units of measure using const type args.
