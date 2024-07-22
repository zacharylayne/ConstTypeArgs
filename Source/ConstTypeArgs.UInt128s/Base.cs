using ConstTypeArgs.Core;

#pragma warning disable IDE1006 // Naming Styles
#pragma warning disable CS1591  // Missing XML comment for publicly visible type or member
#pragma warning disable RCS1158 // Static member in generic type should use a type parameter

namespace ConstTypeArgs.UInt128s;

/// <summary>
/// The <see cref="K_UInt128"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;UInt128&gt;</c> derived type.
/// </summary>
/// <remarks>
/// Implement this interface when defining
/// <see href="https://learn.microsoft.com/dotnet/api/system.uint128">UInt128</see>
/// const type arguments
/// rather than <see cref="K_Unmanaged{TSelf}">K_Unmanaged&lt;UInt128&gt;</see>,
/// <see cref="K_Integer{TSelf}">K_Integer&lt;UInt128&gt;</see>,
/// <see cref="K_UnsignedNumber{T}">K_UnsignedNumber&lt;UInt128&gt;</see>, or
/// <see cref="IConstTypeArg{T}">IConstTypeArg&lt;UInt128&gt;</see>.
/// In uncommon scenarios where they need to be instantiated,
/// use <see cref="K_UInt128{TSelf}"/> instead.
/// </remarks>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.uint128">
/// System.UInt128</seealso>
/// <seealso cref="UInt128{K}"/>
/// <seealso cref="K_UInt128Array"/>
/// <seealso cref="__"/>
public interface K_UInt128
    : K_Unmanaged<UInt128>, K_Integer<UInt128>, K_UnsignedNumber<UInt128>
{
    /// <summary>
    /// The <see cref="__"/> interface is a <em>discard argument</em> meant to signify
    /// a lack of value and is used as a placeholder in type parameter lists.
    /// When combined with other discard arguments of other types, it can be used to create
    /// union-like behavior.
    /// </summary>
    public interface __ : Core.__, K_UInt128, IConstTypeArg<UInt128?>;
}

/// <summary>
/// The <see cref="K_UInt128{TSelf}"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;UInt128, K_UInt128&lt;TSelf&gt;&gt;</c> derived type.
/// </summary>
/// <typeparam name="TSelf">
/// The implementing type.
/// </typeparam>
/// <remarks>
/// Implement this interface for <see langword="UInt128"/> const type arguments in uncommon
/// scenarios where they need to be instantiated. Otherwise, use <see cref="K_UInt128"/> instead.
/// </remarks>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.uint128">
/// System.UInt128</seealso>
/// <seealso cref="UInt128{K}"/>
/// <seealso cref="K_UInt128Array{TSelf}"/>
public interface K_UInt128<TSelf> : K_UInt128, IConstTypeArg<UInt128, TSelf>
    where TSelf : K_UInt128<TSelf>;

/// <summary>
/// The <see cref="K_UInt128Array"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;UInt128[]&gt;</c> type.
/// </summary>
/// <remarks>
/// Implement this interface when defining <see langword="UInt128[]"/> const type arguments
/// rather than <see cref="K_Array{T}">K_Array&lt;UInt128&gt;</see>
/// or <see cref="IConstTypeArg{T}">IConstTypeArg&lt;UInt128[]&gt;</see>.
/// In uncommon scenarios where they need to be instantiated,
/// use <see cref="K_UInt128Array{TSelf}"/> instead.
/// </remarks>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.uint128">
/// System.UInt128</seealso>
/// <seealso cref="UInt128Array{K}"/>
/// <seealso cref="K_UInt128"/>
/// <seealso cref="__"/>
public interface K_UInt128Array : K_Array<UInt128>
{
    /// <summary>
    /// The <see cref="__"/> interface is a <em>discard argument</em> meant to signify
    /// a lack of value and is used as a placeholder in type parameter lists.
    /// When combined with other discard arguments of other types, it can be used to create
    /// union-like behavior.
    /// </summary>
    public interface __ : Core.__, K_UInt128Array;
}

/// <summary>
/// The <see cref="K_UInt128Array{TSelf}"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;UInt128[], K_UInt128Array&lt;TSelf&gt;&gt;</c> derived type.
/// </summary>
/// <typeparam name="TSelf">
/// The implementing type.
/// </typeparam>
/// <remarks>
/// Implement this interface for <see langword="UInt128[]"/> const type arguments in uncommon
/// scenarios where they need to be instantiated.
/// Otherwise, use <see cref="K_UInt128Array"/> instead.
/// </remarks>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.uint128">
/// System.UInt128</seealso>
/// <seealso cref="UInt128Array{K}"/>
/// <seealso cref="K_UInt128{TSelf}"/>
public interface K_UInt128Array<TSelf> : K_UInt128Array, IConstTypeArg<UInt128[], TSelf>
    where TSelf : K_UInt128Array<TSelf>;

/// <summary>
/// The <see cref="UInt128{K}"/> class provides a const argument provider that
/// wraps the <see langword="UInt128"/> value from another const argument provider.
/// </summary>
/// <typeparam name="K">
/// The const argument provider type containing the value to wrap.
/// </typeparam>
/// <remarks>
/// This class can be used to create domain-specific const type arguments or
/// to wrap const type arguments for reuse in other contexts.
/// </remarks>
/// <seealso cref="K_UInt128"/>
/// <seealso cref="UInt128Array{K}"/>
public abstract class UInt128<K> : K<UInt128, K>, K_UInt128
    where K : K_UInt128
{ public static UInt128 Value => K.Value; }

/// <summary>
/// The <see cref="UInt128Array{K}"/> class provides a const argument provider that
/// wraps the <see langword="UInt128"/> array from another const argument provider.
/// </summary>
/// <typeparam name="K">
/// The const argument provider type containing the array to wrap.
/// </typeparam>
/// <remarks>
/// This class can be used to create domain-specific const type arguments or
/// to wrap const type arguments for reuse in other contexts.
/// </remarks>
/// <seealso cref="K_UInt128Array"/>
/// <seealso cref="UInt128{K}"/>
public abstract class UInt128Array<K> : K<UInt128[], K>, K_UInt128Array
    where K : K_UInt128Array
{  public static UInt128[] Value => K.Value; }
