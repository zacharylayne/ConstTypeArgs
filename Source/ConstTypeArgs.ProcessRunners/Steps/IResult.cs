namespace ConstTypeArgs.ProcessRunners.Steps;

/// <summary>
/// The <see cref="IResult"/> interface provides the means to implement a result
/// for a process runner.
/// </summary>
public interface IResult
{
    /// <summary>
    /// Gets the kind of the result.
    /// </summary>
    /// <value>
    /// The kind of the result, such as <see cref="ResultKinds.Success"/>,
    /// <see cref="ResultKinds.Failure"/>, or <see cref="ResultKinds.Exceptions"/>.
    /// </value>
    ResultKinds Kind { get; }

    /// <summary>
    /// Gets whether or not the process runner that produced the result ran to completion.
    /// </summary>
    /// <value>
    /// A value of <see langword="true"/> if the process runner ran to completion;
    /// otherwise, <see langword="false"/>.
    /// </value>
    bool RanToCompletion { get; }

    /// <summary>
    /// Gets a message that describes the result.
    /// </summary>
    /// <value>
    /// A message that describes the result.
    /// </value>
    string Message { get; }
}

/// <summary>
/// The <see cref="IResultData{T}"/> interface provides the means to implement
/// a result for a process runner that contains data.
/// </summary>
/// <typeparam name="T">
/// The type of the result data.
/// </typeparam>
/// <seealso cref="IResultStatusCode{TStatusCode}"/>
/// <seealso cref="IResult{T, TStatusCode}"/>
public interface IResultData<T> : IResult
    where T : notnull
{
    /// <summary>
    /// Gets the result data.
    /// </summary>
    /// <value>
    /// The result data.
    /// </value>
    T Data { get; }
}

/// <summary>
/// The <see cref="IResultStatusCode{TStatusCode}"/> interface provides the means to implement
/// a result for a process runner that contains a status code.
/// </summary>
/// <typeparam name="TStatusCode">
/// The type of the status code.
/// </typeparam>
/// <remarks>
/// If a status code is required but not available, use <see cref="NoResultStatusCode"/>.
/// </remarks>
/// <seealso cref="IResultData{T}"/>
/// <seealso cref="IResult{T, TStatusCode}"/>
public interface IResultStatusCode<TStatusCode> : IResult
{
    /// <summary>
    /// Gets the status code.
    /// </summary>
    /// <value>
    /// The status code.
    /// </value>
    TStatusCode StatusCode { get; }
}

/// <summary>
/// The <see cref="IResult{T, TStatusCode}"/> interface provides the means to implement
/// a result for a process runner that contains a status code and data.
/// </summary>
/// <typeparam name="T">
/// The type of the result data.
/// </typeparam>
/// <typeparam name="TStatusCode">
/// The type of the status code.
/// </typeparam>
/// <remarks>
/// If a status code is required but not available, use <see cref="NoResultStatusCode"/>.
/// </remarks>
/// <seealso cref="IResultData{T}"/>
/// <seealso cref="IResultStatusCode{TStatusCode}"/>
public interface IResult<T, TStatusCode>
    : IResult, IResultStatusCode<TStatusCode>, IResultData<T>
    where T : notnull
    where TStatusCode : Enum;
