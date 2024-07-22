using ConstTypeArgs.Core;

#pragma warning disable IDE1006 // Naming Styles
#pragma warning disable CS1591  // Missing XML comment for publicly visible type or member
#pragma warning disable RCS1158 // Static member in generic type should use a type parameter

namespace ConstTypeArgs.Ints;

/// <summary>
/// The <see cref="K_Int"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;int&gt;</c> derived type.
/// </summary>
/// <remarks>
/// Implement this interface when defining <see langword="int"/> const type arguments
/// rather than <see cref="K_Unmanaged{TSelf}">K_Unmanaged&lt;int&gt;</see>,
/// <see cref="K_Integer{TSelf}">K_Integer&lt;int&gt;</see>,
/// <see cref="K_SignedNumber{T}">K_UnsignedNumber&lt;int&gt;</see>, or
/// <see cref="IConstTypeArg{T}">IConstTypeArg&lt;int&gt;</see>.
/// In uncommon scenarios where they need to be instantiated,
/// use <see cref="K_Int{TSelf}"/> instead.
/// </remarks>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.int32">
/// System.Int32</seealso>
/// <seealso cref="Int{K}"/>
/// <seealso cref="K_IntArray"/>
/// <seealso cref="__"/>
public interface K_Int : K_Unmanaged<int>, K_Integer<int>, K_SignedNumber<int>
{
    /// <summary>
    /// The <see cref="__"/> interface is a <em>discard argument</em> meant to signify
    /// a lack of value and is used as a placeholder in type parameter lists.
    /// When combined with other discard arguments of other types, it can be used to create
    /// union-like behavior.
    /// </summary>
    public interface __ : Core.__, K_Int, IConstTypeArg<int?>;
}

/// <summary>
/// The <see cref="K_Int{TSelf}"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;int, K_Int&lt;TSelf&gt;&gt;</c> derived type.
/// </summary>
/// <typeparam name="TSelf">
/// The implementing type.
/// </typeparam>
/// <remarks>
/// Implement this interface for <see langword="int"/> const type arguments in uncommon
/// scenarios where they need to be instantiated. Otherwise, use <see cref="K_Int"/> instead.
/// </remarks>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.int32">
/// System.Int32</seealso>
/// <seealso cref="Int{K}"/>
/// <seealso cref="K_IntArray{TSelf}"/>
public interface K_Int<TSelf> : K_Int, IConstTypeArg<int, TSelf>
    where TSelf : K_Int<TSelf>;

/// <summary>
/// The <see cref="K_IntArray"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;int[]&gt;</c> type.
/// </summary>
/// <remarks>
/// Implement this interface when defining <see langword="int[]"/> const type arguments
/// rather than <see cref="K_Array{T}">K_Array&lt;int&gt;</see>
/// or <see cref="IConstTypeArg{T}">IConstTypeArg&lt;int[]&gt;</see>.
/// In uncommon scenarios where they need to be instantiated,
/// use <see cref="K_IntArray{TSelf}"/> instead.
/// </remarks>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.int32">
/// System.Int32</seealso>
/// <seealso cref="IntArray{K}"/>
/// <seealso cref="K_Int"/>
/// <seealso cref="__"/>
public interface K_IntArray : K_Array<int>
{
    /// <summary>
    /// The <see cref="__"/> interface is a <em>discard argument</em> meant to signify
    /// a lack of value and is used as a placeholder in type parameter lists.
    /// When combined with other discard arguments of other types, it can be used to create
    /// union-like behavior.
    /// </summary>
    public interface __ : Core.__, K_IntArray;
}

/// <summary>
/// The <see cref="K_IntArray{TSelf}"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;int[], K_IntArray&lt;TSelf&gt;&gt;</c> derived type.
/// </summary>
/// <typeparam name="TSelf">
/// The implementing type.
/// </typeparam>
/// <remarks>
/// Implement this interface for <see langword="int[]"/> const type arguments in uncommon
/// scenarios where they need to be instantiated.
/// Otherwise, use <see cref="K_IntArray"/> instead.
/// </remarks>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.int32">
/// System.Int32</seealso>
/// <seealso cref="IntArray{K}"/>
/// <seealso cref="K_Int{TSelf}"/>
public interface K_IntArray<TSelf> : K_IntArray, IConstTypeArg<int[], TSelf>
    where TSelf : K_IntArray<TSelf>;

/// <summary>
/// The <see cref="Int{K}"/> class provides a const argument provider that
/// wraps the <see langword="int"/> value from another const argument provider.
/// </summary>
/// <typeparam name="K">
/// The const argument provider type containing the value to wrap.
/// </typeparam>
/// <remarks>
/// This class can be used to create domain-specific const type arguments or
/// to wrap const type arguments for reuse in other contexts.
/// </remarks>
/// <seealso cref="K_Int"/>
/// <seealso cref="IntArray{K}"/>
public abstract class Int<K> : K<int, K>, K_Int
    where K : K_Int
{ public static int Value => K.Value; }

/// <summary>
/// The <see cref="IntArray{K}"/> class provides a const argument provider that
/// wraps the <see langword="int"/> array from another const argument provider.
/// </summary>
/// <typeparam name="K">
/// The const argument provider type containing the array to wrap.
/// </typeparam>
/// <remarks>
/// This class can be used to create domain-specific const type arguments or
/// to wrap const type arguments for reuse in other contexts.
/// </remarks>
/// <seealso cref="K_IntArray"/>
/// <seealso cref="Int{K}"/>
public abstract class IntArray<K> : K<int[], K>, K_IntArray
    where K : K_IntArray
{ public static int[] Value => K.Value; }
