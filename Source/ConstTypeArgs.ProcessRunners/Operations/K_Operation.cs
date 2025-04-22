using ConstTypeArgs.Delegates.Funcs;
using ConstTypeArgs.Delegates.Actions;

#pragma warning disable format

namespace ConstTypeArgs.ProcessRunners.Operations;

/// <summary>
/// The <see cref="K_Operation{TContext, TState}"/> interface provides a way to define const type arguments
/// that specify operations that can be executed in process steps.
/// </summary>
/// <typeparam name="TContext">
/// The type of the context data. It is recommended to pass <see cref="Context{T}"/> to the operation
/// or <see cref="Context{T}.Empty"/> if the context is not required.
/// </typeparam>
/// <typeparam name="TState">
/// The type of the state data. It is recommended to pass the operation:
///  <list type="bullet">
///   <item>
///   <see cref="State{TState}.None"/> or <see cref="ReadOnlyState{T}.None"/>
///   if the state is not required
///   </item>
///   <item>
///   <see cref="State{T}"/> if the state is required and can be modified
///   </item>
///   <item>
///   <see cref="ReadOnlyState{T}"/> if the state is required and should not be modified
///   </item>
///  </list>
/// </typeparam>
/// <remarks>
/// This is typically used to define const type arguments for use in process runner steps that are not
/// an entry step or steps.
///   <para>
///   The context &amp; state can provide a subset of the context &amp; state data that is provided
///   in the steps the operation is called from.
///   </para>
/// </remarks>
/// <seealso cref="K_Operation{TContext, TState, TResult}"/>
/// <seealso cref="State{T}"/>
/// <seealso cref="ReadOnlyState{T}"/>
/// <seealso cref="Context{T}"/>
/// <seealso cref="Result"/>
/// <seealso cref="Result{TStatusCode}"/>
public interface K_Operation<TContext, in TState>
    : K_RefProcedure<TContext, TState>
    where TContext : notnull
    where TState   : notnull;

/// <summary>
/// The <see cref="K_Operation{TContext, TState, TResult}"/> interface provides a way to define const type arguments
/// that specify operations that can be executed in process steps.
/// </summary>
/// <typeparam name="TContext">
/// The type of the context data. It is recommended to pass <see cref="Context{T}"/> to the operation
/// or <see cref="Context{T}.Empty"/> if the context is not required.
/// </typeparam>
/// <typeparam name="TState">
/// The type of the state data. It is recommended to pass the operation:
///  <list type="bullet">
///   <item>
///   <see cref="State{TState}.None"/> or <see cref="ReadOnlyState{T}.None"/>
///   if the state is not required
///   </item>
///   <item>
///   <see cref="State{T}"/> if the state is required and can be modified
///   </item>
///   <item>
///   <see cref="ReadOnlyState{T}"/> if the state is required and should not be modified
///   </item>
///  </list>
/// </typeparam>
/// <typeparam name="TResult">
/// The type of the result data.
/// </typeparam>
/// <remarks>
/// This is typically used to define const type arguments for use in process runner steps that are
/// an entry step or steps.
///   <para>
///   The context &amp; state can provide a subset of the context &amp; state data that is provided
///   in the steps the operation is called from.
///   </para>
/// </remarks>
/// <seealso cref="K_Operation{TContext, TState}"/>
/// <seealso cref="State{T}"/>
/// <seealso cref="ReadOnlyState{T}"/>
/// <seealso cref="Context{T}"/>
/// <seealso cref="Result"/>
/// <seealso cref="Result{TStatusCode}"/>
public interface K_Operation<TContext, in TState, out TResult>
    : K_RefFunction<TContext, TState, TResult>
    where TContext : notnull
    where TState   : notnull
    where TResult  : notnull;
