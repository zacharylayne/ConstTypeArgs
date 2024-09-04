namespace ConstTypeArgs.Reflection.Core;

/// <summary>
/// The <see cref="IDeclaredProperties"/> interface is used to provide information about
/// the declared properties of a framework-related code element.
/// </summary>
[EditorBrowsable(Never)]
public interface IDeclaredProperties
{
    /// <summary>
    /// Gets whether or not the code element has properties declared
    /// </summary>
    /// <value>
    /// A value of <see langword="true"/> if the code element has properties declared;
    /// otherwise, <see langword="false"/>.
    /// </value>
    bool HasDeclaredProperties { get; }

    /// <summary>
    /// Gets the properties that the code element declares.
    /// </summary>
    /// <value>
    /// If the code element does not declare any properties, an empty collection is returned instead.
    /// </value>
    IEnumerable<IPropertyInfo> DeclaredProperties { get; }
}
