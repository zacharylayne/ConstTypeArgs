using ConstTypeArgs.Reflection.Core;

namespace ConstTypeArgs.Reflection;

/// <summary>
/// The <see cref="IAttributeInfo"/> interface provides information about an attribute.
/// </summary>
public interface IAttributeInfo
    : IElementInfo, ITyped, IBaseTypes//, IWithGenericParametersInfo, IWithGenericArgumentsInfo
{
    /// <summary>
    /// Gets the target of the attribute this represents.
    /// </summary>
    IElementInfo Target { get; }
}
