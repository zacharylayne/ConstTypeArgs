using ConstTypeArgs.Core;

#pragma warning disable IDE1006 // Naming Styles
#pragma warning disable CS1591  // Missing XML comment for publicly visible type or member
#pragma warning disable RCS1158 // Static member in generic type should use a type parameter

namespace ConstTypeArgs.Delegates.Actions;

/// <summary>
/// The <see cref="K_ActionArray"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;System.Action[]&gt;</c> derived type.
/// </summary>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.action">
/// Action</seealso>
public interface K_ActionArray
    : K_Array<Action>;

/// <summary>
/// The <see cref="ActionArray{K}"/> class provides an argument provider that
/// wraps the
/// <see href="https://learn.microsoft.com/dotnet/api/system.action">
/// System.Action</see> array from another argument provider.
/// </summary>
/// <typeparam name="K">
/// The type of argument provider containing the value to wrap.
/// </typeparam>
/// <remarks>
/// This class can be useful when creating domain-specific argument providers,
/// such as default values, when an argument provider's value needs to be
/// wrapped for use in a different context.
/// </remarks>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.action">
/// System.Action</seealso>
public abstract class ActionArray<K>
    : K<Action[], K>, K_ActionArray
    where K : K_ActionArray
{ public static Action[] Value => K.Value; }

/// <summary>
/// The <see cref="K_ActionArray{T}"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;System.Action&lt;T&gt;[]&gt;</c> derived type.
/// </summary>
/// <typeparam name="T">
/// The type of input parameter.
/// </typeparam>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.action-1">
/// System.Action&lt;T&gt;</seealso>
public interface K_ActionArray<in T>
    : K_Array<Action<T>>;

/// <summary>
/// The <see cref="ActionArray{T, K}"/> class provides an argument provider that
/// wraps the
/// <see href="https://learn.microsoft.com/dotnet/api/system.action-1">
/// System.Action&lt;T&gt;</see> array from another argument provider.
/// </summary>
/// <typeparam name="T">
/// The type of input parameter.
/// </typeparam>
/// <typeparam name="K">
/// The type of argument provider containing the value to wrap.
/// </typeparam>
/// <remarks>
/// This class can be useful when creating domain-specific argument providers,
/// such as default values, when an argument provider's value needs to be
/// wrapped for use in a different context.
/// </remarks>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.action-1">
/// System.Action&lt;T&gt;</seealso>
public abstract class ActionArray<T, K>
    : K<Action<T>[], K>, K_ActionArray<T>
    where K : K_ActionArray<T>
{ public static Action<T>[] Value => K.Value; }

/// <summary>
/// The <see cref="K_ActionArray{T1, T2}"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;System.Action&lt;T1, T2&gt;[]&gt;</c> derived type.
/// </summary>
/// <typeparam name="T1">
/// The type of the first input parameter.
/// </typeparam>
/// <typeparam name="T2">
/// The type of the second input parameter.
/// </typeparam>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.action-2">
/// System.Action&lt;T1, T2&gt;</seealso>
public interface K_ActionArray<in T1, in T2>
    : K_Array<Action<T1, T2>>;

/// <summary>
/// The <see cref="ActionArray{T1, T2, K}"/> class provides an argument provider that
/// wraps the
/// <see href="https://learn.microsoft.com/dotnet/api/system.action-2">
/// System.Action&lt;T1, T2, T3&gt;</see> array from another argument provider.
/// </summary>
/// <typeparam name="T1">
/// The type of the first input parameter.
/// </typeparam>
/// <typeparam name="T2">
/// The type of the second input parameter.
/// </typeparam>
/// <typeparam name="K">
/// The type of argument provider containing the value to wrap.
/// </typeparam>
/// <remarks>
/// This class can be useful when creating domain-specific argument providers,
/// such as default values, when an argument provider's value needs to be
/// wrapped for use in a different context.
/// </remarks>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.action-2">
/// System.Action&lt;T1, T2&gt;</seealso>
public abstract class ActionArray<T1, T2, K>
    : K<Action<T1, T2>[], K>, K_ActionArray<T1, T2>
    where K : K_ActionArray<T1, T2>
{ public static Action<T1, T2>[] Value => K.Value; }

/// <summary>
/// The <see cref="K_ActionArray{T1,T2,T3}"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;System.Action&lt;T1, T2, T3&gt;[]&gt;</c> derived type.
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
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.action-3">
/// System.Action&lt;T1, T2, T3&gt;</seealso>
public interface K_ActionArray<in T1, in T2, in T3>
    : K_Array<Action<T1, T2, T3>>;

/// <summary>
/// The <see cref="ActionArray{T1, T2, T3, K}"/> class provides an argument provider that
/// wraps the
/// <see href="https://learn.microsoft.com/dotnet/api/system.action-3">
/// System.Action&lt;T1, T2, T3&gt;</see> array from another argument provider.
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
/// <typeparam name="K">
/// The type of argument provider containing the value to wrap.
/// </typeparam>
/// <remarks>
/// This class can be useful when creating domain-specific argument providers,
/// such as default values, when an argument provider's value needs to be
/// wrapped for use in a different context.
/// </remarks>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.action-3">
/// System.Action&lt;T1, T2, T3&gt;</seealso>
public abstract class ActionArray<T1, T2, T3, K>
    : K<Action<T1, T2, T3>[], K>, K_ActionArray<T1, T2, T3>
    where K : K_ActionArray<T1, T2, T3>
{ public static Action<T1, T2, T3>[] Value => K.Value; }

/// <summary>
/// The <see cref="K_ActionArray{T1,T2,T3,T4}"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;System.Action&lt;T1,T2,T3,T4&gt;[]&gt;</c> derived type.
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
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.action-4">
/// System.Action&lt;T1, T2, T3, T4&gt;</seealso>
public interface K_ActionArray<in T1, in T2, in T3, in T4>
    : K_Array<Action<T1, T2, T3, T4>>;

/// <summary>
/// The <see cref="ActionArray{T1, T2, T3, T4, K}"/> class provides an argument provider that
/// wraps the
/// <see href="https://learn.microsoft.com/dotnet/api/system.action-4">
/// System.Action&lt;T1, T2, T3, T4&gt;</see> array from another argument provider.
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
/// <typeparam name="K">
/// The type of argument provider containing the value to wrap.
/// </typeparam>
/// <remarks>
/// This class can be useful when creating domain-specific argument providers,
/// such as default values, when an argument provider's value needs to be
/// wrapped for use in a different context.
/// </remarks>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.action-4">
/// System.Action&lt;T1, T2, T3, T4&gt;</seealso>
public abstract class ActionArray<T1, T2, T3, T4, K>
    : K<Action<T1, T2, T3, T4>[], K>, K_ActionArray<T1, T2, T3, T4>
    where K : K_ActionArray<T1, T2, T3, T4>
{ public static Action<T1, T2, T3, T4>[] Value => K.Value; }
