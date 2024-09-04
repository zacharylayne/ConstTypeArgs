namespace ConstTypeArgs.Reflection.Core;

/// <summary>
/// The <see cref="IStatic"/> interface provides a value indicating whether or not
/// an applicable code element is static.
/// </summary>
[EditorBrowsable(Never)]
public interface IStatic
{
    /// <summary>
    /// Gets a value indicating whether or not the code element is static.
    /// </summary>
    /// <value>
    /// A value of <see langword="true"/> if the code element is static;
    /// otherwise, <see langword="false"/>.
    /// </value>
    bool IsStatic { get; }
}
