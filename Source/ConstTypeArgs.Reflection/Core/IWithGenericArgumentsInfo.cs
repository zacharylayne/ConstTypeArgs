namespace ConstTypeArgs.Reflection.Core;

/// <summary>
/// The <see cref="IWithGenericArgumentsInfo"/> interface is used to provide information about
/// a framework-related code element that has generic arguments.
/// </summary>
/// <seealso cref="IWithGenericParametersInfo"/>
/// <seealso cref="IWithConstraintsInfo"/>
[EditorBrowsable(Advanced)]
public interface IWithGenericArgumentsInfo
{
    /// <summary>
    /// Gets whether or not the generic type or method this is has generic arguments.
    /// </summary>
    /// <value>
    /// A value of <see langword="true"/> if the generic type or method has generic arguments;
    /// otherwise, <see langword="false"/>.
    /// </value>
    /// <remarks>
    /// This property simply checks if the <see cref="GenericArguments"/> collection is not empty.
    /// It is only intended to be used in limited situations, particularly when collecting information
    /// about an attribute which can be generic or non-generic.
    /// </remarks>
    bool HasGenericArguments { get; }

    /// <summary>
    /// Gets whether or not the generic type or method this is providing information about is
    /// a closed generic type or method.
    /// </summary>
    /// <value>
    /// A value of <see langword="true"/> if the generic type or method is closed; otherwise, <see langword="false"/>.
    /// </value>
    public bool IsClosed { get; }

    /// <summary>
    /// Gets a collection of the generic type or method's generic arguments.
    /// </summary>
    /// <value>
    /// If the generic type or method is closed and has no generic arguments, an empty collection is returned instead.
    /// </value>
    /// <remarks>
    /// To get a collection of const type arguments only, use <see cref="ConstTypeArguments"/>.
    /// </remarks>
    /// <seealso cref="IWithGenericParametersInfo.GenericParameters"/>
    IEnumerable<ITypeInfo> GenericArguments { get; }

    /// <summary>
    /// Gets an ordered subset of const type arguments from the generic arguments
    /// for a generic type or method.
    /// </summary>
    /// <value>
    /// If the generic arguments for a generic type or method does not contain any const type arguments,
    /// an empty collection is returned instead.
    /// </value>
    /// <remarks>
    /// To get a collection of all generic arguments, use <see cref="GenericArguments"/>.
    /// </remarks>
    IEnumerable<IConstTypeArgInfo> ConstTypeArguments { get; }
}
