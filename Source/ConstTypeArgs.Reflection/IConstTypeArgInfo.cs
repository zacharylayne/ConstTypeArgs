using ConstTypeArgs.Reflection.Core;

namespace ConstTypeArgs.Reflection;

/// <summary>
/// The <see cref="IConstTypeArgInfo"/> interface provides information about a const type argument.
/// </summary>
public interface IConstTypeArgInfo : ITypeInfo, IWithBaseTypesInfo,
                                     IWithValue, IWellKnownConstTypes;
