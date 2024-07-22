using ConstTypeArgs.Core;

#pragma warning disable IDE1006 // Naming Styles
#pragma warning disable CS1591  // Missing XML comment for publicly visible type or member
#pragma warning disable RCS1158 // Static member in generic type should use a type parameter

namespace ConstTypeArgs.Uints;

/// <summary>
/// The <see cref="K_Uint"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;uint&gt;</c> derived type.
/// </summary>
/// <remarks>
/// Implement this interface when defining <see langword="uint"/> const type arguments
/// rather than <see cref="K_Unmanaged{TSelf}">K_Unmanaged&lt;uint&gt;</see>,
/// <see cref="K_Integer{TSelf}">K_Integer&lt;uint&gt;</see>,
/// <see cref="K_UnsignedNumber{T}">K_UnsignedNumber&lt;uint&gt;</see>, or
/// <see cref="IConstTypeArg{T}">IConstTypeArg&lt;uint&gt;</see>.
/// In uncommon scenarios where they need to be instantiated,
/// use <see cref="K_Uint{TSelf}"/> instead.
/// </remarks>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.uint32">
/// System.UInt32</seealso>
/// <seealso cref="Uint{K}"/>
/// <seealso cref="K_UintArray"/>
/// <seealso cref="__"/>
public interface K_Uint
    : K_Unmanaged<uint>, K_Integer<uint>, K_UnsignedNumber<uint>
{
    /// <summary>
    /// The <see cref="__"/> interface is a <em>discard argument</em> meant to signify
    /// a lack of value and is used as a placeholder in type parameter lists.
    /// When combined with other discard arguments of other types, it can be used to create
    /// union-like behavior.
    /// </summary>
    public interface __ : Core.__, K_Uint, IConstTypeArg<uint?>;
}

/// <summary>
/// The <see cref="K_Uint{TSelf}"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;uint, K_Uint&lt;TSelf&gt;&gt;</c> derived type.
/// </summary>
/// <typeparam name="TSelf">
/// The implementing type.
/// </typeparam>
/// <remarks>
/// Implement this interface for <see langword="uint"/> const type arguments in uncommon
/// scenarios where they need to be instantiated. Otherwise, use <see cref="K_Uint"/> instead.
/// </remarks>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.uint32">
/// System.UInt32</seealso>
/// <seealso cref="Uint{K}"/>
/// <seealso cref="K_UintArray{TSelf}"/>
public interface K_Uint<TSelf> : K_Uint, IConstTypeArg<uint, TSelf>
    where TSelf : K_Uint<TSelf>;

/// <summary>
/// The <see cref="K_UintArray"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;uint[]&gt;</c> type.
/// </summary>
/// <remarks>
/// Implement this interface when defining <see langword="uint[]"/> const type arguments
/// rather than <see cref="K_Array{T}">K_Array&lt;uint&gt;</see>
/// or <see cref="IConstTypeArg{T}">IConstTypeArg&lt;uint[]&gt;</see>.
/// In uncommon scenarios where they need to be instantiated,
/// use <see cref="K_UintArray{TSelf}"/> instead.
/// </remarks>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.uint32">
/// System.UInt32</seealso>
/// <seealso cref="UintArray{K}"/>
/// <seealso cref="K_Uint"/>
/// <seealso cref="__"/>
public interface K_UintArray : K_Array<uint>
{
    /// <summary>
    /// The <see cref="__"/> interface is a <em>discard argument</em> meant to signify
    /// a lack of value and is used as a placeholder in type parameter lists.
    /// When combined with other discard arguments of other types, it can be used to create
    /// union-like behavior.
    /// </summary>
    public interface __ : Core.__, K_UintArray;
}

/// <summary>
/// The <see cref="K_UintArray{TSelf}"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;uint[], K_UintArray&lt;TSelf&gt;&gt;</c> derived type.
/// </summary>
/// <typeparam name="TSelf">
/// The implementing type.
/// </typeparam>
/// <remarks>
/// Implement this interface for <see langword="uint[]"/> const type arguments in uncommon
/// scenarios where they need to be instantiated.
/// Otherwise, use <see cref="K_UintArray"/> instead.
/// </remarks>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.uint32">
/// System.UInt32</seealso>
/// <seealso cref="UintArray{K}"/>
/// <seealso cref="K_Uint{TSelf}"/>
public interface K_UintArray<TSelf> : K_UintArray, IConstTypeArg<uint[], TSelf>
    where TSelf : K_UintArray<TSelf>;

/// <summary>
/// The <see cref="Uint{K}"/> class provides a const argument provider that
/// wraps the <see langword="uint"/> value from another const argument provider.
/// </summary>
/// <typeparam name="K">
/// The const argument provider type containing the value to wrap.
/// </typeparam>
/// <remarks>
/// This class can be used to create domain-specific const type arguments or
/// to wrap const type arguments for reuse in other contexts.
/// </remarks>
/// <seealso cref="K_Uint"/>
/// <seealso cref="UintArray{K}"/>
public abstract class Uint<K> : K<uint, K>, K_Uint
    where K : K_Uint
{ public static uint Value => K.Value; }

/// <summary>
/// The <see cref="UintArray{K}"/> class provides a const argument provider that
/// wraps the <see langword="uint"/> array from another const argument provider.
/// </summary>
/// <typeparam name="K">
/// The const argument provider type containing the array to wrap.
/// </typeparam>
/// <remarks>
/// This class can be used to create domain-specific const type arguments or
/// to wrap const type arguments for reuse in other contexts.
/// </remarks>
/// <seealso cref="K_UintArray"/>
/// <seealso cref="Uint{K}"/>
public abstract class UintArray<K> : K<uint[], K>, K_UintArray
    where K : K_UintArray
{ public static uint[] Value => K.Value; }
