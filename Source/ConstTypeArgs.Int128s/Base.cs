using ConstTypeArgs.Core;

#pragma warning disable IDE1006 // Naming Styles
#pragma warning disable CS1591  // Missing XML comment for publicly visible type or member
#pragma warning disable RCS1158 // Static member in generic type should use a type parameter

namespace ConstTypeArgs.Int128s;

/// <summary>
/// The <see cref="K_Int128"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;Int128&gt;</c> derived type.
/// </summary>
/// <remarks>
/// Implement this interface when defining
/// <see href="https://learn.microsoft.com/dotnet/api/system.int128">Int128</see>
/// const type arguments
/// rather than <see cref="K_Unmanaged{TSelf}">K_Unmanaged&lt;Int128&gt;</see>,
/// <see cref="K_Integer{TSelf}">K_Integer&lt;Int128&gt;</see>,
/// <see cref="K_SignedNumber{T}">K_UnsignedNumber&lt;Int128&gt;</see>, or
/// <see cref="IConstTypeArg{T}">IConstTypeArg&lt;Int128&gt;</see>.
/// In uncommon scenarios where they need to be instantiated,
/// use <see cref="K_Int128{TSelf}"/> instead.
/// </remarks>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.int128">
/// System.Int128</seealso>
/// <seealso cref="Int128{K}"/>
/// <seealso cref="K_Int128Array"/>
/// <seealso cref="__"/>
public interface K_Int128
    : K_Unmanaged<Int128>, K_Integer<Int128>, K_SignedNumber<Int128>
{
    /// <summary>
    /// The <see cref="__"/> interface is a <em>discard argument</em> meant to signify
    /// a lack of value and is used as a placeholder in type parameter lists.
    /// When combined with other discard arguments of other types, it can be used to create
    /// union-like behavior.
    /// </summary>
    public interface __ : Core.__, K_Int128, IConstTypeArg<Int128?>;
}

/// <summary>
/// The <see cref="K_Int128{TSelf}"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;Int128, K_Int128&lt;TSelf&gt;&gt;</c> derived type.
/// </summary>
/// <typeparam name="TSelf">
/// The implementing type.
/// </typeparam>
/// <remarks>
/// Implement this interface for <see langword="Int128"/> const type arguments in uncommon
/// scenarios where they need to be instantiated. Otherwise, use <see cref="K_Int128"/> instead.
/// </remarks>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.int128">
/// System.Int128</seealso>
/// <seealso cref="Int128{K}"/>
/// <seealso cref="K_Int128Array{TSelf}"/>
public interface K_Int128<TSelf> : K_Int128, IConstTypeArg<Int128, TSelf>
    where TSelf : K_Int128<TSelf>;

/// <summary>
/// The <see cref="K_Int128Array"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;Int128[]&gt;</c> type.
/// </summary>
/// <remarks>
/// Implement this interface when defining <see langword="Int128[]"/> const type arguments
/// rather than <see cref="K_Array{T}">K_Array&lt;Int128&gt;</see>
/// or <see cref="IConstTypeArg{T}">IConstTypeArg&lt;Int128[]&gt;</see>.
/// In uncommon scenarios where they need to be instantiated,
/// use <see cref="K_Int128Array{TSelf}"/> instead.
/// </remarks>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.int128">
/// System.Int128</seealso>
/// <seealso cref="Int128Array{K}"/>
/// <seealso cref="K_Int128"/>
/// <seealso cref="__"/>
public interface K_Int128Array : K_Array<Int128>
{
    /// <summary>
    /// The <see cref="__"/> interface is a <em>discard argument</em> meant to signify
    /// a lack of value and is used as a placeholder in type parameter lists.
    /// When combined with other discard arguments of other types, it can be used to create
    /// union-like behavior.
    /// </summary>
    public interface __ : Core.__, K_Int128Array;
}

/// <summary>
/// The <see cref="K_Int128Array{TSelf}"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;Int128[], K_Int128Array&lt;TSelf&gt;&gt;</c> derived type.
/// </summary>
/// <typeparam name="TSelf">
/// The implementing type.
/// </typeparam>
/// <remarks>
/// Implement this interface for <see langword="Int128[]"/> const type arguments in uncommon
/// scenarios where they need to be instantiated.
/// Otherwise, use <see cref="K_Int128Array"/> instead.
/// </remarks>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.int128">
/// System.Int128</seealso>
/// <seealso cref="Int128Array{K}"/>
/// <seealso cref="K_Int128{TSelf}"/>
public interface K_Int128Array<TSelf> : K_Int128Array, IConstTypeArg<Int128[], TSelf>
    where TSelf : K_Int128Array<TSelf>;

/// <summary>
/// The <see cref="Int128{K}"/> class provides a const argument provider that
/// wraps the <see langword="Int128"/> value from another const argument provider.
/// </summary>
/// <typeparam name="K">
/// The const argument provider type containing the value to wrap.
/// </typeparam>
/// <remarks>
/// This class can be used to create domain-specific const type arguments or
/// to wrap const type arguments for reuse in other contexts.
/// </remarks>
/// <seealso cref="K_Int128"/>
/// <seealso cref="Int128Array{K}"/>
public abstract class Int128<K> : K<Int128, K>, K_Int128
    where K : K_Int128
{ public static Int128 Value => K.Value; }

/// <summary>
/// The <see cref="Int128Array{K}"/> class provides a const argument provider that
/// wraps the <see langword="Int128"/> array from another const argument provider.
/// </summary>
/// <typeparam name="K">
/// The const argument provider type containing the array to wrap.
/// </typeparam>
/// <remarks>
/// This class can be used to create domain-specific const type arguments or
/// to wrap const type arguments for reuse in other contexts.
/// </remarks>
/// <seealso cref="K_Int128Array"/>
/// <seealso cref="Int128{K}"/>
public abstract class Int128Array<K> : K<Int128[], K>, K_Int128Array
    where K : K_Int128Array
{ public static Int128[] Value => K.Value; }
