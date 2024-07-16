#pragma warning disable CS1591  // Missing XML comment for publicly visible type or member

namespace ConstTypeArgs.Delegates.Funcs;

/// <summary>
/// The <see cref="Function{TResult, K}"/> class provides an argument provider that
/// wraps the
/// <see href="https://learn.microsoft.com/dotnet/api/system.func-1">
/// System.Func&lt;TResult&gt;</see> value from another argument provider.
/// </summary>
/// <typeparam name="TResult">
/// The type of output.
/// </typeparam>
/// <typeparam name="K">
/// The type of argument provider containing the value to wrap.
/// </typeparam>
/// <remarks>
/// This class can be useful when creating domain-specific argument providers,
/// such as default values, when an argument provider's value needs to be
/// wrapped for use in a different context.
/// </remarks>
public abstract class Function<TResult, K>
    : K<Func<TResult>, K>, K_Function<TResult>
    where K : K_Function<TResult>
{ public static Func<TResult> Value => K.Value; }

/// <summary>
/// The <see cref="Function{T, TResult, K}"/> class provides an argument provider that
/// wraps the
/// <see href="https://learn.microsoft.com/dotnet/api/system.func-2">
/// System.Func&lt;T, TResult&gt;</see> value from another argument provider.
/// </summary>
/// <typeparam name="T">
/// The type of input parameter.
/// </typeparam>
/// <typeparam name="TResult">
/// The type of output.
/// </typeparam>
/// <typeparam name="K">
/// The type of argument provider containing the value to wrap.
/// </typeparam>
/// <remarks>
/// This class can be useful when creating domain-specific argument providers,
/// such as default values, when an argument provider's value needs to be
/// wrapped for use in a different context.
/// </remarks>
public abstract class Function<T, TResult, K>
    : K<Func<T, TResult>, K>, K_Function<T, TResult>
    where K : K_Function<T, TResult>
{ public static Func<T, TResult> Value => K.Value; }

/// <summary>
/// The <see cref="Function{T1, T2, TResult, K}"/> class provides an argument provider that
/// wraps the
/// <see href="https://learn.microsoft.com/dotnet/api/system.func-3">
/// System.Func&lt;T1, T2, TResult&gt;</see> value from another argument provider.
/// </summary>
/// <typeparam name="T1">
/// The type of the first input parameter.
/// </typeparam>
/// <typeparam name="T2">
/// The type of the second input parameter.
/// </typeparam>
/// <typeparam name="TResult">
/// The type of output.
/// </typeparam>
/// <typeparam name="K">
/// The type of argument provider containing the value to wrap.
/// </typeparam>
/// <remarks>
/// This class can be useful when creating domain-specific argument providers,
/// such as default values, when an argument provider's value needs to be
/// wrapped for use in a different context.
/// </remarks>
public abstract class Function<T1, T2, TResult, K>
    : K<Func<T1, T2, TResult>, K>, K_Function<T1, T2, TResult>
    where K : K_Function<T1, T2, TResult>
{ public static Func<T1, T2, TResult> Value => K.Value; }

/// <summary>
/// The <see cref="Function{T1, T2, T3, TResult, K}"/> class provides an argument provider that
/// wraps the
/// <see href="https://learn.microsoft.com/dotnet/api/system.func-4">
/// System.Func&lt;T1, T2, T3, TResult&gt;</see> value from another argument provider.
/// </summary>
/// <typeparam name="T1">
/// The type of the first input parameter.
/// </typeparam>
/// <typeparam name="T2">
/// The type of the second input parameter.
/// </typeparam>
/// <typeparam name="T3">
/// The type of the third input parameter.
/// </typeparam>
/// <typeparam name="TResult">
/// The type of output.
/// </typeparam>
/// <typeparam name="K">
/// The type of argument provider containing the value to wrap.
/// </typeparam>
/// <remarks>
/// This class can be useful when creating domain-specific argument providers,
/// such as default values, when an argument provider's value needs to be
/// wrapped for use in a different context.
/// </remarks>
public abstract class Function<T1, T2, T3, TResult, K>
    : K<Func<T1, T2, T3, TResult>, K>, K_Function<T1, T2, T3, TResult>
    where K : K_Function<T1, T2, T3, TResult>
{ public static Func<T1, T2, T3, TResult> Value => K.Value; }

/// <summary>
/// The <see cref="Function{T1, T2, T3, T4, TResult, K}"/> class provides an argument provider that
/// wraps the
/// <see href="https://learn.microsoft.com/dotnet/api/system.func-5">
/// System.Func&lt;T1, T2, T3, T4, TResult&gt;</see> value from another argument provider.
/// </summary>
/// <typeparam name="T1">
/// The type of the first input parameter.
/// </typeparam>
/// <typeparam name="T2">
/// The type of the second input parameter.
/// </typeparam>
/// <typeparam name="T3">
/// The type of the third input parameter.
/// </typeparam>
/// <typeparam name="T4">
/// The type of the fourth input parameter.
/// </typeparam>
/// <typeparam name="TResult">
/// The type of output.
/// </typeparam>
/// <typeparam name="K">
/// The type of argument provider containing the value to wrap.
/// </typeparam>
/// <remarks>
/// This class can be useful when creating domain-specific argument providers,
/// such as default values, when an argument provider's value needs to be
/// wrapped for use in a different context.
/// </remarks>
public abstract class Function<T1, T2, T3, T4, TResult, K>
    : K<Func<T1, T2, T3, T4, TResult>, K>, K_Function<T1, T2, T3, T4, TResult>
    where K : K_Function<T1, T2, T3, T4, TResult>
{ public static Func<T1, T2, T3, T4, TResult> Value => K.Value; }
