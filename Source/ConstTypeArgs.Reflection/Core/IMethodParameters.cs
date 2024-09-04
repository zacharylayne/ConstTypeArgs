namespace ConstTypeArgs.Reflection.Core;

/// <summary>
/// The <see cref="IMethodParameters"/> interface provides information about a method's parameters.
/// </summary>
public interface IMethodParameters
{
    /// <summary>
    /// Gets whether or not the method this represents has parameters.
    /// </summary>
    /// <value>
    /// A value of <see langword="true"/> if the method this represents has parameters;
    /// otherwise, <see langword="false"/>.
    /// </value>
    bool HasParameters { get; }

    /// <summary>
    /// Gets the parameters of the method this represents.
    /// </summary>
    /// <value>
    /// The parameters of the method this represents or an empty collection if there are no parameters.
    /// </value>
    /// <remarks>
    /// The parameters are not guaranteed to be in the order they are declared in the method.
    /// To determine the order of the parameters, use <see cref="IPositioned.Position">
    /// IMethodParameterInfo.Position</see>.
    /// </remarks>
    IEnumerable<IMethodParameterInfo> Parameters { get; }
}
