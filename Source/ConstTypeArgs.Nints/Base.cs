using ConstTypeArgs.Core;

#pragma warning disable IDE1006 // Naming Styles
#pragma warning disable CS1591  // Missing XML comment for publicly visible type or member
#pragma warning disable RCS1158 // Static member in generic type should use a type parameter

namespace ConstTypeArgs.Nints;

/// <summary>
/// The <see cref="K_Nint"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;nint&gt;</c> derived type.
/// </summary>
/// <remarks>
/// Implement this interface when defining <see langword="nint"/> const type arguments
/// rather than <see cref="K_Unmanaged{TSelf}">K_Unmanaged&lt;nint&gt;</see>,
/// <see cref="K_Integer{TSelf}">K_Integer&lt;nint&gt;</see>,
/// <see cref="K_SignedNumber{T}">K_UnsignedNumber&lt;nint&gt;</see>, or
/// <see cref="IConstTypeArg{T}">IConstTypeArg&lt;nint&gt;</see>.
/// In uncommon scenarios where they need to be instantiated,
/// use <see cref="K_Nint{TSelf}"/> instead.
/// </remarks>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.intptr">
/// System.IntPtr</seealso>
/// <seealso cref="Nint{K}"/>
/// <seealso cref="K_NintArray"/>
/// <seealso cref="__"/>
public interface K_Nint : K_Unmanaged<nint>, K_Integer<nint>, K_SignedNumber<nint>
{
    /// <summary>
    /// The <see cref="__"/> interface is a <em>discard argument</em> meant to signify
    /// a lack of value and is used as a placeholder in type parameter lists.
    /// When combined with other discard arguments of other types, it can be used to create
    /// union-like behavior.
    /// </summary>
    public interface __ : Core.__, K_Nint, IConstTypeArg<nint?>;
}

/// <summary>
/// The <see cref="K_Nint{TSelf}"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;nint, K_Nint&lt;TSelf&gt;&gt;</c> derived type.
/// </summary>
/// <typeparam name="TSelf">
/// The implementing type.
/// </typeparam>
/// <remarks>
/// Implement this interface for <see langword="nint"/> const type arguments in uncommon
/// scenarios where they need to be instantiated. Otherwise, use <see cref="K_Nint"/> instead.
/// </remarks>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.intptr">
/// System.IntPtr</seealso>
/// <seealso cref="Nint{K}"/>
/// <seealso cref="K_NintArray{TSelf}"/>
public interface K_Nint<TSelf> : K_Nint, IConstTypeArg<nint, TSelf>
    where TSelf : K_Nint<TSelf>;

/// <summary>
/// The <see cref="K_NintArray"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;nint[]&gt;</c> type.
/// </summary>
/// <remarks>
/// Implement this interface when defining <see langword="nint[]"/> const type arguments
/// rather than <see cref="K_Array{T}">K_Array&lt;nint&gt;</see>
/// or <see cref="IConstTypeArg{T}">IConstTypeArg&lt;nint[]&gt;</see>.
/// In uncommon scenarios where they need to be instantiated,
/// use <see cref="K_NintArray{TSelf}"/> instead.
/// </remarks>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.intptr">
/// System.IntPtr</seealso>
/// <seealso cref="NintArray{K}"/>
/// <seealso cref="K_Nint"/>
/// <seealso cref="__"/>
public interface K_NintArray : K_Array<nint>
{
    /// <summary>
    /// The <see cref="__"/> interface is a <em>discard argument</em> meant to signify
    /// a lack of value and is used as a placeholder in type parameter lists.
    /// When combined with other discard arguments of other types, it can be used to create
    /// union-like behavior.
    /// </summary>
    public interface __ : Core.__, K_NintArray;
}

/// <summary>
/// The <see cref="K_NintArray{TSelf}"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;nint[], K_NintArray&lt;TSelf&gt;&gt;</c> derived type.
/// </summary>
/// <typeparam name="TSelf">
/// The implementing type.
/// </typeparam>
/// <remarks>
/// Implement this interface for <see langword="nint[]"/> const type arguments in uncommon
/// scenarios where they need to be instantiated.
/// Otherwise, use <see cref="K_NintArray"/> instead.
/// </remarks>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.intptr">
/// System.IntPtr</seealso>
/// <seealso cref="NintArray{K}"/>
/// <seealso cref="K_Nint{TSelf}"/>
public interface K_NintArray<TSelf> : K_NintArray, IConstTypeArg<nint[], TSelf>
    where TSelf : K_NintArray<TSelf>;

/// <summary>
/// The <see cref="Nint{K}"/> class provides a const argument provider that
/// wraps the <see langword="nint"/> value from another const argument provider.
/// </summary>
/// <typeparam name="K">
/// The const argument provider type containing the value to wrap.
/// </typeparam>
/// <remarks>
/// This class can be used to create domain-specific const type arguments or
/// to wrap const type arguments for reuse in other contexts.
/// </remarks>
/// <seealso cref="K_Nint"/>
/// <seealso cref="NintArray{K}"/>
public abstract class Nint<K> : K<nint, K>, K_Nint
    where K : K_Nint
{ public static nint Value => K.Value; }

/// <summary>
/// The <see cref="NintArray{K}"/> class provides a const argument provider that
/// wraps the <see langword="nint"/> array from another const argument provider.
/// </summary>
/// <typeparam name="K">
/// The const argument provider type containing the array to wrap.
/// </typeparam>
/// <remarks>
/// This class can be used to create domain-specific const type arguments or
/// to wrap const type arguments for reuse in other contexts.
/// </remarks>
/// <seealso cref="K_NintArray"/>
/// <seealso cref="Nint{K}"/>
public abstract class NintArray<K> : K<nint[], K>, K_NintArray
    where K : K_NintArray
{ public static nint[] Value => K.Value; }