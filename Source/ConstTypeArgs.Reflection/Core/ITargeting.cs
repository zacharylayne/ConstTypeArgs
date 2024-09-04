namespace ConstTypeArgs.Reflection.Core;

/// <summary>
/// The <see cref="ITargeting{T}"/> interface provides a target property for a framework-related element.
/// </summary>
/// <typeparam name="T">
/// The type of the target.
/// </typeparam>
[EditorBrowsable(Never)]
public interface ITargeting<T>
    where T : IElementInfo
{
    /// <summary>
    /// Gets whether or not the element has a target.
    /// </summary>
    /// <value>
    /// A value of <see langword="true"/> if the element has a target;
    /// otherwise, <see langword="false"/>.
    /// </value>
    bool HasTarget { get; }

    /// <summary>
    /// Gets the target of the element.
    /// </summary>
    /// <value>
    /// The target of the element, or <see langword="null"/> if the element has no target.
    /// </value>
    T? Target { get; }
}
