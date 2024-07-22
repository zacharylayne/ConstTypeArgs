using ConstTypeArgs.Core;

#pragma warning disable IDE1006 // Naming Styles
#pragma warning disable CS1591  // Missing XML comment for publicly visible type or member
#pragma warning disable RCS1158 // Static member in generic type should use a type parameter

namespace ConstTypeArgs.Ulongs;

/// <summary>
/// The <see cref="K_Ulong"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;ulong&gt;</c> derived type.
/// </summary>
/// <remarks>
/// Implement this interface when defining <see langword="ulong"/> const type arguments
/// rather than <see cref="K_Unmanaged{TSelf}">K_Unmanaged&lt;ulong&gt;</see>,
/// <see cref="K_Integer{TSelf}">K_Integer&lt;ulong&gt;</see>,
/// <see cref="K_UnsignedNumber{T}">K_UnsignedNumber&lt;ulong&gt;</see>, or
/// <see cref="IConstTypeArg{T}">IConstTypeArg&lt;ulong&gt;</see>.
/// In uncommon scenarios where they need to be instantiated,
/// use <see cref="K_Ulong{TSelf}"/> instead.
/// </remarks>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.uint64">
/// System.UInt64</seealso>
/// <seealso cref="Ulong{K}"/>
/// <seealso cref="K_UlongArray"/>
/// <seealso cref="__"/>
public interface K_Ulong
    : K_Unmanaged<ulong>, K_Integer<ulong>, K_UnsignedNumber<ulong>
{
    /// <summary>
    /// The <see cref="__"/> interface is a <em>discard argument</em> meant to signify
    /// a lack of value and is used as a placeholder in type parameter lists.
    /// When combined with other discard arguments of other types, it can be used to create
    /// union-like behavior.
    /// </summary>
    public interface __ : Core.__, K_Ulong, IConstTypeArg<ulong?>;
}

/// <summary>
/// The <see cref="K_Ulong{TSelf}"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;ulong, K_Ulong&lt;TSelf&gt;&gt;</c> derived type.
/// </summary>
/// <typeparam name="TSelf">
/// The implementing type.
/// </typeparam>
/// <remarks>
/// Implement this interface for <see langword="ulong"/> const type arguments in uncommon
/// scenarios where they need to be instantiated. Otherwise, use <see cref="K_Ulong"/> instead.
/// </remarks>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.uint64">
/// System.UInt64</seealso>
/// <seealso cref="Ulong{K}"/>
/// <seealso cref="K_UlongArray{TSelf}"/>
public interface K_Ulong<TSelf> : K_Ulong, IConstTypeArg<ulong, TSelf>
    where TSelf : K_Ulong<TSelf>;

/// <summary>
/// The <see cref="K_UlongArray"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;ulong[]&gt;</c> type.
/// </summary>
/// <remarks>
/// Implement this interface when defining <see langword="ulong[]"/> const type arguments
/// rather than <see cref="K_Array{T}">K_Array&lt;ulong&gt;</see>
/// or <see cref="IConstTypeArg{T}">IConstTypeArg&lt;ulong[]&gt;</see>.
/// In uncommon scenarios where they need to be instantiated,
/// use <see cref="K_UlongArray{TSelf}"/> instead.
/// </remarks>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.uint64">
/// System.UInt64</seealso>
/// <seealso cref="UlongArray{K}"/>
/// <seealso cref="K_Ulong"/>
/// <seealso cref="__"/>
public interface K_UlongArray : K_Array<ulong>
{
    /// <summary>
    /// The <see cref="__"/> interface is a <em>discard argument</em> meant to signify
    /// a lack of value and is used as a placeholder in type parameter lists.
    /// When combined with other discard arguments of other types, it can be used to create
    /// union-like behavior.
    /// </summary>
    public interface __ : Core.__, K_UlongArray;
}

/// <summary>
/// The <see cref="K_UlongArray{TSelf}"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;ulong[], K_UlongArray&lt;TSelf&gt;&gt;</c> derived type.
/// </summary>
/// <typeparam name="TSelf">
/// The implementing type.
/// </typeparam>
/// <remarks>
/// Implement this interface for <see langword="ulong[]"/> const type arguments in uncommon
/// scenarios where they need to be instantiated.
/// Otherwise, use <see cref="K_UlongArray"/> instead.
/// </remarks>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.uint64">
/// System.UInt64</seealso>
/// <seealso cref="UlongArray{K}"/>
/// <seealso cref="K_Ulong{TSelf}"/>
public interface K_UlongArray<TSelf> : K_UlongArray, IConstTypeArg<ulong[], TSelf>
    where TSelf : K_UlongArray<TSelf>;

/// <summary>
/// The <see cref="Ulong{K}"/> class provides a const argument provider that
/// wraps the <see langword="ulong"/> value from another const argument provider.
/// </summary>
/// <typeparam name="K">
/// The const argument provider type containing the value to wrap.
/// </typeparam>
/// <remarks>
/// This class can be used to create domain-specific const type arguments or
/// to wrap const type arguments for reuse in other contexts.
/// </remarks>
/// <seealso cref="K_Ulong"/>
/// <seealso cref="UlongArray{K}"/>
public abstract class Ulong<K> : K<ulong, K>, K_Ulong
    where K : K_Ulong
{ public static ulong Value => K.Value; }

/// <summary>
/// The <see cref="UlongArray{K}"/> class provides a const argument provider that
/// wraps the <see langword="ulong"/> array from another const argument provider.
/// </summary>
/// <typeparam name="K">
/// The const argument provider type containing the array to wrap.
/// </typeparam>
/// <remarks>
/// This class can be used to create domain-specific const type arguments or
/// to wrap const type arguments for reuse in other contexts.
/// </remarks>
/// <seealso cref="K_UlongArray"/>
/// <seealso cref="Ulong{K}"/>
public abstract class UlongArray<K> : K<ulong[], K>, K_UlongArray
    where K : K_UlongArray
{ public static ulong[] Value => K.Value; }
