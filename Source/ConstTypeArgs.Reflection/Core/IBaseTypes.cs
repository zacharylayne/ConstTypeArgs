namespace ConstTypeArgs.Reflection.Core;

/// <summary>
/// The <see cref="IBaseTypes"/> interface provides information about the bases types
/// of a framework-related code element.
/// </summary>
[EditorBrowsable(Never)]
public interface IBaseTypes
{
    /// <summary>
    /// Gets whether or not the code element has any base types.
    /// </summary>
    /// <value>
    /// A value of <see langword="true"/> indicates that the code element has base types;
    /// otherwise, <see langword="false"/>.
    /// </value>
    bool HasInheritance { get; }

    /// <summary>
    /// Gets the base types that the code element inherits from, from most derived to least derived.
    /// </summary>
    /// <value>
    /// If the code element does not inherit from any base types, an empty collection is returned instead.
    /// </value>
    IEnumerable<ITypeInfo> InheritsFrom { get; }
}
