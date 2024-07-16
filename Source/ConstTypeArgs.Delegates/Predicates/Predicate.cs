using ConstTypeArgs.Core;

#pragma warning disable IDE1006 // Naming Styles
#pragma warning disable CS1591  // Missing XML comment for publicly visible type or member

namespace ConstTypeArgs.Delegates.Predicates;

/// <summary>
/// The <see cref="K_Predicate{T}"/> interface  provides a more explicit
/// <c>IConstTypeArg&lt;Predicate&lt;T&gt;&gt;</c> derived type.
/// </summary>
/// <typeparam name="T">
/// The type of the input parameter of the predicate.
/// </typeparam>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.predicate-1">
/// System.Predicate&lt;T&gt;</seealso>
public interface K_Predicate<in T>
    : K_Delegate<Predicate<T>>;

/// <summary>
/// The <see cref="K_PredicateArray{T}"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;Predicate&lt;T&gt;[]&gt;</c> type.
/// </summary>
/// <typeparam name="T">
/// The type of the predicate's input.
/// </typeparam>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.predicate">
/// System.Predicate</seealso>
/// <seealso cref="K_Predicate{T}"/>
public interface K_PredicateArray<in T>
    : K_Array<Predicate<T>>;

/// <summary>
/// The <see cref="Predicate{T, K}"/> class provides an argument provider that
/// wraps the
/// <see href="https://learn.microsoft.com/dotnet/api/system.predicate">
/// System.Predicate</see> value from another argument provider.
/// </summary>
/// <typeparam name="T">
/// The type of the predicate's input.
/// </typeparam>
/// <typeparam name="K">
/// The type of argument provider containing the value to wrap.
/// </typeparam>
/// <remarks>
/// This class can be useful when creating domain-specific argument providers,
/// such as default values, when an argument provider's value needs to be
/// wrapped for use in a different context.
/// </remarks>
public abstract class Predicate<T, K> : K<Predicate<T>, K>, K_Predicate<T>
    where K : K_Predicate<T>
{ public static Predicate<T> Value => K.Value; }

/// <summary>
/// The <see cref="PredicateArray{T, K}"/> class provides an argument provider that
/// wraps the
/// <see href="https://learn.microsoft.com/dotnet/api/system.predicate">
/// System.Predicate</see> array from another argument provider.
/// </summary>
/// <typeparam name="T">
/// The type of the predicate's input.
/// </typeparam>
/// <typeparam name="K">
/// The type of argument provider containing the array to wrap.
/// </typeparam>
/// <remarks>
/// This class can be useful when creating domain-specific argument providers,
/// such as default values, when an argument provider's value needs to be
/// wrapped for use in a different context.
/// </remarks>
public abstract class PredicateArray<T, K> : K<Predicate<T>[], K>, K_PredicateArray<T>
    where K : K_PredicateArray<T>
{ public static Predicate<T>[] Value => K.Value; }
