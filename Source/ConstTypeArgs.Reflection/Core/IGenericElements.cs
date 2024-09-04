namespace ConstTypeArgs.Reflection.Core;

/// <summary>
/// The <see cref="IGenericElements"/> interface provides information about
/// the generic parameters &amp; arguments of a generic type or method.
/// </summary>
[EditorBrowsable(Never)]
public interface IGenericElements
{
    /// <summary>
    /// Gets a value indicating whether the generic has generic elements.
    /// </summary>
    /// <value>
    /// <see langword="true"/> if the generic has generic elements;
    /// otherwise, <see langword="false"/>.
    /// </value>
    bool HasGenericElements { get; }

    /// <summary>
    /// Gets the generic parameters &amp; arguments of the generic.
    /// </summary>
    /// <value>
    /// If the generic does not have any generic elements, an empty collection is returned instead.
    /// </value>
    IEnumerable<IGenericElementInfo> GenericElements { get; }
}
