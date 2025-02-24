# **Static Polymorphism with Const Type Args**

## **Overview**

In traditional OOP polymorphism, behavior changes at *runtime* - you have a base class, multiple derived classes, and virtual methods that dispatch to the correct implementation. By contrast, **static polymorphism** is about specializing behavior *before or during compilation* based on the generic type arguments. 

With the **ConstTypeArgs** framework, each "const type argument" is a distinct type, and the compiler treats each closed generic (e.g., `MyClass<_16>`, `MyClass<_512>`) as a *separate* specialized type. This often yields a **performance** benefit because the JIT (Just-In-Time compiler) can optimize each specialization differently. It also means your code can pick different *compile-time paths* based on the "constant" embedded in the type.

---

## **What Does “Switching on Const Type Arguments at Compile Time” Mean?**

1. **Distinct Generic Types**
   When you create something like `Buffer<_16>` vs. `Buffer<_512>`, the compiler effectively creates **two separate** instantiations of `Buffer<TArg>`. Even though the base code is the same, each specialization can be optimized differently because `_16` and `_512` are **different** types.

1. **Optional Code Specialization**
   - You can write methods that choose different code paths based on the *type* of your const type argument.  
   - The "switch" can be literal (e.g., `switch` statements on `TArg.Value`) or structural (e.g., `if (typeof(TArg) == typeof(_16))`).
   - Since each closed generic is distinct, the compiler can inline or prune unused branches if it can determine the outcome at compile time or JIT time.

1. **No Traditional Inheritance Needed**
   - You don’t rely on an inheritance hierarchy and virtual overrides. Instead, you rely on the *generic type argument* (and its `Value`) to drive behavior.
   - This leads to simpler code in cases where you just need different “flavors” of logic keyed off a single constant.

---

## **Example: Specializing Behavior via Const Type Args**

Let’s illustrate with a simplified example: a generic "resizer" class that picks different resizing strategies based on the numeric value of `TSize` - like `_16`, `_512`, or `_1024`. We’ll show two ways to "switch" on the const type argument.

### **1. Switch on `Value` at JIT Time**

```csharp
using ConstTypeArgs;

public class Resizer<TSize> 
    where TSize : IConstTypeArg<int>
{
    public static int Resize(int currentSize)
    {
        // The JIT can optimize this switch because TSize.Value is known at runtime.
        return TSize.Value switch
        {
            <= 16  => currentSize + 8,
            <= 512 => currentSize + 128,
            _      => currentSize * 2
        };
    }
}

// Example usage
var small   = Resizer<_16>.Resize(8);   // Likely 16
var medium  = Resizer<_512>.Resize(256); 
var larger  = Resizer<_1024>.Resize(512);
```

Here, **each** call site like `Resizer<_16>.Resize(8)` or `Resizer<_512>.Resize(256)` is a *distinct compiled form*. Although the switch runs at runtime, in practice, once JITted, the cost might be negligible for each specialized type.

### **2. “Type Switching” for Hardcoded Specializations**

You can also switch on *the type itself* to choose entirely separate code paths. This can be done with `typeof(TSize)` checks or pattern matching, though it’s less common. Here’s a minimal snippet:

```csharp
public class SpecializedLogic<TSize>
    where TSize : IConstTypeArg<int>
{
    public static void DoWork()
    {
        if (typeof(TSize) == typeof(_16))
        {
            // Possibly the JIT or compiler sees this as a specialized branch
            Console.WriteLine("Specialization for size 16!");
        }
        else if (typeof(TSize) == typeof(_512))
        {
            Console.WriteLine("Specialization for size 512!");
        }
        else
        {
            Console.WriteLine($"Generic handling for size: {TSize.Value}");
        }
    }
}

// Example usage
SpecializedLogic<_16>.DoWork();   // "Specialization for size 16!"
SpecializedLogic<_512>.DoWork();  // "Specialization for size 512!"
SpecializedLogic<_1024>.DoWork(); // "Generic handling for size: 1024"
```

The advantage is that the code can be very explicit about unique branches. The downside is the extra steps you take to handle new specializations—imagine adding a check for `_2048` in the future.

---

## **Why Is This Powerful?**

1. **Performance**
   Each specialized instantiation can be **inlined** or optimized. For numeric-based constants, the JIT can optimize away code paths that it deems irrelevant for that specific constant.

1. **Clarity**
   Instead of weaving through inheritance hierarchies, your specialization is driven by the "constant type". So, code becomes more direct: "I want the version that’s `_512` for my buffer. That’s it."

1. **Flexibility**
   - You can switch on either *the static value* (`TSize.Value`) or *the static type* (`typeof(TSize)`), or even both.
   - Each approach has trade-offs in terms of discoverability and runtime overhead, but you have freedom to pick whichever best fits your scenario.

1. **Reduced Boilerplate**
   - Instead of creating multiple subclasses with repeated logic, you can keep one generic class and differentiate purely by the const type argument.
   - This is reminiscent of **C++ template specialization**, albeit done in a C#-friendly way.

---

## **When to Use Static Polymorphism**

- **Perf-Critical Code Paths**
  Where you want to avoid virtual dispatch overhead or rely on inlining for tight loops.
- **Compile-Time Guarantees**
  If you want the code to forcibly compile to distinct types for each “constant scenario” (like `_16` vs `_512`).  
- **Complex Domain-Driven Logic**
  Where each scenario is so different that you want clear separation of code paths yet prefer them all in a single generic or partial methods.

---

## **Summary**

Static polymorphism in the **ConstTypeArgs** framework leverages the fact that each const type argument (like `_16`, `_512`, `_1024`) is **its own type**. Consequently:

1. **You get distinct compiled specializations** for each usage, boosting both performance and clarity.
1. **You can “switch”** on the constant-like value or the type, shaping different behaviors for different "constants".
1. **You avoid typical runtime polymorphism overhead**, while still achieving specialized functionality for each scenario.
