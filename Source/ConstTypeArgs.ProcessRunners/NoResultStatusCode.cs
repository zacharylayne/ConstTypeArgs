namespace ConstTypeArgs.ProcessRunners;

/// <summary>
/// The <see cref="NoResultStatusCode"/> enumeration indicates a process runner
/// step, operation, or task that does not provide a status code.
/// </summary>
/// <remarks>
/// Use this enumeration when defining a process runner step, operation, or task
/// that does not provide a status code but still needs to be represented as a result
/// or when generic type constraints require a status code.
/// </remarks>
/// <seealso cref="Result{TStatusCode}"/>
/// <seealso cref="Result"/>
public enum NoResultStatusCode
{
    /// <summary>
    /// No status code is provided.
    /// </summary>
    None = 0,
}
