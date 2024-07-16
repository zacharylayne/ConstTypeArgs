using ConstTypeArgs.Core;

#pragma warning disable IDE1006 // Naming Styles
#pragma warning disable CS1591  // Missing XML comment for publicly visible type or member

namespace ConstTypeArgs.Delegates.Comparisons;

/// <summary>
/// The <see cref="K_Comparison{T}"/> interface  provides a more explicit
/// <c>IConstTypeArg&lt;Comparison&lt;T&gt;&gt;</c> derived type.
/// </summary>
/// <typeparam name="T">
/// The type of objects to compare.
/// </typeparam>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.comparison-1">
/// System.Comparison&lt;T&gt;</seealso>
public interface K_Comparison<in T>
    : K_Delegate<Comparison<T>>;

/// <summary>
/// The <see cref="K_ComparisonArray{T}"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;Comparison&lt;T&gt;[]&gt;</c> type.
/// </summary>
/// <typeparam name="T">
/// The type of objects to compare.
/// </typeparam>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.comparison-1">
/// System.Comparison&lt;T&gt;</seealso>
/// <seealso cref="K_Comparison{T}"/>
public interface K_ComparisonArray<in T>
    : K_Array<Comparison<T>>;

/// <summary>
/// The <see cref="Comparison{T, K}"/> class provides an argument provider that
/// wraps the
/// <see href="https://learn.microsoft.com/dotnet/api/system.comparison-1">
/// System.Comparison&lt;T&gt;</see> value from another argument provider.
/// </summary>
/// <typeparam name="T">
/// The type of objects to compare.
/// </typeparam>
/// <typeparam name="K">
/// The type of argument provider containing the value to wrap.
/// </typeparam>
/// <remarks>
/// This class can be useful when creating domain-specific argument providers,
/// such as default values, when an argument provider's value needs to be
/// wrapped for use in a different context.
/// </remarks>
public abstract class Comparison<T, K> : K<Comparison<T>, K>, K_Comparison<T>
    where K : K_Comparison<T>
{ public static Comparison<T> Value => K.Value; }

/// <summary>
/// The <see cref="ComparisonArray{T, K}"/> class provides an argument provider that
/// wraps the
/// <see href="https://learn.microsoft.com/dotnet/api/system.comparison-1">
/// System.Comparison&lt;T&gt;</see> array from another argument provider.
/// </summary>
/// <typeparam name="T">
/// The type of objects to compare.
/// </typeparam>
/// <typeparam name="K">
/// The type of argument provider containing the array to wrap.
/// </typeparam>
/// <remarks>
/// This class can be useful when creating domain-specific argument providers,
/// such as default values, when an argument provider's value needs to be
/// wrapped for use in a different context.
/// </remarks>
public abstract class ComparisonArray<T, K> : K<Comparison<T>[], K>, K_ComparisonArray<T>
    where K : K_ComparisonArray<T>
{ public static Comparison<T>[] Value => K.Value; }