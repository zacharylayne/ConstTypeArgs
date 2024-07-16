using ConstTypeArgs.Core;

#pragma warning disable IDE1006 // Naming Styles
#pragma warning disable CS1591  // Missing XML comment for publicly visible type or member
#pragma warning disable RCS1158 // Static member in generic type should use a type parameter

namespace ConstTypeArgs.Ushorts;

/// <summary>
/// The <see cref="K_Ushort"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;ushort&gt;</c> derived type.
/// </summary>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.uint16">
/// System.UInt16</seealso>
/// <seealso cref="Ushort{K}"/>
/// <seealso cref="K_UshortArray"/>
public interface K_Ushort
    : K_Unmanaged<ushort>, K_Integer<ushort>, K_UnsignedNumber<ushort>;

/// <summary>
/// The <see cref="K_Ushort{TSelf}"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;ushort, K_Ushort&lt;TSelf&gt;&gt;</c> derived type.
/// </summary>
/// <typeparam name="TSelf">
/// The implementing type.
/// </typeparam>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.uint16">
/// System.UInt16</seealso>
/// <seealso cref="Ushort{K}"/>
/// <seealso cref="K_UshortArray{TSelf}"/>
public interface K_Ushort<TSelf>
    : K_Ushort, IConstTypeArg<ushort, TSelf>
    where TSelf : K_Ushort<TSelf>;

/// <summary>
/// The <see cref="K_UshortArray"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;ushort[]&gt;</c> type.
/// </summary>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.uint16">
/// System.UInt16</seealso>
/// <seealso cref="UshortArray{K}"/>
/// <seealso cref="K_Ushort"/>
public interface K_UshortArray
    : K_Array<ushort>;

/// <summary>
/// The <see cref="K_UshortArray{TSelf}"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;ushort[], K_UshortArray&lt;TSelf&gt;&gt;</c> derived type.
/// </summary>
/// <typeparam name="TSelf">
/// The implementing type.
/// </typeparam>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.uint16">
/// System.UInt16</seealso>
/// <seealso cref="UshortArray{K}"/>
/// <seealso cref="K_Ushort{TSelf}"/>
public interface K_UshortArray<TSelf>
    : K_UshortArray, IConstTypeArg<ushort[], TSelf>
    where TSelf : K_UshortArray<TSelf>;

/// <summary>
/// The <see cref="Ushort{K}"/> class provides a const argument provider that
/// wraps the <see langword="ushort"/> value from another const argument provider.
/// </summary>
/// <typeparam name="K">
/// The const argument provider type containing the value to wrap.
/// </typeparam>
/// <remarks>
/// This class can be useful when creating domain-specific const argument providers,
/// such as default values, when a const argument provider's value needs to be
/// wrapped for use in a different context.
/// </remarks>
/// <seealso cref="UshortArray{K}"/>
/// <seealso cref="K_Ushort"/>
/// <seealso cref="K_Ushort{TSelf}"/>
public class Ushort<K> : K<ushort, K>, K_Ushort
    where K : K_Ushort
{ public static ushort Value => K.Value; }

/// <summary>
/// The <see cref="UshortArray{K}"/> class provides a const argument provider that
/// wraps the <see langword="ushort"/> array from another const argument provider.
/// </summary>
/// <typeparam name="K">
/// The const argument provider type containing the array to wrap.
/// </typeparam>
/// <remarks>
/// This class can be useful when creating domain-specific const argument providers,
/// such as default values, when a const argument provider's value needs to be
/// wrapped for use in a different context.
/// </remarks>
/// <seealso cref="Ushort{K}"/>
/// <seealso cref="K_Ushort"/>
public class UshortArray<K> : K<ushort[], K>, K_UshortArray
    where K : K_UshortArray
{ public static ushort[] Value => K.Value; }
