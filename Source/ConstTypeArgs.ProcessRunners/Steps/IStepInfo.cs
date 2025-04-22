namespace ConstTypeArgs.ProcessRunners.Steps;

/// <summary>
/// The <see cref="IStepInfo{TSelf}"/> interface provides the means to define information
/// about a step in a process runner.
/// </summary>
/// <typeparam name="TSelf">
/// This type.
/// </typeparam>
public interface IStepInfo<TSelf>
    where TSelf : IStepInfo<TSelf>
{
    /// <summary>
    /// Gets the step's name.
    /// </summary>
    /// <value>
    /// The step's name. By default, this is an empty string.
    /// </value>
    /// <seealso cref="Description"/>
    static abstract string Name { get; }

    /// <summary>
    /// Gets the step's description.
    /// </summary>
    /// <value>
    /// The step's description. By default, this is an empty string.
    /// </value>
    /// <seealso cref="Name"/>
    static abstract string Description { get; }

    /// <summary>
    /// Returns the step's name.
    /// </summary>
    /// <returns>
    /// The step's name.
    /// </returns>
    string GetName() => TSelf.Name;

    /// <summary>
    /// Returns the step's description.
    /// </summary>
    /// <returns>
    /// The step's description.
    /// </returns>
    string GetDescription() => TSelf.Description;
}
