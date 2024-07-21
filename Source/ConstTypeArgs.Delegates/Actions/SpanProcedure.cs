using ConstTypeArgs.Core;

#pragma warning disable IDE1006 // Naming Styles
#pragma warning disable CS1591  // Missing XML comment for publicly visible type or member

namespace ConstTypeArgs.Delegates.Actions;

/// <summary>
/// Encapsulates a method that receives a span of objects
/// of type <typeparamref name="T"/> and a state object
/// of type <typeparamref name="TArg"/>.
/// </summary>
/// <typeparam name="T">
/// The type of the objects in the span.
/// </typeparam>
/// <typeparam name="TArg">
/// The type of the object that represents the state.
/// </typeparam>
/// <param name="span">
/// A span of objects of type <typeparamref name="T"/>.
/// </param>
/// <param name="arg">
/// A state object of type <typeparamref name="TArg"/>.
/// </param>
/// <seealso cref="K_SpanProcedure{T, TArg}"/>
/// <seealso cref="SpanProcedure{T, TArg, K}"/>
/// <seealso cref="ReadOnlySpanProcedure{T, TArg}"/>
public delegate void SpanProcedure<T, in TArg>(Span<T> span, TArg arg);

/// <summary>
/// The <see cref="K_SpanProcedure{T, TArgt}"/> interface provides a more explicit
/// IConstTypeArgs&lt;SpanProcedure&lt;T, TArg&gt;&gt; derived type.
/// </summary>
/// <typeparam name="T">
/// The type of the objects in the span.
/// </typeparam>
/// <typeparam name="TArg">
/// The type of the object that represents the state.
/// </typeparam>
/// <seealso cref="SpanProcedure{T, TArg, K}"/>
/// <seealso cref="K_ReadOnlySpanProcedure{T, TArg}"/>
public interface K_SpanProcedure<T, TArg>
    : K_Delegate<SpanProcedure<T, TArg>>;

/// <summary>
/// The <see cref="SpanProcedure{T, TArg, K}"/> class provides an argument provider that
/// wraps the <see cref="SpanProcedure{T, TArg}"/> from another argument provider.
/// </summary>
/// <typeparam name="T">
/// The type of the objects in the span.
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
/// <seealso cref="ReadOnlySpanProcedure{T, TArg, K}"/>
public abstract class SpanProcedure<T, TArg, K>
    : K<SpanProcedure<T, TArg>, K>
    where K : K_SpanProcedure<T, TArg>
{ public static SpanProcedure<T, TArg> Value => K.Value; }
