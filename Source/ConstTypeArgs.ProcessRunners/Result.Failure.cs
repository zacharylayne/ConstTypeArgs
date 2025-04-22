using ConstTypeArgs.ProcessRunners.Steps;

#pragma warning disable format

namespace ConstTypeArgs.ProcessRunners;

public abstract partial record Result : IResult
{
    /// <summary>
    /// The <see cref="Failure"/> record provides a failed result for a process runner.
    /// </summary>
    public record Failure : Result, IResult
    {
        /// <summary>
        /// Gets <see cref="ResultKinds.Failure"/>.
        /// </summary>
        public override ResultKinds Kind => ResultKinds.Failure;

        /// <summary>
        /// Gets <see langword="false"/>, indicating that the process runner did not run to completion.
        /// </summary>
        public override bool RanToCompletion => false;

        /// <summary>
        /// Gets &amp; inits a message that describes the result.
        /// </summary>
        /// <value>
        /// A message that describes the result.
        /// By default, this is <c>"The process runner failed"</c>.
        /// </value>
        public override string Message { get; init; } = "The process runner failed";
    }

    /// <summary>
    /// The <see cref="Failure{T}"/> record provides a failed result for a process runner
    /// that includes a status code.
    /// </summary>
    /// <typeparam name="TStatusCode">
    /// The enum type of the status code for the result.
    /// </typeparam>
    public record Failure<TStatusCode>
        : Failure, IResultStatusCode<TStatusCode>, IResult
        where TStatusCode : Enum
    {
        /// <summary>
        /// Required. Gets &amp; inits the status code for the result.
        /// </summary>
        /// <value>
        /// The status code for the result.
        /// </value>
        public required TStatusCode StatusCode { get; init; } = default!;
    }

    /// <summary>
    /// The <see cref="Failure{T, TStatusCode}"/> record provides a failed result for a process runner
    /// that includes data and a status code.
    /// </summary>
    /// <typeparam name="T">
    /// The type of the result data.
    /// </typeparam>
    /// <typeparam name="TStatusCode">
    /// The enum type of the status code for the result.
    /// </typeparam>
    public sealed record Failure<T, TStatusCode>
        : Failure<TStatusCode>, IResult<T, TStatusCode>,
          IResultData<T>, IResultStatusCode<TStatusCode>
        where T : notnull
        where TStatusCode : Enum
    {
        /// <summary>
        /// Required. Gets &amp; inits the result data.
        /// </summary>
        /// <value>
        /// The result data.
        /// </value>
        public required T Data { get; init; }
    }
}
