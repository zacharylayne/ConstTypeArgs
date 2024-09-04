namespace ConstTypeArgs.Reflection.Core;

/// <summary>
/// The <see cref="IDeclaredFields"/> interface provides information about the fields
/// a framework-related code element has declared.
/// </summary>
[EditorBrowsable(Never)]
public interface IDeclaredFields
{
    /// <summary>
    /// Gets whether or not the code element has fields declared.
    /// </summary>
    /// <value>
    /// A value of <see langword="true"/> if the code element has fields declared;
    /// otherwise, <see langword="false"/>.
    /// </value>
    bool HasDeclaredFields { get; }

    /// <summary>
    /// Gets the fields that the code element declares.
    /// </summary>
    /// <value>
    /// If the code element does not have any fields declared, an empty collection is returned instead.
    /// </value>
    IEnumerable<IFieldInfo> DeclaredFields { get; }
}
