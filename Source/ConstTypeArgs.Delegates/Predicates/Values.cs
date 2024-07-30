// Ignore Spelling: Pred
using ConstTypeArgs.Delegates.Logical;

#pragma warning disable CS1591  // Missing XML comment for publicly visible type or member

namespace ConstTypeArgs.Delegates.Predicates;

/// <summary>
/// The <see cref="AlwaysTrue{T}"/> readonly struct provides a const type argument equal to
/// a predicate which always returns <see langword="true"/>.
/// </summary>
/// <typeparam name="T">
/// The type of the input value.
/// </typeparam>
/// <seealso cref="AlwaysFalse{T}"/>
public readonly struct AlwaysTrue<T> : K_Predicate<T>
{ public static Predicate<T> Value => static _ => true; }

/// <summary>
/// The <see cref="AlwaysFalse{T}"/> readonly struct provides a const type argument equal to
/// a predicate which always returns <see langword="false"/>.
/// </summary>
/// <typeparam name="T">
/// The type of the input value.
/// </typeparam>
/// <seealso cref="AlwaysTrue{T}"/>
public readonly struct AlwaysFalse<T> : K_Predicate<T>
{ public static Predicate<T> Value => static _ => false; }

/// <summary>
/// The <see cref="IsNotNull{T}"/> readonly struct provides a const type argument equal to
/// a predicate that checks if the input value is not <see langword="null"/>.
/// </summary>
/// <typeparam name="T">
/// The type of the input value.
/// </typeparam>
/// <seealso cref="IsNull{T}"/>
public readonly struct IsNotNull<T> : K_Predicate<T>
{ public static Predicate<T> Value => static arg => arg != null; }

/// <summary>
/// The <see cref="IsNull{T}"/> readonly struct provides a const type argument equal to
/// a predicate that checks if the input value is <see langword="null"/>.
/// </summary>
/// <typeparam name="T">
/// The type of the input value.
/// </typeparam>
/// <seealso cref="IsNotNull{T}"/>
public readonly struct IsNull<T> : K_Predicate<T>
{ public static Predicate<T> Value => static arg => arg == null; }

/// <summary>
/// The <see cref="Not{T, KPred}"/> const type argument provides a predicate that is
/// that negates the result of another the
/// <see href="https://learn.microsoft.com/dotnet/api/system.predicate-1">Predicate&lt;T&gt;</see>
/// const type argument <typeparamref name="KPred"/>.
/// </summary>
/// <typeparam name="T">
/// The input's type.
/// </typeparam>
/// <typeparam name="KPred">
/// The predicate const type argument to negate.
/// </typeparam>
/// <seealso cref="AND{T, KPred1, KPred2}"/>
/// <seealso cref="OR{T, KPred1, KPred2}"/>
/// <seealso cref="XOR{T, KPred1, KPred2}"/>
/// <seealso cref="NAND{T, KPred1, KPred2}"/>
/// <seealso cref="NOR{T, KPred1, KPred2}"/>
/// <seealso cref="XNOR{T, KPred1, KPred2}"/>
/// <seealso cref="IMPLY{T, KPred1, KPred2}"/>
/// <seealso cref="NIMPLY{T, KPred1, KPred2}"/>
public readonly struct Not<T, KPred> : K_Predicate<T> where KPred : K_Predicate<T>
{ public static Predicate<T> Value => static arg => !KPred.Value(arg); }
