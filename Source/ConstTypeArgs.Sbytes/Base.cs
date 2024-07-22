using ConstTypeArgs.Core;

#pragma warning disable IDE1006 // Naming Styles
#pragma warning disable CS1591  // Missing XML comment for publicly visible type or member
#pragma warning disable RCS1158 // Static member in generic type should use a type parameter

namespace ConstTypeArgs.Sbytes;

/// <summary>
/// The <see cref="K_Sbyte"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;sbyte&gt;</c> derived type.
/// </summary>
/// <remarks>
/// Implement this interface when defining <see langword="sbyte"/> const type arguments
/// rather than <see cref="K_Unmanaged{TSelf}">K_Unmanaged&lt;sbyte&gt;</see>,
/// <see cref="K_Integer{TSelf}">K_Integer&lt;sbyte&gt;</see>,
/// <see cref="K_SignedNumber{T}">K_UnsignedNumber&lt;sbyte&gt;</see>, or
/// <see cref="IConstTypeArg{T}">IConstTypeArg&lt;sbyte&gt;</see>.
/// In uncommon scenarios where they need to be instantiated,
/// use <see cref="K_Sbyte{TSelf}"/> instead.
/// </remarks>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.sbyte">
/// System.SByte</seealso>
/// <seealso cref="Sbyte{K}"/>
/// <seealso cref="K_SbyteArray"/>
/// <seealso cref="__"/>
public interface K_Sbyte : K_Unmanaged<sbyte>, K_Integer<sbyte>, K_SignedNumber<sbyte>
{
    /// <summary>
    /// The <see cref="__"/> interface is a <em>discard argument</em> meant to signify
    /// a lack of value and is used as a placeholder in type parameter lists.
    /// When combined with other discard arguments of other types, it can be used to create
    /// union-like behavior.
    /// </summary>
    public interface __ : Core.__, K_Sbyte, IConstTypeArg<sbyte?>;
}

/// <summary>
/// The <see cref="K_Sbyte{TSelf}"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;sbyte, K_Sbyte&lt;TSelf&gt;&gt;</c> derived type.
/// </summary>
/// <typeparam name="TSelf">
/// The implementing type.
/// </typeparam>
/// <remarks>
/// Implement this interface for <see langword="sbyte"/> const type arguments in uncommon
/// scenarios where they need to be instantiated. Otherwise, use <see cref="K_Sbyte"/> instead.
/// </remarks>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.sbyte">
/// System.SByte</seealso>
/// <seealso cref="Sbyte{K}"/>
/// <seealso cref="K_SbyteArray{TSelf}"/>
public interface K_Sbyte<TSelf> : K_Sbyte, IConstTypeArg<sbyte, TSelf>
    where TSelf : K_Sbyte<TSelf>;

/// <summary>
/// The <see cref="K_SbyteArray"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;sbyte[]&gt;</c> type.
/// </summary>
/// <remarks>
/// Implement this interface when defining <see langword="sbyte[]"/> const type arguments
/// rather than <see cref="K_Array{T}">K_Array&lt;sbyte&gt;</see>
/// or <see cref="IConstTypeArg{T}">IConstTypeArg&lt;sbyte[]&gt;</see>.
/// In uncommon scenarios where they need to be instantiated,
/// use <see cref="K_SbyteArray{TSelf}"/> instead.
/// </remarks>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.sbyte">
/// System.SByte</seealso>
/// <seealso cref="SbyteArray{K}"/>
/// <seealso cref="K_Sbyte"/>
/// <seealso cref="__"/>
public interface K_SbyteArray : K_Array<sbyte>
{
    /// <summary>
    /// The <see cref="__"/> interface is a <em>discard argument</em> meant to signify
    /// a lack of value and is used as a placeholder in type parameter lists.
    /// When combined with other discard arguments of other types, it can be used to create
    /// union-like behavior.
    /// </summary>
    public interface __ : Core.__, K_SbyteArray;
}

/// <summary>
/// The <see cref="K_SbyteArray{TSelf}"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;sbyte[], K_SbyteArray&lt;TSelf&gt;&gt;</c> derived type.
/// </summary>
/// <typeparam name="TSelf">
/// The implementing type.
/// </typeparam>
/// <remarks>
/// Implement this interface for <see langword="sbyte[]"/> const type arguments in uncommon
/// scenarios where they need to be instantiated.
/// Otherwise, use <see cref="K_SbyteArray"/> instead.
/// </remarks>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.sbyte">
/// System.SByte</seealso>
/// <seealso cref="SbyteArray{K}"/>
/// <seealso cref="K_Sbyte{TSelf}"/>
public interface K_SbyteArray<TSelf> : K_SbyteArray, IConstTypeArg<sbyte[], TSelf>
    where TSelf : K_SbyteArray<TSelf>;

/// <summary>
/// The <see cref="Sbyte{K}"/> class provides a const argument provider that
/// wraps the <see langword="sbyte"/> value from another const argument provider.
/// </summary>
/// <typeparam name="K">
/// The const argument provider type containing the value to wrap.
/// </typeparam>
/// <remarks>
/// This class can be used to create domain-specific const type arguments or
/// to wrap const type arguments for reuse in other contexts.
/// </remarks>
/// <seealso cref="K_Sbyte"/>
/// <seealso cref="SbyteArray{K}"/>
public abstract class Sbyte<K> : K<sbyte, K>, K_Sbyte
    where K : K_Sbyte
{ public static sbyte Value => K.Value; }

/// <summary>
/// The <see cref="SbyteArray{K}"/> class provides a const argument provider that
/// wraps the <see langword="sbyte"/> array from another const argument provider.
/// </summary>
/// <typeparam name="K">
/// The const argument provider type containing the array to wrap.
/// </typeparam>
/// <remarks>
/// This class can be used to create domain-specific const type arguments or
/// to wrap const type arguments for reuse in other contexts.
/// </remarks>
/// <seealso cref="K_SbyteArray"/>
/// <seealso cref="Sbyte{K}"/>
public abstract class SbyteArray<K> : K<sbyte[], K>, K_SbyteArray
    where K : K_SbyteArray
{ public static sbyte[] Value => K.Value; }
