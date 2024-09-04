namespace ConstTypeArgs.Reflection.Core;

/// <summary>
/// The <see cref="IAbstract"/> interface gets a value that indicates whether or not
/// an applicable code element is abstract.
/// </summary>
[EditorBrowsable(Never)]
public interface IAbstract
{
    /// <summary>
    /// Gets whether or not the code element is abstract.
    /// </summary>
    /// <value>
    /// A value of <see langword="true"/> if the code element is abstract;
    /// otherwise, <see langword="false"/>.
    /// </value>
    bool IsAbstract { get; }
}
