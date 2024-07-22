using ConstTypeArgs.Core;

#pragma warning disable IDE1006 // Naming Styles
#pragma warning disable CS1591  // Missing XML comment for publicly visible type or member
#pragma warning disable RCS1158 // Static member in generic type should use a type parameter

namespace ConstTypeArgs.Bytes;

/// <summary>
/// The <see cref="K_Byte"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;byte&gt;</c> derived type.
/// </summary>
/// <remarks>
/// Implement this interface when defining <see langword="byte"/> const type arguments
/// rather than <see cref="K_Unmanaged{TSelf}">K_Unmanaged&lt;byte&gt;</see>,
/// <see cref="K_Integer{TSelf}">K_Integer&lt;byte&gt;</see>,
/// <see cref="K_UnsignedNumber{T}">K_UnsignedNumber&lt;byte&gt;</see>, or
/// <see cref="IConstTypeArg{T}">IConstTypeArg&lt;byte&gt;</see>.
/// In uncommon scenarios where they need to be instantiated,
/// use <see cref="K_Byte{TSelf}"/> instead.
/// </remarks>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.byte">
/// System.Byte</seealso>
/// <seealso cref="Byte{K}"/>
/// <seealso cref="K_ByteArray"/>
/// <seealso cref="__"/>
public interface K_Byte : K_Unmanaged<byte>, K_Integer<byte>, K_UnsignedNumber<byte>
{
    /// <summary>
    /// The <see cref="__"/> interface is a <em>discard argument</em> meant to signify
    /// a lack of value and is used as a placeholder in type parameter lists.
    /// When combined with other discard arguments of other types, it can be used to create
    /// union-like behavior.
    /// </summary>
    public interface __ : Core.__, K_Byte, IConstTypeArg<byte?>;
}

/// <summary>
/// The <see cref="K_Byte{TSelf}"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;byte, K_Byte&lt;TSelf&gt;&gt;</c> derived type.
/// </summary>
/// <typeparam name="TSelf">
/// The implementing type.
/// </typeparam>
/// <remarks>
/// Implement this interface for <see langword="byte"/> const type arguments in uncommon
/// scenarios where they need to be instantiated. Otherwise, use <see cref="K_Byte"/> instead.
/// </remarks>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.byte">
/// System.Byte</seealso>
/// <seealso cref="Byte{K}"/>
/// <seealso cref="K_ByteArray{TSelf}"/>
public interface K_Byte<TSelf> : K_Byte, IConstTypeArg<byte, TSelf>
    where TSelf : K_Byte<TSelf>;

/// <summary>
/// The <see cref="K_ByteArray"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;byte[]&gt;</c> type.
/// </summary>
/// <remarks>
/// Implement this interface when defining <see langword="byte[]"/> const type arguments
/// rather than <see cref="K_Array{T}">K_Array&lt;byte&gt;</see>
/// or <see cref="IConstTypeArg{T}">IConstTypeArg&lt;byte[]&gt;</see>.
/// In uncommon scenarios where they need to be instantiated,
/// use <see cref="K_ByteArray{TSelf}"/> instead.
/// </remarks>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.byte">
/// System.Byte</seealso>
/// <seealso cref="ByteArray{K}"/>
/// <seealso cref="K_Byte"/>
/// <seealso cref="__"/>
public interface K_ByteArray : K_Array<byte>
{
    /// <summary>
    /// The <see cref="__"/> interface is a <em>discard argument</em> meant to signify
    /// a lack of value and is used as a placeholder in type parameter lists.
    /// When combined with other discard arguments of other types, it can be used to create
    /// union-like behavior.
    /// </summary>
    public interface __ : Core.__, K_ByteArray;
}

/// <summary>
/// The <see cref="K_ByteArray{TSelf}"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;byte[], K_ByteArray&lt;TSelf&gt;&gt;</c> derived type.
/// </summary>
/// <typeparam name="TSelf">
/// The implementing type.
/// </typeparam>
/// <remarks>
/// Implement this interface for <see langword="byte[]"/> const type arguments in uncommon
/// scenarios where they need to be instantiated.
/// Otherwise, use <see cref="K_ByteArray"/> instead.
/// </remarks>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.byte">
/// System.Byte</seealso>
/// <seealso cref="ByteArray{K}"/>
/// <seealso cref="K_Byte{TSelf}"/>
public interface K_ByteArray<TSelf> : K_ByteArray, IConstTypeArg<byte[], TSelf>
    where TSelf : K_ByteArray<TSelf>;

/// <summary>
/// The <see cref="Byte{K}"/> class provides a const type argument that
/// wraps a <see langword="byte"/> value from another const type argument.
/// </summary>
/// <typeparam name="K">
/// The argument provider containing the value to wrap.
/// </typeparam>
/// <remarks>
/// This class can be used to create domain-specific const type arguments or
/// to wrap const type arguments for reuse in other contexts.
/// </remarks>
/// <seealso cref="K_Byte"/>
/// <seealso cref="ByteArray{K}"/>
public abstract class Byte<K> : K<byte, K>, K_Byte
    where K : K_Byte
{ public static byte Value => K.Value; }

/// <summary>
/// The <see cref="ByteArray{K}"/> class provides a const type argument that
/// wraps a <see langword="byte"/> array from another const type argument.
/// </summary>
/// <typeparam name="K">
/// The argument provider containing the array to wrap.
/// </typeparam>
/// <remarks>
/// This class can be used to create domain-specific const type arguments or
/// to wrap const type arguments for reuse in other contexts.
/// </remarks>
/// <seealso cref="K_ByteArray"/>
/// <seealso cref="Byte{K}"/>
public abstract class ByteArray<K> : K<byte[], K>, K_ByteArray
    where K : K_ByteArray
{ public static byte[] Value => K.Value; }
