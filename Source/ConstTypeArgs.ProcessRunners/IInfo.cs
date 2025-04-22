namespace ConstTypeArgs.ProcessRunners;

/// <summary>
/// The <see cref="IInfo{TSelf}"/> interface provides a way to define
/// the name and description of a type.
/// </summary>
/// <typeparam name="TSelf">
/// The type itself.
/// </typeparam>
/// <seealso cref="Operations.K_Operation{TContext, TState}"/>
/// <seealso cref="Operations.K_Operation{TContext, TState, TResult}"/>
public interface IInfo<TSelf>
    where TSelf : IInfo<TSelf>
{
    /// <summary>
    /// Gets a name.
    /// </summary>
    /// <value>
    /// A name.
    /// </value>
    /// <seealso cref="Description"/>
    /// <seealso cref="InfoHelper.GetName{TSelf}"/>
    static abstract string Name { get; }

    /// <summary>
    /// Gets a description.
    /// </summary>
    /// <value>
    /// A description.
    /// </value>
    /// <seealso cref="Name"/>
    /// <seealso cref="InfoHelper.GetDescription{TSelf}"/>
    static abstract string Description { get; }
}

/// <summary>
/// The <see cref="InfoHelper"/> static class provides utility methods for the
/// <see cref="IInfo{TSelf}"/> interface.
/// </summary>
public static class InfoHelper
{
    /// <summary>
    /// Returns a name.
    /// </summary>
    /// <typeparam name="T">
    /// The type of info.
    /// </typeparam>
    /// <returns>
    /// A name.
    /// </returns>
    /// <seealso cref="GetDescription{TSelf}"/>
    public static string GetName<T>() where T : IInfo<T>
        => T.Name;

    /// <summary>
    /// Returns a description.
    /// </summary>
    /// <typeparam name="T">
    /// The type of info.
    /// </typeparam>
    /// <returns>
    /// A description.
    /// </returns>
    /// <seealso cref="GetName{TSelf}"/>
    public static string GetDescription<T>() where T : IInfo<T>
        => T.Description;
}
