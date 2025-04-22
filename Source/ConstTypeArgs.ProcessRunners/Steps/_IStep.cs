using ConstTypeArgs.ProcessRunners.Operations;

#pragma warning disable format

namespace ConstTypeArgs.ProcessRunners.Steps;

// #TODO: Add more seelso items.
//        IStepAsync

/// <summary>
/// The <see cref="IStep{TContext}"/> interface provides the means to define a step in a process runner.
/// </summary>
/// <typeparam name="TContext">
/// The type of the context data. It is recommended to specify <see cref="Context{T}"/>
/// or <see cref="Context{T}.Empty"/> if the context is not required.
/// </typeparam>
public interface IStep<TContext>
    where TContext : struct
{
    /// <summary>
    /// Returns the step's name.
    /// </summary>
    /// <returns>
    /// The step's name.
    /// </returns>
    string GetName();

    /// <summary>
    /// Returns the step's description.
    /// </summary>
    /// <returns>
    /// The step's description.
    /// </returns>
    string GetDescription();

    /// <summary>
    /// Gets &amp; inits the context for the step.
    /// </summary>
    /// <value>
    /// The context for the step.
    /// </value>
    TContext Context { get; init; }
}

/// <summary>
/// The <see cref="IStep{TContext, TState, TOperation}"/> interface provides the means
/// to define a step in a process runner.
/// </summary>
/// <typeparam name="TContext">
/// The type of the context data. It is recommended to specify <see cref="Context{T}"/>
/// or <see cref="Context{T}.Empty"/> if the context is not required.
/// </typeparam>
/// <typeparam name="TState">
/// The type of the state data. It is recommended to specify:
///   <list type="bullet">
///     <item>
///     <see cref="State{TState}.None"/> or <see cref="ReadOnlyState{T}.None"/>
///     if the state is not required
///     </item>
///     <item>
///     <see cref="State{T}"/> if the state is required and can be modified
///     </item>
///     <item>
///     <see cref="ReadOnlyState{T}"/> if the state is required and should not be modified
///     </item>
///   </list>
/// </typeparam>
/// <typeparam name="TOperation">
/// The const type arg providing the operation the step will execute.
/// </typeparam>
/// <remarks>
/// This interface is typically directly implemented to define steps for
/// a process runner that are not entry points. If the step is an entry point,
/// implement <see cref="IStep{TContext, TState, TResult, TOperation}"/> instead.
/// </remarks>
public interface IStep<TContext, TState, TOperation>
    : IStep<TContext>
    where TContext   : struct
    where TState     : struct
    where TOperation : K_Operation<TContext, TState>,
                       K_Operation<TOperation>, K_Operation
{
    /// <summary>
    /// Executes the step.
    /// </summary>
    /// <param name="state">
    /// The state data for the step.
    /// </param>
    void Execute(ref TState state) => TOperation.Value(Context, state);
}

/// <summary>
/// The <see cref="IStep{TContext, TState, TResult, TOperation}"/> interface provides the means
/// to define a step in a process runner that returns a result.
/// </summary>
/// <typeparam name="TContext">
/// The type of the context data.
/// </typeparam>
/// <typeparam name="TState">
/// The type of the state data.
/// </typeparam>
/// <typeparam name="TResult">
/// The type of the status code the step will return.
/// </typeparam>
/// <typeparam name="TOperation">
/// The type of the operation the step will execute.
/// </typeparam>
/// <remarks>
/// This interface is typically directly implemented to define the step or steps for
/// a process runner's entry point or points. If the step is not an entry point,
/// implement <see cref="IStep{TContext, TState, TOperation}"/> instead.
/// </remarks>
public interface IStep<TContext, TState, TResult, TOperation>
    : IStep<TContext>
    where TContext   : struct
    where TState     : struct
    where TResult    : Result
    where TOperation : K_Operation<TContext, TState, TResult>,
                       K_Operation<TOperation>, K_Operation
{
    /// <summary>
    /// Executes the step.
    /// </summary>
    /// <param name="state">
    /// The state data for the step.
    /// </param>
    /// <returns>
    /// The result of the step.
    /// </returns>
    TResult Execute(ref TState state) => TOperation.Value(Context, state);
}
