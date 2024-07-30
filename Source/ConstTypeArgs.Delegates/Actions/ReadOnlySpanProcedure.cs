using ConstTypeArgs.Core;

#pragma warning disable IDE1006 // Naming Styles
#pragma warning disable CS1591  // Missing XML comment for publicly visible type or member

namespace ConstTypeArgs.Delegates.Actions;

/// <summary>
/// Encapsulates a method that receives a read-only span of objects
/// of type <typeparamref name="T"/> and a state object
/// of type <typeparamref name="TArg"/>.
/// </summary>
/// <typeparam name="T">
/// The type of the objects in the read-only span.
/// </typeparam>
/// <typeparam name="TArg">
/// The type of the object that represents the state.
/// </typeparam>
/// <param name="span">
/// A read-only span of objects of type <typeparamref name="T"/>.
/// </param>
/// <param name="arg">
/// A state object of type <typeparamref name="TArg"/>.
/// </param>
/// <seealso cref="K_ReadOnlySpanProcedure{T, TArg}"/>
/// <seealso cref="ReadOnlySpanProcedure{T, TArg, K}"/>
/// <seealso cref="SpanProcedure{T, TArg}"/>
public delegate void ReadOnlySpanProcedure<T, in TArg>(ReadOnlySpan<T> span, TArg arg);

/// <summary>
/// The <see cref="K_ReadOnlySpanProcedure{T, TArgt}"/> interface provides a more explicit
/// IConstTypeArgs&lt;ReadOnlySpanAction&lt;T, TArg&gt;&gt; derived type.
/// </summary>
/// <typeparam name="T">
/// The type of the objects in the read-only span.
/// </typeparam>
/// <typeparam name="TArg">
/// The type of the object that represents the state.
/// </typeparam>
/// <seealso cref="ReadOnlySpanProcedure{T, TArg, K}"/>
/// <seealso cref="K_SpanProcedure{T, TArg}"/>
public interface K_ReadOnlySpanProcedure<T, TArg>
    : K_Delegate<ReadOnlySpanProcedure<T, TArg>>;

/// <summary>
/// The <see cref="ReadOnlySpanProcedure{T, TArg, K}"/> class provides an argument provider that
/// wraps the <see cref="ReadOnlySpanProcedure{T, TArg}"/> from another argument provider.
/// </summary>
/// <typeparam name="T">
/// The type of the objects in the read-only span.
/// </typeparam>
/// <typeparam name="TArg">
/// The type of the object that represents the state.
/// </typeparam>
/// <typeparam name="K">
/// The type of argument provider containing the value to wrap.
/// </typeparam>
/// <remarks>
/// This class can be useful when creating domain-specific argument providers,
/// such as default values, when an argument provider's value needs to be
/// wrapped for use in a different context.
/// </remarks>
/// <seealso cref="SpanProcedure{T, TArg, K}"/>
public abstract class ReadOnlySpanProcedure<T, TArg, K> : K<ReadOnlySpanProcedure<T, TArg>, K>
    where K : K_ReadOnlySpanProcedure<T, TArg>
{ public static ReadOnlySpanProcedure<T, TArg> Value => K.Value; }
