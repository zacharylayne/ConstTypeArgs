using ConstTypeArgs.Core;

#pragma warning disable IDE1006 // Naming Styles
#pragma warning disable CS1591  // Missing XML comment for publicly visible type or member
#pragma warning disable RCS1158 // Static member in generic type should use a type parameter

namespace ConstTypeArgs.Bytes;

/// <summary>
/// The <see cref="K_Byte"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;byte&gt;</c> derived type.
/// </summary>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.byte">
/// Byte</seealso>
/// <seealso cref="Byte{K}"/>
/// <seealso cref="K_ByteArray"/>
public interface K_Byte
    : K_Unmanaged<byte>, K_Integer<byte>, K_UnsignedNumber<byte>;

/// <summary>
/// The <see cref="K_Byte{TSelf}"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;byte, K_Byte&lt;TSelf&gt;&gt;</c> derived type.
/// </summary>
/// <typeparam name="TSelf">
/// The implementing type.
/// </typeparam>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.byte">
/// Byte</seealso>
/// <seealso cref="Byte{K}"/>
/// <seealso cref="K_ByteArray{TSelf}"/>
public interface K_Byte<TSelf>
    : K_Byte, IConstTypeArg<byte, TSelf>
    where TSelf : K_Byte<TSelf>;

/// <summary>
/// The <see cref="K_ByteArray"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;byte[]&gt;</c> type.
/// </summary>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.byte">
/// System.Byte</seealso>
/// <seealso cref="ByteArray{K}"/>
/// <seealso cref="K_Byte"/>
public interface K_ByteArray
    : K_Array<byte>;

/// <summary>
/// The <see cref="K_ByteArray{TSelf}"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;byte[], K_ByteArray&lt;TSelf&gt;&gt;</c> derived type.
/// </summary>
/// <typeparam name="TSelf">
/// The implementing type.
/// </typeparam>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.byte">
/// System.Byte</seealso>
/// <seealso cref="ByteArray{K}"/>
/// <seealso cref="K_Byte{TSelf}"/>
public interface K_ByteArray<TSelf>
    : K_ByteArray, IConstTypeArg<byte[], TSelf>
    where TSelf : K_ByteArray<TSelf>;

/// <summary>
/// The <see cref="Byte{K}"/> class provides a const argument provider that
/// wraps the <see langword="byte"/> value from another const argument provider.
/// </summary>
/// <typeparam name="K">
/// The const argument provider type containing the value to wrap.
/// </typeparam>
/// <remarks>
/// This class can be useful when creating domain-specific const argument providers,
/// such as default values, when a const argument provider's value needs to be
/// wrapped for use in a different context.
/// </remarks>
/// <seealso cref="ByteArray{K}"/>
/// <seealso cref="K_Byte"/>
/// <seealso cref="K_Byte{TSelf}"/>
public class Byte<K> : K<byte, K>, K_Byte
    where K : K_Byte
{ public static byte Value => K.Value; }

/// <summary>
/// The <see cref="ByteArray{K}"/> class provides a const argument provider that
/// wraps the <see langword="byte"/> array from another const argument provider.
/// </summary>
/// <typeparam name="K">
/// The const argument provider type containing the array to wrap.
/// </typeparam>
/// <remarks>
/// This class can be useful when creating domain-specific const argument providers,
/// such as default values, when a const argument provider's value needs to be
/// wrapped for use in a different context.
/// </remarks>
/// <seealso cref="K_Byte"/>
/// <seealso cref="Byte{K}"/>
public class ByteArray<K> : K<byte[], K>, K_ByteArray
    where K : K_ByteArray
{ public static byte[] Value => K.Value; }
