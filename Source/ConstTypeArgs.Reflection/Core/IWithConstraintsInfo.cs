namespace ConstTypeArgs.Reflection.Core;

/// <summary>
/// The <see cref="IWithConstraintsInfo"/> interface provides information about a framework-related
/// generic parameter or argument that has constraints.
/// </summary>
/// <remarks>
/// This type does not validate whether or not the constraints are valid for the generic parameter or argument,
/// or the constraints conflict with each other, or are redundant, or are not allowed.
/// </remarks>
/// <seealso cref="IWithGenericParametersInfo"/>
/// <seealso cref="IWithGenericArgumentsInfo"/>
[EditorBrowsable(Advanced)]
public interface IWithConstraintsInfo
{
    /// <summary>
    /// Gets a collection of the type constraints that the generic parameter or argument has.
    /// </summary>
    /// <value>
    /// If the generic parameter or argument does not have any type constraints, an empty collection is returned instead.
    /// </value>
    /// <seealso cref="UntypedConstraints"/>
    IEnumerable<ITypeInfo> TypedConstraints { get; }

    /// <summary>
    /// Gets a collection of the untyped constraints that the generic parameter or argument has
    /// <em>(i.e. <see langword="struct"/>, <see langword="class"/>, <see langword="notnull"/>,
    /// <see langword="unmanaged"/>, <see langword="new"/>, etc.)</em>
    /// </summary>
    /// <seealso cref="TypedConstraints"/>
    IEnumerable<string> UntypedConstraints { get; }
}
