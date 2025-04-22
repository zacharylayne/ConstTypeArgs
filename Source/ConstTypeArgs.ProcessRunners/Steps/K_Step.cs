using ConstTypeArgs;
using ConstTypeArgs.Delegates;
using ConstTypeArgs.Delegates.Actions;
using ConstTypeArgs.ProcessRunners.Operations;

#pragma warning disable format

namespace ConstTypeArgs.ProcessRunners.Steps;

/// <summary>
/// The <see cref="K_Step{TContext, TState, TOperation}"/> interface is a
/// const type argument holder that provides a way to provide context &amp; state
/// to an operation upon invoking the operation.
/// </summary>
/// <typeparam name="TContext">
/// The type of context for the operation the step will invoke.
/// </typeparam>
/// <typeparam name="TState">
/// The type of state the step will invoke.
/// </typeparam>
/// <typeparam name="TOperation">
/// The type of operation the step will invoke.
/// </typeparam>
public interface K_Step<in TContext, in TState, TOperation>
    : K_Procedure<TOperation>
    where TContext   : notnull
    where TState     : notnull
    where TOperation : K_Operation<TContext, TState>;

/// <summary>
/// The <see cref="K_Step{TContext, TState, TResult, TOperation}"/> interface is a
/// const type argument holder that provides a way to provide context &amp; state
/// to an operation upon invoking the operation.
/// </summary>
/// <typeparam name="TContext">
/// The type of context for the operation the step will invoke.
/// </typeparam>
/// <typeparam name="TState">
/// The type of state the step will invoke.
/// </typeparam>
/// <typeparam name="TResult">
/// The type of result of the operation the step will invoke.
/// </typeparam>
/// <typeparam name="TOperation">
/// The type of operation the step will invoke.
/// </typeparam>
public interface K_Step<in TContext, in TState, out TResult, TOperation>
    where TContext   : notnull
    where TState     : notnull
    where TResult    : notnull
    where TOperation : K_Operation<TContext, TState, TResult>;
