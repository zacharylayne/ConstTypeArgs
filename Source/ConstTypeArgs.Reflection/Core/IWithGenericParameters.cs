using ConstTypeArgs.Reflection;

namespace ConstTypeArgs.Reflection.Core;

/// <summary>
/// The <see cref="IWithGenericParametersInfo"/> interface is used to provide information about
/// a framework-related code element that has generic arguments.
/// </summary>
/// <seealso cref="IWithGenericArgumentsInfo"/>
/// <seealso cref="IWithConstraintsInfo"/>
[EditorBrowsable(Advanced)]
public interface IWithGenericParametersInfo
{
    /// <summary>
    /// Gets whether or not the generic type or method this is has generic parameters.
    /// </summary>
    /// <value>
    /// A value of <see langword="true"/> if the generic type or method has generic parameters;
    /// otherwise, <see langword="false"/>.
    /// </value>
    /// <remarks>
    /// This property simply checks if the <see cref="GenericParameters"/> collection is not empty.
    /// It is only intended to be used in limited situations, particularly when collecting information
    /// about an attribute which can be generic or non-generic.
    /// </remarks>
    bool HasGenericParameters { get; }

    /// <summary>
    /// Gets whether or not the generic type or method this is providing information about is
    /// a closed generic type or method.
    /// </summary>
    /// <value>
    /// A value of <see langword="true"/> if the generic type or method is closed; otherwise, <see langword="false"/>.
    /// </value>
    public bool IsClosed { get; }

    /// <summary>
    /// Gets a collection of the generic type or method's generic parameters.
    /// </summary>
    /// <value>
    /// If the generic type or method is not an open generic type or method, an empty collection is returned instead.
    /// </value>
    /// <seealso cref="IWithGenericArgumentsInfo.GenericArguments"/>
    IEnumerable<IGenericParameterInfo> GenericParameters { get; }
}
