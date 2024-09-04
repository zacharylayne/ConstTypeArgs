namespace ConstTypeArgs.Reflection.Core;

/// <summary>
/// The <see cref="IInterfaces"/> interface provides information about the interfaces
/// a framework-related code element implements.
/// </summary>
[EditorBrowsable(Never)]
public interface IInterfaces
{
    /// <summary>
    /// Gets a value indicating whether the code element implements any interfaces.
    /// </summary>
    /// <value>
    /// A value of <see langword="true"/> if the code element implements interfaces;
    /// otherwise, <see langword="false"/>.
    /// </value>
    bool ImplementsInterfaces { get; }

    /// <summary>
    /// Gets the interfaces that the code element implements.
    /// </summary>
    /// <value>
    /// If the code element does not implement any interfaces, an empty collection is returned instead.
    /// </value>
    IEnumerable<ITypeInfo> Implements { get; }
}
