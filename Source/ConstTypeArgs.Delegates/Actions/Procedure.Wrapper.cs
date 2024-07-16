#pragma warning disable CS1591  // Missing XML comment for publicly visible type or member
#pragma warning disable RCS1158 // Static member in generic type should use a type parameter

namespace ConstTypeArgs.Delegates.Actions;

/// <summary>
/// The <see cref="Procedure{K}"/> class provides an argument provider that
/// wraps the
/// <see href="https://learn.microsoft.com/dotnet/api/system.action">
/// System.Action</see> value from another argument provider.
/// </summary>
/// <typeparam name="K">
/// The type of argument provider containing the value to wrap.
/// </typeparam>
/// <remarks>
/// This class can be useful when creating domain-specific argument providers,
/// such as default values, when an argument provider's value needs to be
/// wrapped for use in a different context.
/// </remarks>
public abstract class Procedure<K>
    : K<Action, K>, K_Procedure
    where K : K_Procedure
{ public static Action Value => K.Value; }

/// <summary>
/// The <see cref="Procedure{T, K}"/> class provides an argument provider that
/// wraps the
/// <see href="https://learn.microsoft.com/dotnet/api/system.action-1">
/// System.Action&lt;T&gt;</see> value from another argument provider.
/// </summary>
/// <typeparam name="T">
/// The type of the input parameter.
/// </typeparam>
/// <typeparam name="K">
/// The type of argument provider containing the value to wrap.
/// </typeparam>
/// <remarks>
/// This class can be useful when creating domain-specific argument providers,
/// such as default values, when an argument provider's value needs to be
/// wrapped for use in a different context.
/// </remarks>
public abstract class Procedure<T, K>
    : K<Action<T>, K>, K_Procedure<T>
    where K : K_Procedure<T>
{ public static Action<T> Value => K.Value; }

/// <summary>
/// The <see cref="Procedure{T1, T2, K}"/> class provides an argument provider that
/// wraps the
/// <see href="https://learn.microsoft.com/dotnet/api/system.action-2">
/// System.Action&lt;T1, T2&gt;</see> value from another argument provider.
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
public abstract class Procedure<T1, T2, K>
    : K<Action<T1, T2>, K>, K_Procedure<T1, T2>
    where K : K_Procedure<T1, T2>
{ public static Action<T1, T2> Value => K.Value; }

/// <summary>
/// The <see cref="Procedure{T1, T2, T3, K}"/> class provides an argument provider that
/// wraps the
/// <see href="https://learn.microsoft.com/dotnet/api/system.action-3">
/// System.Action&lt;T1, T2, T3&gt;</see> value from another argument provider.
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
public abstract class Procedure<T1, T2, T3, K>
    : K<Action<T1, T2, T3>, K>, K_Procedure<T1, T2, T3>
    where K : K_Procedure<T1, T2, T3>
{ public static Action<T1, T2, T3> Value => K.Value; }

/// <summary>
/// The <see cref="Procedure{T1, T2, T3, T4, K}"/> class provides an argument provider that
/// wraps the
/// <see href="https://learn.microsoft.com/dotnet/api/system.action-4">
/// System.Action&lt;T1, T2, T3, T4&gt;</see> value from another argument provider.
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
public abstract class Procedure<T1, T2, T3, T4, K>
    : K<Action<T1, T2, T3, T4>, K>, K_Procedure<T1, T2, T3, T4>
    where K : K_Procedure<T1, T2, T3, T4>
{ public static Action<T1, T2, T3, T4> Value => K.Value; }
