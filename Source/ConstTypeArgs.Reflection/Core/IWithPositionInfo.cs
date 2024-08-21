namespace ConstTypeArgs.Reflection.Core;

/// <summary>
/// The <see cref="IWithPositionInfo"/> interface provides the position of an ordered code element.
/// </summary>
[EditorBrowsable(Advanced)]
public interface IWithPositionInfo
{
    /// <summary>
    /// Gets the position of the code element, starting from 1.
    /// </summary>
    int Position { get; }
}