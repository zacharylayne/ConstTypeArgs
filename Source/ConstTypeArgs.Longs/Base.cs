using ConstTypeArgs.Core;

#pragma warning disable IDE1006 // Naming Styles
#pragma warning disable CS1591  // Missing XML comment for publicly visible type or member
#pragma warning disable RCS1158 // Static member in generic type should use a type parameter

namespace ConstTypeArgs.Longs;

/// <summary>
/// The <see cref="K_Long"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;long&gt;</c> derived type.
/// </summary>
/// <remarks>
/// Implement this interface when defining <see langword="long"/> const type arguments
/// rather than <see cref="K_Unmanaged{TSelf}">K_Unmanaged&lt;long&gt;</see>,
/// <see cref="K_Integer{TSelf}">K_Integer&lt;long&gt;</see>,
/// <see cref="K_SignedNumber{T}">K_UnsignedNumber&lt;long&gt;</see>, or
/// <see cref="IConstTypeArg{T}">IConstTypeArg&lt;long&gt;</see>.
/// In uncommon scenarios where they need to be instantiated,
/// use <see cref="K_Long{TSelf}"/> instead.
/// </remarks>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.int64">
/// System.Int64</seealso>
/// <seealso cref="Long{K}"/>
/// <seealso cref="K_LongArray"/>
/// <seealso cref="__"/>
public interface K_Long : K_Unmanaged<long>, K_Integer<long>, K_SignedNumber<long>
{
    /// <summary>
    /// The <see cref="__"/> interface is a <em>discard argument</em> meant to signify
    /// a lack of value and is used as a placeholder in type parameter lists.
    /// When combined with other discard arguments of other types, it can be used to create
    /// union-like behavior.
    /// </summary>
    public interface __ : Core.__, K_Long, IConstTypeArg<long?>;
}
/// <summary>
/// The <see cref="K_Long{TSelf}"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;long, K_Long&lt;TSelf&gt;&gt;</c> derived type.
/// </summary>
/// <typeparam name="TSelf">
/// The implementing type.
/// </typeparam>
/// <remarks>
/// Implement this interface for <see langword="long"/> const type arguments in uncommon
/// scenarios where they need to be instantiated. Otherwise, use <see cref="K_Long"/> instead.
/// </remarks>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.int64">
/// System.Int64</seealso>
/// <seealso cref="Long{K}"/>
/// <seealso cref="K_LongArray{TSelf}"/>
public interface K_Long<TSelf> : K_Long, IConstTypeArg<long, TSelf>
    where TSelf : K_Long<TSelf>;

/// <summary>
/// The <see cref="K_LongArray"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;long[]&gt;</c> type.
/// </summary>
/// <remarks>
/// Implement this interface when defining <see langword="long[]"/> const type arguments
/// rather than <see cref="K_Array{T}">K_Array&lt;long&gt;</see>
/// or <see cref="IConstTypeArg{T}">IConstTypeArg&lt;long[]&gt;</see>.
/// In uncommon scenarios where they need to be instantiated,
/// use <see cref="K_LongArray{TSelf}"/> instead.
/// </remarks>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.int64">
/// System.Int64</seealso>
/// <seealso cref="LongArray{K}"/>
/// <seealso cref="K_Long"/>
/// <seealso cref="__"/>
public interface K_LongArray : K_Array<long>
{
    /// <summary>
    /// The <see cref="__"/> interface is a <em>discard argument</em> meant to signify
    /// a lack of value and is used as a placeholder in type parameter lists.
    /// When combined with other discard arguments of other types, it can be used to create
    /// union-like behavior.
    /// </summary>
    public interface __ : Core.__, K_LongArray;
}

/// <summary>
/// The <see cref="K_LongArray{TSelf}"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;long[], K_LongArray&lt;TSelf&gt;&gt;</c> derived type.
/// </summary>
/// <typeparam name="TSelf">
/// The implementing type.
/// </typeparam>
/// <remarks>
/// Implement this interface for <see langword="long[]"/> const type arguments in uncommon
/// scenarios where they need to be instantiated.
/// Otherwise, use <see cref="K_LongArray"/> instead.
/// </remarks>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.int64">
/// System.Int64</seealso>
/// <seealso cref="LongArray{K}"/>
/// <seealso cref="K_Long{TSelf}"/>
public interface K_LongArray<TSelf> : K_LongArray, IConstTypeArg<long[], TSelf>
    where TSelf : K_LongArray<TSelf>;

/// <summary>
/// The <see cref="Long{K}"/> class provides a const argument provider that
/// wraps the <see langword="long"/> value from another const argument provider.
/// </summary>
/// <typeparam name="K">
/// The const argument provider type containing the value to wrap.
/// </typeparam>
/// <remarks>
/// This class can be used to create domain-specific const type arguments or
/// to wrap const type arguments for reuse in other contexts.
/// </remarks>
/// <seealso cref="K_Long"/>
/// <seealso cref="LongArray{K}"/>
public abstract class Long<K> : K<long, K>, K_Long
    where K : K_Long
{ public static long Value => K.Value; }

/// <summary>
/// The <see cref="LongArray{K}"/> class provides a const argument provider that
/// wraps the <see langword="long"/> array from another const argument provider.
/// </summary>
/// <typeparam name="K">
/// The const argument provider type containing the array to wrap.
/// </typeparam>
/// <remarks>
/// This class can be used to create domain-specific const type arguments or
/// to wrap const type arguments for reuse in other contexts.
/// </remarks>
/// <seealso cref="K_LongArray"/>
/// <seealso cref="Long{K}"/>
public abstract class LongArray<K> : K<long[], K>, K_LongArray
    where K : K_LongArray
{ public static long[] Value => K.Value; }
