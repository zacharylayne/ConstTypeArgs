namespace ConstTypeArgs.Reflection.Core;

/// <summary>
/// The <see cref="IWithBaseTypesInfo"/> interface provides information about a framework-related
/// code element that has base types.
/// </summary>
[EditorBrowsable(Never)]
public interface IWithBaseTypesInfo
{
    /// <summary>
    /// Gets a collection of the base types that the code element inherits from, from most derived to least derived.
    /// </summary>
    /// <value>
    /// If the code element does not inherit from any base types, an empty collection is returned instead.
    /// </value>
    IEnumerable<ITypeInfo> BaseTypes { get; }
}
