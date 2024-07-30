using ConstTypeArgs.Core;

#pragma warning disable IDE1006 // Naming Styles
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

namespace ConstTypeArgs.Delegates.Funcs;

/// <summary>
/// The <see cref="K_FuncArray{TResult}"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;System.Func&lt;TResult&gt;[]&gt;</c> derived type.
/// </summary>
/// <typeparam name="TResult">
/// The type of the result.
/// </typeparam>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.func-1">
/// System.Func&lt;TResult&gt;</seealso>
public interface K_FuncArray<TResult> : K_Array<Func<TResult>>;

/// <summary>
/// The <see cref="FuncArray{TResult, K}"/> class provides an argument provider that
/// wraps the
/// <see href="https://learn.microsoft.com/dotnet/api/system.func-1">
/// System.Func&lt;TResult&gt;</see> array from another argument provider.
/// </summary>
/// <typeparam name="TResult">
/// The type of the result.
/// </typeparam>
/// <typeparam name="K">
/// The type of argument provider containing the value to wrap.
/// </typeparam>
/// <remarks>
/// This class can be useful when creating domain-specific argument providers,
/// such as default values, when an argument provider's value needs to be
/// wrapped for use in a different context.
/// </remarks>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.func-1">
/// System.Func&lt;TResult&gt;</seealso>
public abstract class FuncArray<TResult, K> : K<Func<TResult>[], K>, K_FuncArray<TResult>
    where K : K_FuncArray<TResult>
{ public static Func<TResult>[] Value => K.Value; }

/// <summary>
/// The <see cref="K_FuncArray{T, TResult}"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;System.Func&lt;T, TResult&gt;[]&gt;</c> derived type.
/// </summary>
/// <typeparam name="T">
/// The type of input parameter.
/// </typeparam>
/// <typeparam name="TResult">
/// The type of the result.
/// </typeparam>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.func-2">
/// System.Func&lt;T, TResult&gt;</seealso>
public interface K_FuncArray<in T, TResult>
    : K_Array<Func<T, TResult>>;

/// <summary>
/// The <see cref="FuncArray{T, TResult, K}"/> class provides an argument provider that
/// wraps the
/// <see href="https://learn.microsoft.com/dotnet/api/system.func-2">
/// System.Func&lt;T, TResult&gt;</see> array from another argument provider.
/// </summary>
/// <typeparam name="T">
/// The type of input parameter.
/// </typeparam>
/// <typeparam name="TResult">
/// The type of the result.
/// </typeparam>
/// <typeparam name="K">
/// The type of argument provider containing the value to wrap.
/// </typeparam>
/// <remarks>
/// This class can be useful when creating domain-specific argument providers,
/// such as default values, when an argument provider's value needs to be
/// wrapped for use in a different context.
/// </remarks>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.func-2">
/// System.Func&lt;T1, TResult&gt;</seealso>
public abstract class FuncArray<T, TResult, K>
    : K<Func<T, TResult>[], K>, K_FuncArray<T, TResult>
    where K : K_FuncArray<T, TResult>
{ public static Func<T, TResult>[] Value => K.Value; }

/// <summary>
/// The <see cref="K_FuncArray{T1, T2, TResult}"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;System.Func&lt;T1, T2, TResult&gt;[]&gt;</c> derived type.
/// </summary>
/// <typeparam name="T1">
/// The type of the first input parameter.
/// </typeparam>
/// <typeparam name="T2">
/// The type of the second input parameter.
/// </typeparam>
/// <typeparam name="TResult">
/// The type of the result.
/// </typeparam>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.func-3">
/// System.Func&lt;T1, T2, TResult&gt;</seealso>
public interface K_FuncArray<in T1, in T2, TResult>
    : K_Array<Func<T1, T2, TResult>>;

/// <summary>
/// The <see cref="FuncArray{T1, T2, TResult, K}"/> class provides an argument provider that
/// wraps the
/// <see href="https://learn.microsoft.com/dotnet/api/system.func-3">
/// System.Func&lt;T1, T2, TResult&gt;</see> array from another argument provider.
/// </summary>
/// <typeparam name="T1">
/// The type of the first input parameter.
/// </typeparam>
/// <typeparam name="T2">
/// The type of the second input parameter.
/// </typeparam>
/// <typeparam name="TResult">
/// The type of the result.
/// </typeparam>
/// <typeparam name="K">
/// The type of argument provider containing the value to wrap.
/// </typeparam>
/// <remarks>
/// This class can be useful when creating domain-specific argument providers,
/// such as default values, when an argument provider's value needs to be
/// wrapped for use in a different context.
/// </remarks>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.func-3">
/// System.Func&lt;T1, T2, TResult&gt;</seealso>
public abstract class FuncArray<T1, T2, TResult, K>
    : K<Func<T1, T2, TResult>[], K>, K_FuncArray<T1, T2, TResult>
    where K : K_FuncArray<T1, T2, TResult>
{ public static Func<T1, T2, TResult>[] Value => K.Value; }

/// <summary>
/// The <see cref="K_FuncArray{T1, T2, T3, TResult}"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;System.Func&lt;T1, T2, T3, TResult&gt;[]&gt;</c> derived type.
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
/// The type of the result.
/// </typeparam>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.func-4">
/// System.Func&lt;T1, T2, T3, TResult&gt;</seealso>
public interface K_FuncArray<in T1, in T2, in T3, TResult>
    : K_Array<Func<T1, T2, T3, TResult>>;

/// <summary>
/// The <see cref="FuncArray{T1, T2, T3, TResult, K}"/> class provides an argument provider that
/// wraps the
/// <see href="https://learn.microsoft.com/dotnet/api/system.func-4">
/// System.Func&lt;T1, T2, T3, TResult&gt;</see> array from another argument provider.
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
/// The type of the result.
/// </typeparam>
/// <typeparam name="K">
/// The type of argument provider containing the value to wrap.
/// </typeparam>
/// <remarks>
/// This class can be useful when creating domain-specific argument providers,
/// such as default values, when an argument provider's value needs to be
/// wrapped for use in a different context.
/// </remarks>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.func-4">
/// System.Func&lt;T1, T2, T3, TResult&gt;</seealso>
public abstract class FuncArray<T1, T2, T3, TResult, K>
    : K<Func<T1, T2, T3, TResult>[], K>, K_FuncArray<T1, T2, T3, TResult>
    where K : K_FuncArray<T1, T2, T3, TResult>
{ public static Func<T1, T2, T3, TResult>[] Value => K.Value; }

/// <summary>
/// The <see cref="K_FuncArray{T1, T2, T3, T4, TResult}"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;System.Func&lt;T1, T2, T3, T4, TResult&gt;[]&gt;</c> derived type.
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
/// The type of the result.
/// </typeparam>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.func-5">
/// System.Func&lt;T1, T2, T3, T4, TResult&gt;</seealso>
public interface K_FuncArray<in T1, in T2, in T3, in T4, TResult>
    : K_Array<Func<T1, T2, T3, T4, TResult>>;

/// <summary>
/// The <see cref="FuncArray{T1, T2, T3, T4, TResult, K}"/> class provides an argument provider that
/// wraps the
/// <see href="https://learn.microsoft.com/dotnet/api/system.func-5">
/// System.Func&lt;T1, T2, T3, T4, TResult&gt;</see> array from another argument provider.
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
/// The type of the result.
/// </typeparam>
/// <typeparam name="K">
/// The type of argument provider containing the value to wrap.
/// </typeparam>
/// <remarks>
/// This class can be useful when creating domain-specific argument providers,
/// such as default values, when an argument provider's value needs to be
/// wrapped for use in a different context.
/// </remarks>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.func-5">
/// System.Func&lt;T1, T2, T3, T4, TResult&gt;</seealso>
public abstract class FuncArray<T1, T2, T3, T4, TResult, K>
    : K<Func<T1, T2, T3, T4, TResult>[], K>, K_FuncArray<T1, T2, T3, T4, TResult>
    where K : K_FuncArray<T1, T2, T3, T4, TResult>
{ public static Func<T1, T2, T3, T4, TResult>[] Value => K.Value; }
