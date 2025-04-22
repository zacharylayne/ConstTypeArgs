#pragma warning disable format

namespace ConstTypeArgs.ProcessRunners;

/// <summary>
/// The <see cref="ResultKinds"/> enumeration provides flags for identifying the kind of result
/// returned by a process runner, step, operation, or task.
/// </summary>
/// <seealso cref="Result"/>
/// <seealso cref="Result{TStatusCode}"/>
/// <seealso cref="Result{T, TStatusCode}"/>
/// <seealso cref="Result.Success"/>
/// <seealso cref="Result.Success{T}"/>
/// <seealso cref="Result.Exceptions"/>
/// <seealso cref="Result.Exceptions{TStatusCode}"/>
/// <seealso cref="Result.Exceptions{T, TStatusCode}"/>
/// <seealso cref="Result.Failure"/>
/// <seealso cref="Result.Failure{TStatusCode}"/>
/// <seealso cref="Result.Failure{T, TStatusCode}"/>
/// <seealso cref="Result.None"/>
[Flags]
public enum ResultKinds
    : byte
{
    /// <summary>
    /// There is no result kind.
    /// </summary>
    None        = 0,

    /// <summary>
    /// The result is a success.
    /// </summary>
    Success     = 1 << 0,

    /// <summary>
    /// The result is a failure.
    /// </summary>
    Failure     = 1 << 1,

    /// <summary>
    /// The result is a failure with exceptions.
    /// </summary>
    Exceptions  = 1 << 2,

    /// <summary>
    /// The result is any kind of failure.
    /// </summary>
    AllFailures = Failure | Exceptions,

    /// <summary>
    /// The result is a success, failure, or failed with exceptions.
    /// </summary>
    All         = Success | AllFailures,
}
