# Const Type Arguments

**Const type arguments** (also called *const type args*) are types used to pass constant & static values to generics through type parameters. These values are available at compile-time and can be used in static contexts, such as static constructors, static fields, and static methods. This can mimic C++ [template specialization](https://en.cppreference.com/w/cpp/language/template_specialization), provide enhanced type safety, compile-time polymorphism, performance improvements, and more.

&nbsp;

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

&nbsp;

All const type arguments implement [`IConstTypeArg<T>`](/Source/ConstTypeArgs.Core/IConstTypeArg.cs) which contains a single member: the static abstract `Value` get-only property. From `IConstTypeArg<T>`, a foundation is built to make it easier to define const type arguments, strengthen type safety, and provide additional functionality such as domain-specific argument providers and union-like behavior.

Base interfaces include [`K_Array<out T>`](/Source/ConstTypeArgs.Core/Core/K_Array.cs), [`K_Class<out T>`](/Source/ConstTypeArgs.Core/Core/K_Class.cs), [`K_Delegate<out T>`](/Source/ConstTypeArgs.Core/Core/K_Delegate.cs), [`K_MulticastDelegate<out T>`](/Source/ConstTypeArgs.Core/Core/K_MulticastDelegate.cs), [`K_Enum<out T>`](/Source/ConstTypeArgs.Core/Core/K_Enum.cs), [`K_FloatingPoint<out T>`](/Source/ConstTypeArgs.Core/Core/K_FloatingPoint.cs), [`K_Integer<out T>`](/Source/ConstTypeArgs.Core/Core/K_Integer.cs), [`K_Number<out T>`](/Source/ConstTypeArgs.Core/Core/K_Number.cs), [`K_SignedNumber<out T>`](/Source/ConstTypeArgs.Core/Core/K_SignedNumber.cs), [`K_Struct<out T>`](/Source/ConstTypeArgs.Core/Core/K_Struct.cs), [`K_Unmanaged<out T>`](/Source/ConstTypeArgs.Core/Core/K_Unmanaged.cs), [`K_UnsignedNumber<out T>`](/Source/ConstTypeArgs.Core/Core/K_UnsignedNumber.cs), and [`K`](/Source/ConstTypeArgs.Core/K.cs).

&nbsp;

<details>

<summary><strong>Naming Conventions</strong></summary>

</br>

| Naming Convention | |
|:-------------------|-|
| `K_` Prefix | Argument type interfaces *(i.e. interfaces deriving from `IConstTypeArg<T>`)* are prefixed with `K_` to indicate that they, rather than define a contract, are the means to "pass" values via generic type parameters. The prefix refers to how `K` is used in mathematic formulas to denote an unknown constant value. |
| `_` Prefix | Many argument providers *(i.e. concrete types that implement `IConstTypeArg<T>`)* in ConstTypeArg libraries have the prefix `_` followed by a representation of their value *(e.g. _1024, _A, _Blue)*.
| [`__`](#__) Types| Argument types *(i.e. types deriving from or implementing `IConstTypeArg<T>`)* that implement [`__`](/Source/ConstTypeArgs.Core/Core/__.cs) are used as "discards" to indicate they lack a value. These types are simply named `__` and usually explicitly implement multiple arg type interfaces, allowing union-like functionality, and provide either `default` or `null` values. |

</details>

&nbsp;

----

## [`K`](/Source/ConstTypeArgs.Core/K.cs) & Domain-Specific Values

[`K<out T, TArg>`](/Source/ConstTypeArgs.Core/K.cs) is a special interface used to define *argument holders*, const type arguments that wrap other const type arguments. This allows domain-specific const type arguments for providing minimums, maximums, defaults, and other domain-specific values.

&nbsp;

***NOTE:** The examples below are not production-level code and only meant for demonstration purposes.*

<details>

<summary><strong>Defining Argument Holders</strong></summary>

Extending the previous examples, the following code demonstrates how to define argument holders. 

```csharp
using ConstTypeArgs;

// Bool<K> and Int<K> exist respectively in the ConstTypeArgs.Bools & ConstTypeArgs.Ints libraries.
public abstract class Bool<K> : K<bool, K>, IConstTypeArg<bool>
    where K : IConstTypeArg<bool>
{ public static bool Value => K.Value; }

public abstract class Int<K> : K<int, K>, IConstTypeArg<int>
    where K : IConstTypeArg<int>
{ public static int Value => K.Value; }

public abstract class DefaultResize : Bool<False>;
public abstract class CanResize     : Bool<True>;
public abstract class CannotResize  : Bool<False>;

public abstract class DefaultSize : Int<_32>;
public abstract class MinSize     : Int<_4>;
public abstract class MaxSize     : Int<_4096>;
```

</details>

<details>

<summary><strong>Using Argument Holders</strong></summary>

A modified `Buffer<T, TSize>` demonstrates how argument holders defined in the previous example could be used:

```csharp
public class Buffer<T, TSize, TCanResize>
    where TSize      : IConstTypeArg<int>
    where TCanResize : IConstTypeArg<bool>
{
    public T[] Data;

    static Buffer()
    {
        if (ValidateSize())
            Data = new T[TSize.Value];
        else
            Data = Array.Empty<T>();
            
        // Consider throwing an exception when validation fails.
        // This prevents the constructed type from ever initializing,
        // which might be desired behavior.
    }

    private static bool ValidateSize()
    {
        if (TSize.Value < MinSize.Value)
            Console.WriteLine($"The initialized buffer is smaller than the minimum allowed.");
            
        if (TSize.Value > MaxSize.Value) 
            Console.WriteLine($"The initialized buffer is larger than the maximum allowed.");
    }

    public void Resize<TNew>()
    {
        if (!TCanResize.Value || TNew.Value < MinSize.Value || TNew.Value > MaxSize.Value)
        {
            Console.WriteLine("The buffer cannot be resized!");
            return;
        }

        var temp = Data;
        Array.Resize(ref temp, TNew.Value);
        Data = temp;
    }
}

var verySmallBuffer = new Buffer<int, _2, DefaultResize>();
// verySmallBuffer.Data.Length == 0
// _2.Value is smaller than MinSize.Value (4).
// Data initialized to an empty array.

var smallBuffer = new Buffer<int, _32, CannotResize>();
// smallBuffer.Data.Length = 32

smallBuffer.Resize<_2048>();
// No op. Cannot resize.

var bigGrowableBuffer = new Buffer<int, _1024, CanResize>();
// bigGrowableBuffer.Data.Length = 1024

bigGrowableBuffer.Resize<_2048>();
// bigGrowableBuffer.Data.Length = 2048
// The Data array can be resized to a minimum of MinSize.Value (4)
// and to a maximum of MaxSize.Value (4096).
```

</details>

&nbsp;

----

## The [`__`](/Source/ConstTypeArgs.Core/Core/__.cs) Interface ("Discards")

The [`__`](/Source/ConstTypeArgs.Core/Core/__.cs) interface is a marker interface, but is implemented by *discard arguments*, const type arguments meant to indicate they are "discards" that provide no value. These types can implement multiple const type argument interfaces in order to provide union-like functionality.

----

# Available Libraries

## Core

[**ConstTypeArgs.Core**](/Source/ConstTypeArgs.Core)

**Installation:**
```
dotnet add package ConstTypeArgs.Core
```

## Data Types

[**ConstTypeArgs.Bools**](/Source/ConstTypeArgs.Bools)

<details>
<summary><strong>Installation</strong></summary>

</br>

```
dotnet add package ConstTypeArgs.Bools
```

</details>

[**ConstTypeArgs.Bytes**](/Source/ConstTypeArgs.Bytes)



<details>
<summary><strong>Installation</strong></summary>

</br>

```
dotnet add package ConstTypeArgs.Bytes
```

</details>

[**ConstTypeArgs.Chars**](/Source/ConstTypeArgs.Chars)

<details>
<summary><strong>Installation</strong></summary>

</br>

```
dotnet add package ConstTypeArgs.Chars
```

</details>

[**ConstTypeArgs.Decimals**](/Source/ConstTypeArgs.Decimals)

<details>
<summary><strong>Installation</strong></summary>

</br>

```
dotnet add package ConstTypeArgs.Decimals
```

</details>

[**ConstTypeArgs.Doubles**](/Source/ConstTypeArgs.Doubles)

<details>
<summary><strong>Installation</strong></summary>

</br>

```
dotnet add package ConstTypeArgs.Doubles
```

</details>

[**ConstTypeArgs.Floats**](/Source/ConstTypeArgs.Floats)

<details>
<summary><strong>Installation</strong></summary>

</br>

```
dotnet add package ConstTypeArgs.Floats
```

</details>

[**ConstTypeArgs.Halfs**](/Source/ConstTypeArgs.Halfs)

<details>
<summary><strong>Installation</strong></summary>

</br>

```
dotnet add package ConstTypeArgs.Halfs
```

</details>

[**ConstTypeArgs.Int128s**](/Source/ConstTypeArgs.Int128s)


<details>
<summary><strong>Installation</strong></summary>

</br>

```
dotnet add package ConstTypeArgs.Int128s
```

</details>

[**ConstTypeArgs.Ints**](/Source/ConstTypeArgs.Ints)


<details>
<summary><strong>Installation</strong></summary>

</br>

```
dotnet add package ConstTypeArgs.Ints
```

</details>

[**ConstTypeArgs.Longs**](/Source/ConstTypeArgs.Longs)


<details>
<summary><strong>Installation</strong></summary>

</br>

```
dotnet add package ConstTypeArgs.Longs
```

</details>

[**ConstTypeArgs.Nints**](/Source/ConstTypeArgs.Nints)


<details>
<summary><strong>Installation</strong></summary>

</br>

```
dotnet add package ConstTypeArgs.Nints
```

</details>

[**ConstTypeArgs.Nuints**](/Source/ConstTypeArgs.Nuints)


<details>
<summary><strong>Installation</strong></summary>

</br>

```
dotnet add package ConstTypeArgs.Nuints
```

</details>

[**ConstTypeArgs.Sbytes**](/Source/ConstTypeArgs.Sbytes)


<details>
<summary><strong>Installation</strong></summary>

</br>

```
dotnet add package ConstTypeArgs.Sbytes
```

</details>

[**ConstTypeArgs.Shorts**](/Source/ConstTypeArgs.Shorts)


<details>
<summary><strong>Installation</strong></summary>

</br>

```
dotnet add package ConstTypeArgs.Shorts
```

</details>

[**ConstTypeArgs.Strings**](/Source/ConstTypeArgs.Strings)


<details>
<summary><strong>Installation</strong></summary>

</br>

```
dotnet add package ConstTypeArgs.Strings
```

</details>

[**ConstTypeArgs.Types**](/Source/ConstTypeArgs.Types)

<details>
<summary><strong>Installation</strong></summary>

</br>

```
dotnet add package ConstTypeArgs.Types
```

</details>

[**ConstTypeArgs.UInt128s**](/Source/ConstTypeArgs.UInt128s)


<details>
<summary><strong>Installation</strong></summary>

</br>

```
dotnet add package ConstTypeArgs.UInt128s
```

</details>

[**ConstTypeArgs.Uints**](/Source/ConstTypeArgs.Uints)


<details>
<summary><strong>Installation</strong></summary>

</br>

```
dotnet add package ConstTypeArgs.Uints
```

</details>

[**ConstTypeArgs.Ulongs**](/Source/ConstTypeArgs.Ulongs)


<details>
<summary><strong>Installation</strong></summary>

</br>

```
dotnet add package ConstTypeArgs.Ulongs
```

</details>

[**ConstTypeArgs.Ushorts**](/Source/ConstTypeArgs.Ushorts)


<details>
<summary><strong>Installation</strong></summary>

</br>

```
dotnet add package ConstTypeArgs.Ushorts
```

</details>

## Additional

[**ConstTypeArgs.Console**](/Source/ConstTypeArgs.Console)

[**ConstTypeArgs.Delegates**](/Source/ConstTypeArgs.Delegates)

[**ConstTypeArgs.Delegates.Interlocked**](/Source/ConstTypeArgs.Delegates.Interlocked)

# Documentation

* [**Glossary**](/Documentation/Glossary.md)

# License
The ConstTypeArgs libraries are licensed under the MIT License. See the [LICENSE](LICENSE.txt) file for more details.
