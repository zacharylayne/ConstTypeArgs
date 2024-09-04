namespace ConstTypeArgs.Reflection.Core;

/// <summary>
/// The <see cref="IElementInfo"/> interface provides a base interface containing
/// reflection information about a framework-related code element.
/// </summary>
[EditorBrowsable(Never)]
public interface IElementInfo
{
    /// <summary>
    /// Gets the code element's name.
    /// </summary>
    string Name { get; }

    /// <summary>
    /// Gets the code element's kinds of relations to the framework.
    /// </summary>
    FrameworkKinds Kinds { get; }
}
