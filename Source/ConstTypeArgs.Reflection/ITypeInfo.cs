using ConstTypeArgs.Reflection.Core;

namespace ConstTypeArgs.Reflection;

/// <summary>
/// The <see cref="ITypeInfo"/> interface provides information about a framework-related type.
/// </summary>
public interface ITypeInfo
    : IElementInfo, IWithType, IWithBaseTypesInfo,
      IWithInterfacesInfo, IWithAttributesInfo
{
    /// <summary>
    /// Gets whether or not the type is a class.
    /// </summary>
    /// <value>
    /// A value of <see langword="true"/> if the type is a class; otherwise, <see langword="false"/>.
    /// </value>
    /// <remarks>
    /// If <see langword="true"/>, then <see cref="IsInterface"/> &amp; <see cref="IsStruct"/>
    /// are both <see langword="false"/>.
    /// </remarks>
    /// <seealso cref="IsAbstract"/>
    /// <seealso cref="IsSealed"/>
    bool IsClass { get; }

    /// <summary>
    /// Gets whether or not the type is an interface.
    /// </summary>
    /// <value>
    /// A value of <see langword="true"/> if the type is an interface; otherwise, <see langword="false"/>.
    /// </value>
    /// <remarks>
    /// If <see langword="true"/>, then <see cref="IsStruct"/>, <see cref="IsClass"/>,
    /// <see cref="IsAbstract"/>, and <see cref="IsSealed"/>
    /// are all <see langword="false"/>.
    /// </remarks>
    /// <seealso cref="IsClass"/>
    /// <seealso cref="IsStruct"/>
    bool IsInterface { get; }

    /// <summary>
    /// Gets whether or not the type is a struct <em>(i.e. a value type)</em>.
    /// </summary>
    /// <value>
    /// A value of <see langword="true"/> if the type is a struct; otherwise, <see langword="false"/>.
    /// </value>
    /// <remarks>
    /// If <see langword="true"/>, then <see cref="IsInterface"/>, <see cref="IsClass"/>, <see cref="IsAbstract"/>,
    /// and <see cref="IsSealed"/> are all <see langword="false"/>.
    /// </remarks>
    /// <seealso cref="IsClass"/>
    /// <seealso cref="IsInterface"/>
    bool IsStruct { get; }

    /// <summary>
    /// Gets whether or not the type is abstract.
    /// </summary>
    /// <value>
    /// A <see langword="true"/> if the type is abstract; otherwise, <see langword="false"/>.
    /// </value>
    /// <remarks>
    /// If <see langword="true"/>, then <see cref="IsInterface"/>, <see cref="IsStruct"/>, and <see cref="IsSealed"/>
    /// are all <see langword="false"/>.
    /// </remarks>
    /// <seealso cref="IsClass"/>
    bool IsAbstract { get; }

    /// <summary>
    /// Gets whether or not the type is sealed.
    /// </summary>
    /// <value>
    /// A value of <see langword="true"/> if the type is sealed; otherwise, <see langword="false"/>.
    /// </value>
    /// <remarks>
    /// If <see langword="true"/>, then <see cref="IsInterface"/>, <see cref="IsStruct"/>, and <see cref="IsAbstract"/>
    /// are all <see langword="false"/>.
    /// </remarks>
    /// <seealso cref="IsClass"/>
    bool IsSealed { get; }
}
