namespace ConstTypeArgs.Reflection.Core;

/// <summary>
/// The <see cref="IWithAttributesInfo"/> interface provides information about the attributes
/// marking a code element.
/// </summary>
public interface IWithAttributesInfo
{
    /// <summary>
    /// Gets a collection of attributes on the element.
    /// </summary>
    /// <value>
    /// A collection of <see cref="IAttributeInfo"/> objects representing the attribute
    /// types that are applied to the element. If there are no attributes, an empty collection
    /// is returned instead.
    /// </value>
    IEnumerable<IAttributeInfo> Attributes { get; }
}
