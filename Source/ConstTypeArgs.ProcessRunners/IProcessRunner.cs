using ConstTypeArgs.ProcessRunners.Operations;

namespace ConstTypeArgs.ProcessRunners;

/// <summary>
/// The <see cref="IProcessRunner"/> interface provides the means to implement
/// a process runner that can execute one or more ordered steps.
/// </summary>
/// <seealso cref="K_Operation{TState, TContext}"/>
/// <seealso cref="K_Operation{TState, TContext, TResult}"/>
/// <seealso cref="Context{T}"/>
/// <seealso cref="State{T}"/>
/// <seealso cref="Result"/>
/// <seealso cref="Result{TStatusCode}"/>
public interface IProcessRunner
{
    /// <summary>
    /// Retrieves a name for the process runner.
    /// </summary>
    /// <returns>
    /// The process runner's name.
    /// </returns>
    string GetName();

    /// <summary>
    /// Retrieves a description for the process runner.
    /// </summary>
    /// <returns>
    /// The process runner's description.
    /// </returns>
    string GetDescription();
}
