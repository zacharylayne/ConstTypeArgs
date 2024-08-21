using ConstTypeArgs.Reflection.Core;

namespace ConstTypeArgs.Reflection;

/// <summary>
/// The <see cref="IAttributeInfo"/> interface provides information about an attribute.
/// </summary>
public interface IAttributeInfo : ITypeInfo, IWithBaseTypesInfo,
                                  IWithGenericParametersInfo,
                                  IWithGenericArgumentsInfo;