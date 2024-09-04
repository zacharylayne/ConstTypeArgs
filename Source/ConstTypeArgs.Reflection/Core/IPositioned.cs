namespace ConstTypeArgs.Reflection.Core;

/// <summary>
/// The <see cref="IPositioned"/> interface provides the position of an ordered code element.
/// </summary>
[EditorBrowsable(Never)]
public interface IPositioned
{
    /// <summary>
    /// Gets the position of the code element, starting from 1.
    /// </summary>
    int Position { get; }
}
