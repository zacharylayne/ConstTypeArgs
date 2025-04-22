using ConstTypeArgs.ProcessRunners.Steps;

namespace ConstTypeArgs.ProcessRunners;

public abstract partial record Result : IResult
{
    /// <summary>
    /// The <see cref="None"/> record provides a result for a process runner that did not run.
    /// </summary>
    public sealed record None
        : Result<NoResultStatusCode>, IResultStatusCode<NoResultStatusCode>, IResult
    {
        /// <summary>
        /// Gets <see cref="ResultKinds.None"/>.
        /// </summary>
        public override ResultKinds Kind => ResultKinds.None;

        /// <summary>
        /// Gets <see cref="NoResultStatusCode.None"/>.
        /// </summary>
        public override NoResultStatusCode StatusCode => NoResultStatusCode.None;

        /// <summary>
        /// Gets <see langword="false"/>, indicating that the process runner did not run to completion.
        /// </summary>
        public override bool RanToCompletion => false;

        /// <summary>
        /// Gets &amp; inits a message that describes the result.
        /// </summary>
        /// <value>
        /// A message that describes the result.
        /// By default, this is <c>"The process runner did not run"</c>.
        /// </value>
        public override string Message { get; init; } = "The process runner did not run";
    }
}
