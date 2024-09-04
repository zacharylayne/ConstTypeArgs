namespace ConstTypeArgs.Reflection.Core;

/// <summary>
/// The <see cref="IConstraints"/> interface provides information about the generic constraints
/// a framework-related generic parameter or argument has.
/// </summary>
/// <remarks>
/// This type does not validate whether or not the constraints are valid for the generic parameter or argument,
/// or the constraints conflict with each other, or are redundant, or are not allowed.
/// </remarks>
[EditorBrowsable(Never)]
public interface IConstraints
{
    /// <summary>
    /// Gets whether or not the generic parameter or argument has constraints.
    /// </summary>
    /// <value>
    /// A value of <see langword="true"/> if the generic parameter or argument has constraints;
    /// otherwise, <see langword="false"/>.
    /// </value>
    bool HasConstraints { get; }

    /// <summary>
    /// Gets the type constraints that the generic parameter or argument has.
    /// </summary>
    /// <value>
    /// Constraints can include one class and zero or more interfaces.
    /// If the generic parameter or argument does not have any type constraints, an empty collection is returned instead.
    /// </value>
    IEnumerable<ITypeInfo> Constraints { get; }
}