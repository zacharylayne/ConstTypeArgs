using ConstTypeArgs.Reflection.Core;

namespace ConstTypeArgs.Reflection;

/// <summary>
/// The <see cref="IGenericParameterInfo"/> interface provides information about a generic parameter
/// for a generic type or method.
/// </summary>
public interface IGenericParameterInfo
    : IElementInfo, IWithPositionInfo,
      IWithConstraintsInfo, IWithAttributesInfo;