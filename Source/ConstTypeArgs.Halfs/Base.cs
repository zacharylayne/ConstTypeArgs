using ConstTypeArgs.Core;

#pragma warning disable IDE1006 // Naming Styles
#pragma warning disable CS1591  // Missing XML comment for publicly visible type or member
#pragma warning disable RCS1158 // Static member in generic type should use a type parameter

namespace ConstTypeArgs.Halfs;

/// <summary>
/// The <see cref="K_Half"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;Half&gt;</c> derived type.
/// </summary>
/// <remarks>
/// Implement this interface when defining
/// <see href="https://learn.microsoft.com/dotnet/api/system.half">
/// Half</see>
/// const type arguments
/// rather than <see cref="K_Unmanaged{T}">K_Unmanaged&lt;Half&gt;</see>,
/// <see cref="K_FloatingPoint{T}">K_FloatingPoint&lt;Half&gt;</see>,
/// <see cref="K_SignedNumber{T}">K_SignedNumber&lt;Half&gt;</see>,
/// or <see cref="IConstTypeArg{T}">IConstTypeArg&lt;Half&gt;</see>.
/// In uncommon scenarios where they need to be instantiated,
/// use <see cref="K_Half{TSelf}"/> instead.
/// </remarks>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.half">
/// System.Half</seealso>
/// <seealso cref="Half{K}"/>
/// <seealso cref="K_HalfArray"/>
/// <seealso cref="__"/>
public interface K_Half
    : K_Unmanaged<Half>, K_FloatingPoint<Half>, K_SignedNumber<Half>
{
    /// <summary>
    /// The <see cref="__"/> interface is a <em>discard argument</em> meant to signify
    /// a lack of value and is used as a placeholder in type parameter lists.
    /// When combined with other discard arguments of other types, it can be used to create
    /// union-like behavior.
    /// </summary>
    public interface __ : Core.__, K_Half, IConstTypeArg<Half?>;
}

/// <summary>
/// The <see cref="K_Half{TSelf}"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;Half, K_Half&lt;TSelf&gt;&gt;</c> derived type.
/// </summary>
/// <typeparam name="TSelf">
/// The implementing type.
/// </typeparam>
/// <remarks>
/// Implement this interface for <see langword="Half"/> const type arguments in uncommon
/// scenarios where they need to be instantiated. Otherwise, use <see cref="K_Half"/> instead.
/// </remarks>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.half">
/// System.Half</seealso>
/// <seealso cref="Half{K}"/>
/// <seealso cref="K_HalfArray{TSelf}"/>
public interface K_Half<TSelf> : K_Half, IConstTypeArg<Half, TSelf>
    where TSelf : K_Half<TSelf>;

/// <summary>
/// The <see cref="K_HalfArray"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;Half[]&gt;</c> type.
/// </summary>
/// <remarks>
/// Implement this interface when defining <see langword="Half[]"/> const type arguments
/// rather than <see cref="K_Array{T}">K_Array&lt;Half&gt;</see>
/// or <see cref="IConstTypeArg{T}">IConstTypeArg&lt;Half[]&gt;</see>.
/// In uncommon scenarios where they need to be instantiated,
/// use <see cref="K_HalfArray{TSelf}"/> instead.
/// </remarks>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.half">
/// System.Half</seealso>
/// <seealso cref="HalfArray{K}"/>
/// <seealso cref="K_Half"/>
/// <seealso cref="__"/>
public interface K_HalfArray : K_Array<Half>
{
    /// <summary>
    /// The <see cref="__"/> interface is a <em>discard argument</em> meant to signify
    /// a lack of value and is used as a placeholder in type parameter lists.
    /// When combined with other discard arguments of other types, it can be used to create
    /// union-like behavior.
    /// </summary>
    public interface __ : Core.__, K_HalfArray;
}

/// <summary>
/// The <see cref="K_HalfArray{TSelf}"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;Half[], K_HalfArray&lt;TSelf&gt;&gt;</c> derived type.
/// </summary>
/// <typeparam name="TSelf">
/// The implementing type.
/// </typeparam>
/// <remarks>
/// Implement this interface for <see langword="Half[]"/> const type arguments in uncommon
/// scenarios where they need to be instantiated.
/// Otherwise, use <see cref="K_HalfArray"/> instead.
/// </remarks>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.half">
/// System.Half</seealso>
/// <seealso cref="HalfArray{K}"/>
/// <seealso cref="K_Half{TSelf}"/>
public interface K_HalfArray<TSelf> : K_HalfArray, IConstTypeArg<Half[], TSelf>
    where TSelf : K_HalfArray<TSelf>;

/// <summary>
/// The <see cref="Half{K}"/> class provides a const argument provider that
/// wraps the <see langword="Half"/> value from another const argument provider.
/// </summary>
/// <typeparam name="K">
/// The const argument provider type containing the value to wrap.
/// </typeparam>
/// <remarks>
/// This class can be used to create domain-specific const type arguments or
/// to wrap const type arguments for reuse in other contexts.
/// </remarks>
/// <seealso cref="K_Half"/>
/// <seealso cref="HalfArray{K}"/>
public abstract class Half<K> : K<Half, K>, K_Half
    where K : K_Half
{ public static Half Value => K.Value; }

/// <summary>
/// The <see cref="HalfArray{K}"/> class provides a const argument provider that
/// wraps the <see langword="Half"/> array from another const argument provider.
/// </summary>
/// <typeparam name="K">
/// The const argument provider type containing the array to wrap.
/// </typeparam>
/// <remarks>
/// This class can be used to create domain-specific const type arguments or
/// to wrap const type arguments for reuse in other contexts.
/// </remarks>
/// <seealso cref="K_HalfArray"/>
/// <seealso cref="Half{K}"/>
public abstract class HalfArray<K> : K<Half[], K>, K_HalfArray
    where K : K_HalfArray
{ public static Half[] Value => K.Value; }
