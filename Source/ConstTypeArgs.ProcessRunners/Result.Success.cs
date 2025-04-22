using ConstTypeArgs.ProcessRunners.Steps;

#pragma warning disable format

namespace ConstTypeArgs.ProcessRunners;

public abstract partial record Result : IResult
{
    /// <summary>
    /// The <see cref="Success"/> record provides a successful result for a process runner.
    /// </summary>
    public record Success : Result, IResult
    {
        /// <summary>
        /// Gets <see cref="ResultKinds.Success"/>.
        /// </summary>
        public override ResultKinds Kind => ResultKinds.Success;

        /// <summary>
        /// Gets <see langword="true"/>, indicating that the process runner ran to completion.
        /// </summary>
        public override bool RanToCompletion { get; } = true;

        /// <summary>
        /// Gets &amp; inits a message that describes the result.
        /// </summary>
        /// <value>
        /// A message that describes the result.
        /// By default, this is <c>"The process runner completed successfully"</c>.
        /// </value>
        public override string Message { get; init; } = "The process runner completed successfully";
    }

    /// <summary>
    /// The <see cref="Success{T}"/> record provides a successful result for a process runner
    /// that includes data.
    /// </summary>
    public sealed record Success<T>
        : Success, IResult<T, NoResultStatusCode>, IResultData<T>,
          IResultStatusCode<NoResultStatusCode>
        where T : notnull
    {
        /// <summary>
        /// Required. Gets &amp; inits the result data.
        /// </summary>
        /// <value>
        /// The result data.
        /// </value>
        public required T Data { get; init; }

        /// <inheritdoc/>
        public NoResultStatusCode StatusCode => NoResultStatusCode.None;
    }
}
