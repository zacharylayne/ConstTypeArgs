using ConstTypeArgs.Reflection;

namespace ConstTypeArgs.Reflection.Core;

/// <summary>
/// The <see cref="IElementInfo"/> interface provides a base interface containing
/// reflection information about a framework-related code element.
/// </summary>
[EditorBrowsable(Advanced)]
public interface IElementInfo
{
    /// <summary>
    /// Gets the code element's name.
    /// </summary>
    string Name { get; }

    /// <summary>
    /// Gets the code element's kinds of relations to the framework.
    /// </summary>
    FrameworkKinds Kind { get; }

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
