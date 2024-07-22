using ConstTypeArgs.Core;

#pragma warning disable IDE1006 // Naming Styles
#pragma warning disable CS1591  // Missing XML comment for publicly visible type or member
#pragma warning disable RCS1158 // Static member in generic type should use a type parameter

namespace ConstTypeArgs.Ushorts;

/// <summary>
/// The <see cref="K_Ushort"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;ushort&gt;</c> derived type.
/// </summary>
/// <remarks>
/// Implement this interface when defining <see langword="ushort"/> const type arguments
/// rather than <see cref="K_Unmanaged{TSelf}">K_Unmanaged&lt;ushort&gt;</see>,
/// <see cref="K_Integer{TSelf}">K_Integer&lt;ushort&gt;</see>,
/// <see cref="K_SignedNumber{T}">K_UnsignedNumber&lt;ushort&gt;</see>, or
/// <see cref="IConstTypeArg{T}">IConstTypeArg&lt;ushort&gt;</see>.
/// In uncommon scenarios where they need to be instantiated,
/// use <see cref="K_Ushort{TSelf}"/> instead.
/// </remarks>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.uint16">
/// System.UInt16</seealso>
/// <seealso cref="Ushort{K}"/>
/// <seealso cref="K_UshortArray"/>
/// <seealso cref="__"/>
public interface K_Ushort
    : K_Unmanaged<ushort>, K_Integer<ushort>, K_UnsignedNumber<ushort>
{
    /// <summary>
    /// The <see cref="__"/> interface is a <em>discard argument</em> meant to signify
    /// a lack of value and is used as a placeholder in type parameter lists.
    /// When combined with other discard arguments of other types, it can be used to create
    /// union-like behavior.
    /// </summary>
    public interface __ : Core.__, K_Ushort, IConstTypeArg<ushort?>;
}

/// <summary>
/// The <see cref="K_Ushort{TSelf}"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;ushort, K_Ushort&lt;TSelf&gt;&gt;</c> derived type.
/// </summary>
/// <typeparam name="TSelf">
/// The implementing type.
/// </typeparam>
/// <remarks>
/// Implement this interface for <see langword="ushort"/> const type arguments in uncommon
/// scenarios where they need to be instantiated. Otherwise, use <see cref="K_Ushort"/> instead.
/// </remarks>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.uint16">
/// System.UInt16</seealso>
/// <seealso cref="Ushort{K}"/>
/// <seealso cref="K_UshortArray{TSelf}"/>
public interface K_Ushort<TSelf> : K_Ushort, IConstTypeArg<ushort, TSelf>
    where TSelf : K_Ushort<TSelf>;

/// <summary>
/// The <see cref="K_UshortArray"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;ushort[]&gt;</c> type.
/// </summary>
/// <remarks>
/// Implement this interface when defining <see langword="ushort[]"/> const type arguments
/// rather than <see cref="K_Array{T}">K_Array&lt;ushort&gt;</see>
/// or <see cref="IConstTypeArg{T}">IConstTypeArg&lt;ushort[]&gt;</see>.
/// In uncommon scenarios where they need to be instantiated,
/// use <see cref="K_UshortArray{TSelf}"/> instead.
/// </remarks>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.uint16">
/// System.UInt16</seealso>
/// <seealso cref="UshortArray{K}"/>
/// <seealso cref="K_Ushort"/>
/// <seealso cref="__"/>
public interface K_UshortArray : K_Array<ushort>
{
    /// <summary>
    /// The <see cref="__"/> interface is a <em>discard argument</em> meant to signify
    /// a lack of value and is used as a placeholder in type parameter lists.
    /// When combined with other discard arguments of other types, it can be used to create
    /// union-like behavior.
    /// </summary>
    public interface __ : Core.__, K_UshortArray;
}

/// <summary>
/// The <see cref="K_UshortArray{TSelf}"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;ushort[], K_UshortArray&lt;TSelf&gt;&gt;</c> derived type.
/// </summary>
/// <typeparam name="TSelf">
/// The implementing type.
/// </typeparam>
/// <remarks>
/// Implement this interface for <see langword="ushort[]"/> const type arguments in uncommon
/// scenarios where they need to be instantiated.
/// Otherwise, use <see cref="K_UshortArray"/> instead.
/// </remarks>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.uint16">
/// System.UInt16</seealso>
/// <seealso cref="UshortArray{K}"/>
/// <seealso cref="K_Ushort{TSelf}"/>
public interface K_UshortArray<TSelf> : K_UshortArray, IConstTypeArg<ushort[], TSelf>
    where TSelf : K_UshortArray<TSelf>;

/// <summary>
/// The <see cref="Ushort{K}"/> class provides a const argument provider that
/// wraps the <see langword="ushort"/> value from another const argument provider.
/// </summary>
/// <typeparam name="K">
/// The const argument provider type containing the value to wrap.
/// </typeparam>
/// <remarks>
/// This class can be used to create domain-specific const type arguments or
/// to wrap const type arguments for reuse in other contexts.
/// </remarks>
/// <seealso cref="K_Ushort"/>
/// <seealso cref="UshortArray{K}"/>
public abstract class Ushort<K> : K<ushort, K>, K_Ushort
    where K : K_Ushort
{ public static ushort Value => K.Value; }

/// <summary>
/// The <see cref="UshortArray{K}"/> class provides a const argument provider that
/// wraps the <see langword="ushort"/> array from another const argument provider.
/// </summary>
/// <typeparam name="K">
/// The const argument provider type containing the array to wrap.
/// </typeparam>
/// <remarks>
/// This class can be used to create domain-specific const type arguments or
/// to wrap const type arguments for reuse in other contexts.
/// </remarks>
/// <seealso cref="K_UshortArray"/>
/// <seealso cref="Ushort{K}"/>
public abstract class UshortArray<K> : K<ushort[], K>, K_UshortArray
    where K : K_UshortArray
{ public static ushort[] Value => K.Value; }
