using ConstTypeArgs.ProcessRunners.Steps;
using MostlyExceptional;

#pragma warning disable format

namespace ConstTypeArgs.ProcessRunners;

public abstract partial record Result : IResult
{
    /// <summary>
    /// The <see cref="Exceptions"/> record provides a result for a process runner that threw exceptions.
    /// </summary>
    /// <remarks>
    /// A process runner that throws exceptions is considered to have not run to completion
    /// by default. To indicate that the process runner ran to completion, set the
    /// <see cref="RanToCompletion"/> parameter to <see langword="true"/>.
    /// </remarks>
    public record Exceptions : Result, IResult
    {
        /// <summary>
        /// Gets <see cref="ResultKinds.Exceptions"/>.
        /// </summary>
        public override ResultKinds Kind => ResultKinds.Exceptions;

        /// <summary>
        /// Gets whether or not the process runner that produced the result ran to completion.
        /// By default, this is <see langword="false"/>.
        /// </summary>
        public override bool RanToCompletion { get; }

        /// <summary>
        /// Gets &amp; inits a message that describes the result.
        /// By default, this is <c>"The process runner threw exceptions"</c>.
        /// </summary>
        public override string Message { get; init; } = "The process runner threw exceptions";

        /// <summary>
        /// Required. Gets &amp; inits the exception aggregator that contains the exceptions
        /// thrown by the process runner.
        /// </summary>
        /// <value>
        /// The exception aggregator that contains the exceptions thrown by the process runner.
        /// </value>
        public required ExceptionAggregator Aggregator { get; init; }

        /// <summary>
        /// Creates a new <see cref="Exceptions"/> record.
        /// </summary>
        /// <param name="ranToCompletion">
        /// Optional. A value of <see langword="true"/> if the process runner ran to completion;
        /// otherwise, <see langword="false"/>. By default, this is <see langword="false"/>.
        /// </param>
        public Exceptions(bool ranToCompletion = false)
            => RanToCompletion = ranToCompletion;
    }

    /// <summary>
    /// The <see cref="Exceptions{TStatusCode}"/> record provides a result for a process runner
    /// that threw exceptions and includes a status code.
    /// </summary>
    /// <typeparam name="TStatusCode">
    /// The enum type of the status code for the result.
    /// </typeparam>
    public record Exceptions<TStatusCode> : Exceptions,
        IResultStatusCode<TStatusCode>, IResult
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
    /// The <see cref="Exceptions{T, TStatusCode}"/> record provides a result for a process runner
    /// that threw exceptions and includes data and a status code.
    /// </summary>
    /// <typeparam name="T">
    /// The type of the result data.
    /// </typeparam>
    /// <typeparam name="TStatusCode">
    /// The enum type of the status code for the result.
    /// </typeparam>
    public sealed record Exceptions<T, TStatusCode> :
        Exceptions<TStatusCode>, IResultData<T>
        where T : notnull
        where TStatusCode : Enum
    {
        /// <summary>
        /// Required. Gets &amp; inits the data for the result.
        /// </summary>
        /// <value>
        /// The data for the result.
        /// </value>
        public required T Data { get; init; }
    }
}
