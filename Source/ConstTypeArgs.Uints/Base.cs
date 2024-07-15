using ConstTypeArgs.Core;

#pragma warning disable IDE1006 // Naming Styles
#pragma warning disable CS1591  // Missing XML comment for publicly visible type or member
#pragma warning disable RCS1158 // Static member in generic type should use a type parameter

namespace ConstTypeArgs.Uints;

/// <summary>
/// The <see cref="K_Uint"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;uint&gt;</c> derived type.
/// </summary>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.uint32">
/// System.UInt32</seealso>
/// <seealso cref="Uint{K}"/>
/// <seealso cref="K_UintArray"/>
public interface K_Uint
    : K_Unmanaged<uint>, K_Integer<uint>, K_UnsignedNumber<uint>;

/// <summary>
/// The <see cref="K_Uint{TSelf}"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;uint, K_Uint&lt;TSelf&gt;&gt;</c> derived type.
/// </summary>
/// <typeparam name="TSelf">
/// The implementing type.
/// </typeparam>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.uint32">
/// System.UInt32</seealso>
/// <seealso cref="Uint{K}"/>
/// <seealso cref="K_UintArray"/>
public interface K_Uint<TSelf>
    : K_Uint, IConstTypeArg<uint, TSelf>
    where TSelf : K_Uint<TSelf>;

/// <summary>
/// The <see cref="K_UintArray"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;uint[]&gt;</c> type.
/// </summary>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.uint32">
/// System.UInt32</seealso>
/// <seealso cref="UintArray{K}"/>
/// <seealso cref="K_Uint"/>
public interface K_UintArray
    : K_Array<uint>;

/// <summary>
/// The <see cref="K_UintArray{TSelf}"/> interface provides a more explicit
/// <c>IConstTypeArg&lt;uint[], K_UintArray&lt;TSelf&gt;&gt;</c> derived type.
/// </summary>
/// <typeparam name="TSelf">
/// The implementing type.
/// </typeparam>
/// <seealso href="https://learn.microsoft.com/dotnet/api/system.uint32">
/// System.UInt32</seealso>
/// <seealso cref="UintArray{K}"/>
/// <seealso cref="K_Uint{TSelf}"/>
public interface K_UintArray<TSelf>
    : K_UintArray, IConstTypeArg<uint[], TSelf>
    where TSelf : K_UintArray<TSelf>;

/// <summary>
/// The <see cref="Uint{K}"/> class provides a const argument provider that
/// wraps the <see langword="uint"/> value from another const argument provider.
/// </summary>
/// <typeparam name="K">
/// The const argument provider type containing the value to wrap.
/// </typeparam>
/// <remarks>
/// This class can be useful when creating domain-specific const argument providers,
/// such as default values, when a const argument provider's value needs to be
/// wrapped for use in a different context.
/// </remarks>
/// <seealso cref="UintArray{K}"/>
/// <seealso cref="K_Uint"/>
/// <seealso cref="K_Uint{TSelf}"/>
public class Uint<K> : K<uint, K>, K_Uint
    where K : K_Uint
{ public static uint Value => K.Value; }

/// <summary>
/// The <see cref="UintArray{K}"/> class provides a const argument provider that
/// wraps the <see langword="uint"/> array from another const argument provider.
/// </summary>
/// <typeparam name="K">
/// The const argument provider type containing the array to wrap.
/// </typeparam>
/// <remarks>
/// This class can be useful when creating domain-specific const argument providers,
/// such as default values, when a const argument provider's value needs to be
/// wrapped for use in a different context.
/// </remarks>
/// <seealso cref="Uint{K}"/>
/// <seealso cref="K_Uint"/>
public class UintArray<K> : K<uint[], K>, K_UintArray
    where K : K_UintArray
{ public static uint[] Value => K.Value; }
