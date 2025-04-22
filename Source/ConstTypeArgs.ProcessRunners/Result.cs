using ConstTypeArgs.ProcessRunners.Steps;

namespace ConstTypeArgs.ProcessRunners;

/// <summary>
/// The <see cref="Result"/> record provides a common base for the results of a process runner.
/// </summary>
public abstract partial record Result : IResult
{
    /// <inheritdoc/>
    public abstract ResultKinds Kind { get; }

    /// <summary>
    /// Gets &amp; inits whether or not the process runner that produced the result ran to completion.
    /// </summary>
    /// <value>
    /// A value of <see langword="true"/> if the process runner ran to completion;
    /// otherwise, <see langword="false"/>. By default, this is <see langword="true"/>.
    /// </value>
    public virtual bool RanToCompletion { get; } = true;

    /// <summary>
    /// Gets &amp; inits a message that describes the result.
    /// </summary>
    /// <value>
    /// A message that describes the result. By default, this is an empty string.
    /// </value>
    public virtual string Message { get; init; } = string.Empty;
}

/// <summary>
/// The <see cref="Result{TStatusCode}"/> record provides the results of a process runner
/// that provides a status code.
/// </summary>
/// <typeparam name="TStatusCode">
/// The enum type of the status codes the result provides.
/// </typeparam>
/// <remarks>
/// If a status code is required but not available, use <see cref="NoResultStatusCode"/>.
/// </remarks>
public abstract record Result<TStatusCode>
    : Result, IResultStatusCode<TStatusCode>
    where TStatusCode : Enum
{
    /// <summary>
    /// Gets &amp; inits the status code.
    /// </summary>
    /// <value>
    /// The status code for the result. By default, this is the default value of the status code (0).
    /// Since this is set to the default value of the status code if not provided,
    /// any <typeparamref name="TStatusCode"/> enum should have a field with a value of 0.
    /// </value>
    public virtual TStatusCode StatusCode { get; init; } = default!;
}

/// <summary>
/// The <see cref="Result{T, TStatusCode}"/> record provides the results of a process runner
/// that provides a status code and data.
/// </summary>
/// <typeparam name="T">
/// The type of the result data.
/// </typeparam>
/// <typeparam name="TStatusCode">
/// The enum type of the status codes the result provides.
/// If a status code is required but not available, use <see cref="NoResultStatusCode"/>.
/// </typeparam>
public abstract record Result<T, TStatusCode>
    : Result<TStatusCode>, IResult<T, TStatusCode>,
      IResultData<T>, IResultStatusCode<TStatusCode>
    where T : notnull
    where TStatusCode : Enum
{
    /// <inheritdoc/>
    public abstract T Data { get; init; }
}
