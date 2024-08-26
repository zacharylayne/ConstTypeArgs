namespace ConstTypeArgs.Reflection.Core;

/// <summary>
/// The <see cref="IWithInterfacesInfo"/> interface is used to provide information about
/// a framework-related code element that has interfaces implemented.
/// </summary>
[EditorBrowsable(Never)]
public interface IWithInterfacesInfo
{
    /// <summary>
    /// Gets a collection of the interfaces that the code element implements.
    /// </summary>
    /// <value>
    /// If the code element does not implement any interfaces, an empty collection is returned instead.
    /// </value>
    IEnumerable<ITypeInfo> Implements { get; }
}
