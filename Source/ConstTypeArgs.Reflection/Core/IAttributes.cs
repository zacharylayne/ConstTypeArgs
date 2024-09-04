namespace ConstTypeArgs.Reflection.Core;

/// <summary>
/// The <see cref="IAttributes"/> interface provides information about the attributes
/// marking a framework-related code element.
/// </summary>
[EditorBrowsable(Never)]
public interface IAttributes
{
    /// <summary>
    /// Gets whether or not the code element has attributes.
    /// </summary>
    /// <value>
    /// A value of <see langword="true"/> if the code element has attributes;
    /// otherwise, <see langword="false"/>.
    /// </value>
    bool HasAttributes { get; }

    /// <summary>
    /// Gets the attributes targeting the element.
    /// </summary>
    /// <value>
    /// A collection of <see cref="IAttributeInfo"/> objects representing the attribute
    /// types that are targeting the element. If there are no attributes, an empty collection
    /// is returned instead.
    /// </value>
    IEnumerable<IAttributeInfo> Attributes { get; }
}
